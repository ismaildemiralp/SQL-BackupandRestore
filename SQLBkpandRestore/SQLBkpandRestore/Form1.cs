using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLBkpandRestore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeToolTips();
        }

        private void InitializeToolTips()
        {

            // Buton'lar için ToolTips
            toolTip1.SetToolTip(this.btnConn, "Butona tıklanıldığında Local SQL sunucuya bağlantı sağlanır");
            toolTip1.SetToolTip(this.btnLinux, "Butona tıklanıldığında /var/opt/mssql/data klasörüne yedek alınmaktadır");
            toolTip1.SetToolTip(this.btnWindows, "Butona tıklanıldığında istenilen klasöre yedek dosyaları alınabilir. Klasör izinlerine dikkat edilmelidir");
            toolTip1.SetToolTip(this.btnSelectRes, "Butona tıklanıldığında restore edilmesini istediğiniz databaseleri seçmek için Windows'ta pencere açar. Ctrl tuşuna basılı tutarak birden fazla seçim yapabilirsiniz");
            toolTip1.SetToolTip(this.btnTransferLogin, "Butona tıklanıldığında local SQL server'da buluanan logins bilgilerini remote host'ta bilgileri girilen SQL sunucuya aktarır");
            toolTip1.SetToolTip(this.btnStartRestore, "Butona tıklanıldığında listede seçilen databaseleri remote host'ta bilgileri girilen SQL sunucuya restore eder");

            // Textbox'lar için ToolTips
            toolTip1.SetToolTip(this.txthostname, "Yedek alınmasını istediğiniz SQL sunucu adını veya IP adresini giriniz");
            toolTip1.SetToolTip(this.txthostpwd, "SQL sunucu şifresini giriniz");
            toolTip1.SetToolTip(this.txtremotename, "Restore  edilmesini istediğiniz SQL sunucu adını veya IP adresini giriniz");
            toolTip1.SetToolTip(this.txtremotepwd, "SQL sunucu şifresini giriniz");
        }

        public string RemoteServerName { get; private set; }
        public string RemoteUsername { get; private set; }
        public string RemotePassword { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            txthostpwd.Text = "Password";
            txthostname.Text = "Server Name / Host IP";
            txthostsa.Text = "sa";
            txthostsa.ReadOnly = true;
            txthostpwd.PasswordChar = '\0';

            txtremotepwd.Text = "Password";
            txtremotename.Text = "Server Name / Host IP";
            txtremotesa.Text = "sa";
            txtremotesa.ReadOnly = true;
            txtremotepwd.PasswordChar = '\0';
        }

        private void chkhostpwd_CheckedChanged(object sender, EventArgs e)
        {
            txthostpwd.PasswordChar = chkhostpwd.Checked ? '\0' : '●';
        }

        private void txthostpwd_Enter(object sender, EventArgs e)
        {
            if (txthostpwd.Text == "Password")
            {
                txthostpwd.Text = "";
                txthostpwd.PasswordChar = '●';
            }
        }

        private void txthostpwd_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txthostpwd.Text))
            {
                txthostpwd.Text = "Password";
                txthostpwd.PasswordChar = '\0';
            }
        }

        private void txthostname_Enter(object sender, EventArgs e)
        {
            if (txthostname.Text == "Server Name / Host IP")
            {
                txthostname.Text = "";
            }
        }

        private void txthostname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthostname.Text))
            {
                txthostname.Text = "Server Name / Host IP";
            }
        }

        private void chkremotepwd_CheckedChanged(object sender, EventArgs e)
        {
            txtremotepwd.PasswordChar = chkremotepwd.Checked ? '\0' : '●';
        }

        private void txtremotepwd_Enter(object sender, EventArgs e)
        {
            if (txtremotepwd.Text == "Password")
            {
                txtremotepwd.Text = "";
                txtremotepwd.PasswordChar = '●';
            }
        }

        private void txtremotepwd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtremotepwd.Text))
            {
                txtremotepwd.Text = "Password";
                txtremotepwd.PasswordChar = '\0';
            }
        }

        private void txtremotename_Enter(object sender, EventArgs e)
        {
            if (txtremotename.Text == "Server Name / Host IP")
            {
                txtremotename.Text = "";
            }
        }

        private void txtremotename_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtremotename.Text))
            {
                txtremotename.Text = "Server Name / Host IP";
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            string serverName = txthostname.Text.Trim();
            string username = txthostsa.Text.Trim();
            string password = txthostpwd.Text;

            if (string.IsNullOrWhiteSpace(serverName))
            {
                MessageBox.Show("IP adres girilmelidir, boş bırakılamaz. Geçerli IP adresi girilmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!IsValidIP(serverName) && !IsValidHostname(serverName))
            {
                MessageBox.Show("IP adres girilmelidir, boş bırakılamaz. Geçerli IP adresi girilmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string masterConnectionString = $"Data Source={serverName};Initial Catalog=master;User ID={username};Password={password}";
            using (SqlConnection masterConnection = new SqlConnection(masterConnectionString))
            {
                try
                {
                    masterConnection.Open();

                    DataTable databasesTable = masterConnection.GetSchema("Databases");
                    chklistboxDb.Items.Clear();

                    foreach (DataRow row in databasesTable.Rows)
                    {
                        string databaseName = row["database_name"].ToString();

                        if (databaseName != "master" && databaseName != "tempdb" && databaseName != "model" && databaseName != "msdb")
                        {
                            chklistboxDb.Items.Add(databaseName);
                        }
                    }

                    chklistboxlogin.Items.Clear();
                    ListLogins(masterConnection);

                    MessageBox.Show($"Sql server bağlantısı gerçekleştirildi. Veritabanları ve logins bilgileri listelendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bağlantı Hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ListLogins(SqlConnection connection)
        {
            try
            {
                string query = "SELECT name FROM sys.sql_logins";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string loginName = reader["name"].ToString();
                    chklistboxlogin.Items.Add(loginName);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Logins listeleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidIP(string ipAddress)
        {
            return IPAddress.TryParse(ipAddress, out _);
        }

        private bool IsValidHostname(string hostname)
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry(hostname);
                return host.AddressList.Length > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnhostall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklistboxDb.Items.Count; i++)
            {
                chklistboxDb.SetItemChecked(i, true);
            }
        }

        private void btnhostclr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklistboxDb.Items.Count; i++)
            {
                chklistboxDb.SetItemChecked(i, false);
            }
        }

        private void btnloginall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklistboxlogin.Items.Count; i++)
            {
                chklistboxlogin.SetItemChecked(i, true);
            }
        }

        private void btnloginclr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklistboxlogin.Items.Count; i++)
            {
                chklistboxlogin.SetItemChecked(i, false);
            }
        }
        private void btnLinux_Click(object sender, EventArgs e)
        {
            if (chklistboxDb.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir veritabanı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serverName = txthostname.Text.Trim();
            string username = txthostsa.Text.Trim();
            string password = txthostpwd.Text;
            string backupFolderPath = "/var/opt/mssql/data";

            StartBackup(serverName, username, password, backupFolderPath, false);
        }

        private void btnWindows_Click(object sender, EventArgs e)
        {
            if (chklistboxDb.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir veritabanı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string serverName = txthostname.Text.Trim();
                    string username = txthostsa.Text.Trim();
                    string password = txthostpwd.Text;
                    string backupFolderPath = folderDialog.SelectedPath;

                    StartBackup(serverName, username, password, backupFolderPath, true);
                }
            }
        }

        private void StartBackup(string serverName, string username, string password, string backupFolderPath, bool isWindows)
        {
            string masterConnectionString = $"Data Source={serverName};Initial Catalog=master;User ID={username};Password={password}";

            using (SqlConnection masterConnection = new SqlConnection(masterConnectionString))
            {
                try
                {
                    masterConnection.Open();

                    foreach (var selectedDatabase in chklistboxDb.CheckedItems)
                    {
                        string databaseName = selectedDatabase.ToString();
                        string backupFileName = isWindows
                            ? Path.Combine(backupFolderPath, $"{databaseName}.bak")
                            : $"{backupFolderPath}/{databaseName}.bak";

                        string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFileName}' WITH NOFORMAT, NOINIT, NAME = 'Full Backup of {databaseName}', SKIP, NOREWIND, NOUNLOAD, STATS=10;";

                        using (SqlCommand command = new SqlCommand(backupQuery, masterConnection))
                        {
                            command.ExecuteNonQuery();
                        }

                        string displayFileName = isWindows ? Path.GetFileName(backupFileName) : backupFileName;
                        MessageBox.Show($"'{databaseName}' veritabanı başarıyla yedeklendi.\nYedek dosyası: {displayFileName}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kopyalama Hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void YaratLogins(string serverName, string username, string password)
        {
            string connectionString = $"Data Source={serverName};Initial Catalog=master;User ID={username};Password={password}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    List<string> selectedLogins = new List<string>();
                    foreach (var item in chklistboxlogin.CheckedItems)
                    {
                        selectedLogins.Add(item.ToString());
                    }

                    foreach (string loginName in selectedLogins)
                    {
                        try
                        {
                            password = GenerateRandomPassword();
                            string createLoginQuery = $@"
                                USE [master];
                                CREATE LOGIN [{loginName}] 
                                WITH PASSWORD=N'{password}',
                                DEFAULT_DATABASE=[master], 
                                DEFAULT_LANGUAGE=[us_english], 
                                CHECK_EXPIRATION=OFF, 
                                CHECK_POLICY=ON;";

                            using (SqlCommand command = new SqlCommand(createLoginQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show($"'{loginName}' logini başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"'{loginName}' logini oluşturulamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Logins oluşturma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTransferLogin_Click(object sender, EventArgs e)
        {
            RemoteServerName = txtremotename.Text.Trim();
            RemoteUsername = txtremotesa.Text.Trim();
            RemotePassword = txtremotepwd.Text.Trim();

            if (string.IsNullOrWhiteSpace(RemoteServerName) || string.IsNullOrWhiteSpace(RemoteUsername) || string.IsNullOrWhiteSpace(RemotePassword))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = $"Data Source={RemoteServerName};User ID={RemoteUsername};Password={RemotePassword};";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Logins'leri remote sunucuya aktar
                    YaratLogins(RemoteServerName, RemoteUsername, RemotePassword);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bağlantı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private List<string> backupFilePaths = new List<string>(); // Yedek dosyalarının tam yollarını saklamak için genel bir liste
        private List<string> backupFileNames = new List<string>(); // Yedek dosyalarının sadece isimlerini saklamak için genel bir liste

        private void btnSelectRes_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Backup Files|*.bak",
                Title = "Select Backup Files"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = openFileDialog.FileNames;
                foreach (string file in selectedFiles)
                {
                    string fileName = Path.GetFileName(file);

                    // chklistboxRestore içinde aynı isimde dosya var mı kontrol et
                    if (chklistboxRestore.Items.Contains(fileName))
                    {
                        MessageBox.Show($"'{fileName}' adlı yedek dosyası zaten eklenmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        chklistboxRestore.Items.Add(fileName);
                        backupFilePaths.Add(file); // Yedek dosyasının tam yolunu genel listeye ekleyin
                        backupFileNames.Add(fileName); // Dosya adını genel listeye ekleyin
                    }
                }
            }
        }

        private void btnrestoreall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklistboxRestore.Items.Count; i++)
            {
                chklistboxRestore.SetItemChecked(i, true);
            }
        }

        private void btnrestoreclr_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < chklistboxRestore.Items.Count; i++)
            {
                chklistboxRestore.SetItemChecked(i, false);
            }
        }

        private void btnStartRestore_Click(object sender, EventArgs e)
        {
            if (chklistboxRestore.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir yedek dosyası seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serverName = txtremotename.Text.Trim();
            string username = txtremotesa.Text.Trim();
            string password = txtremotepwd.Text;

            if (string.IsNullOrWhiteSpace(serverName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen hedef sunucu bilgilerini girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var selectedBackup in chklistboxRestore.CheckedItems)
            {
                string backupFileName = selectedBackup.ToString(); // Dosya adı

                int index = backupFileNames.IndexOf(backupFileName);
                if (index != -1)
                {
                    string fullBackupPath = backupFilePaths[index]; // Tam dosya yolu 

                    try
                    {
                        // Veritabanının ismini dosya adından alalım
                        string restoreDBname = Path.GetFileNameWithoutExtension(fullBackupPath);

                        string connectionString = $"Data Source={serverName};Initial Catalog=master;User ID={username};Password={password}";

                        // Hedef sunucuda veritabanının var olup olmadığını kontrol et
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string checkDbExistsQuery = $"SELECT database_id FROM sys.databases WHERE Name = '{restoreDBname}'";
                            using (SqlCommand command = new SqlCommand(checkDbExistsQuery, connection))
                            {
                                var result = command.ExecuteScalar();

                                if (result != null)
                                {
                                    // Veritabanı zaten mevcutsa, kullanıcıya sor
                                    DialogResult dialogResult = MessageBox.Show(
                                        $"'{restoreDBname}' veritabanı zaten mevcut. Üzerine yazmak istiyor musunuz?",
                                        "Veritabanı Mevcut",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question
                                    );

                                    if (dialogResult == DialogResult.No)
                                    {
                                        // Kullanıcı iptal etti, bir sonraki yedek dosyasına geç
                                        continue;
                                    }
                                    else if (dialogResult == DialogResult.Yes)
                                    {
                                        // Mevcut veritabanını kapatma ve üzerine yazma işlemi
                                        string setSingleUserQuery = $"ALTER DATABASE [{restoreDBname}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                                        string dropDatabaseQuery = $"DROP DATABASE [{restoreDBname}];";

                                        using (SqlCommand setSingleUserCommand = new SqlCommand(setSingleUserQuery, connection))
                                        {
                                            setSingleUserCommand.ExecuteNonQuery();
                                        }

                                        using (SqlCommand dropDatabaseCommand = new SqlCommand(dropDatabaseQuery, connection))
                                        {
                                            dropDatabaseCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }

                        // SQL Server kurulum yolunu ve instance adını sorgula
                        string sqlQuery = @"
                    DECLARE @SQLDataRoot NVARCHAR(512);
                    EXEC xp_instance_regread
                        N'HKEY_LOCAL_MACHINE',
                        N'Software\Microsoft\MSSQLServer\Setup',
                        N'SQLDataRoot',
                        @SQLDataRoot OUTPUT,
                        N'no_output';
                    SELECT @SQLDataRoot AS SQLDataRoot;
                ";

                        string sqlDataRoot;

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                            {
                                sqlDataRoot = command.ExecuteScalar()?.ToString();
                            }
                        }

                        if (string.IsNullOrWhiteSpace(sqlDataRoot))
                        {
                            MessageBox.Show("SQL Server kurulum dizini alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // MDF ve LDF dosya yollarını dinamik olarak belirle
                        string newMdfPath = $@"{sqlDataRoot}\DATA\{restoreDBname}.mdf";
                        string newLdfPath = $@"{sqlDataRoot}\DATA\{restoreDBname}_log.ldf";

                        // Restore sorgusunu oluştur
                        string restoreQuery = $@"
                    USE [master];
                    RESTORE DATABASE [{restoreDBname}]
                    FROM DISK = N'{fullBackupPath}'
                    WITH 
                        FILE = 1,
                        MOVE N'{restoreDBname}' TO N'{newMdfPath}',
                        MOVE N'{restoreDBname}_log' TO N'{newLdfPath}',
                        NOUNLOAD,
                        STATS = 5;
                ";

                        // SQL sunucusuna bağlan ve geri yükleme sorgusunu çalıştır
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show($"'{restoreDBname}' veritabanı başarıyla geri yüklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Geri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Yedek dosya yolu bulunamadı: {backupFileName}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}