using System.Windows.Forms;

namespace NetworkMaker
{
    partial class Uj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEszkozHelye = new System.Windows.Forms.Button();
            this.cmbxTipus = new System.Windows.Forms.ComboBox();
            this.lblHosztnev = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtMaszk = new System.Windows.Forms.TextBox();
            this.txtAtjaro = new System.Windows.Forms.TextBox();
            this.lblHalozatiAzonositas = new System.Windows.Forms.Label();
            this.txtHosztnev = new System.Windows.Forms.TextBox();
            this.lblTipus = new System.Windows.Forms.Label();
            this.lblAzonositasIP = new System.Windows.Forms.Label();
            this.lblAzonositasMaszk = new System.Windows.Forms.Label();
            this.lblAzonositasAtjaro = new System.Windows.Forms.Label();
            this.rdbTelnet = new System.Windows.Forms.RadioButton();
            this.rdbSsh = new System.Windows.Forms.RadioButton();
            this.lblHalozatBiztonsag = new System.Windows.Forms.Label();
            this.chbPrivilegizalt = new System.Windows.Forms.CheckBox();
            this.chbKonzol = new System.Windows.Forms.CheckBox();
            this.chbTavoli = new System.Windows.Forms.CheckBox();
            this.lblFelhasznev = new System.Windows.Forms.Label();
            this.lblJelszo = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblRsa = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtFelhasznev = new System.Windows.Forms.TextBox();
            this.txtJelszo = new System.Windows.Forms.TextBox();
            this.cmbxRsa = new System.Windows.Forms.ComboBox();
            this.pnlStatikus = new System.Windows.Forms.Panel();
            this.txtDNS = new System.Windows.Forms.TextBox();
            this.pnlTavoliEleres = new System.Windows.Forms.Panel();
            this.lblAtjaroDhcp = new System.Windows.Forms.Label();
            this.lblHalozatCim = new System.Windows.Forms.Label();
            this.lblDnsDHCP = new System.Windows.Forms.Label();
            this.lblNev = new System.Windows.Forms.Label();
            this.txtNevDHCP = new System.Windows.Forms.TextBox();
            this.txtAtjaroDHCP = new System.Windows.Forms.TextBox();
            this.txtHalozatCimDHCP = new System.Windows.Forms.TextBox();
            this.txtDnsDHCP = new System.Windows.Forms.TextBox();
            this.lblKihagy = new System.Windows.Forms.Label();
            this.rtbKihagyDHCP = new System.Windows.Forms.RichTextBox();
            this.txtPrivilegizalt = new System.Windows.Forms.TextBox();
            this.txtKonzol = new System.Windows.Forms.TextBox();
            this.pnlSsh = new System.Windows.Forms.Panel();
            this.btnMentes = new System.Windows.Forms.Button();
            this.chbDHCPszolg = new System.Windows.Forms.CheckBox();
            this.pnlDHCP = new System.Windows.Forms.Panel();
            this.lblHalozatMaszkDhcp = new System.Windows.Forms.Label();
            this.txtMaszkDHCP = new System.Windows.Forms.TextBox();
            this.chbStatikus = new System.Windows.Forms.CheckBox();
            this.chbBekapcsolva = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHalozatiInterfesz = new System.Windows.Forms.Label();
            this.lblHalozatiIP = new System.Windows.Forms.Label();
            this.lblHalozatiMaszk = new System.Windows.Forms.Label();
            this.lblHalozatiAllapot = new System.Windows.Forms.Label();
            this.btnUjInterfesz = new System.Windows.Forms.Button();
            this.btnEltavolitInterfesz = new System.Windows.Forms.Button();
            this.tlpInterfeszek = new System.Windows.Forms.TableLayoutPanel();
            this.lblHalozatiPort = new System.Windows.Forms.Label();
            this.lblHalozatiVlan = new System.Windows.Forms.Label();
            this.lblHalozatiDhcpHelper = new System.Windows.Forms.Label();
            this.chbJelszoTitkosit = new System.Windows.Forms.CheckBox();
            this.lblAzonositasDNS = new System.Windows.Forms.Label();
            this.tlpVlanok = new System.Windows.Forms.TableLayoutPanel();
            this.lblVlanSzam = new System.Windows.Forms.Label();
            this.lblVlanNev = new System.Windows.Forms.Label();
            this.tlpRouting = new System.Windows.Forms.TableLayoutPanel();
            this.lblRoutingCim = new System.Windows.Forms.Label();
            this.lblRoutingMaszk = new System.Windows.Forms.Label();
            this.lblRoutingPassziv = new System.Windows.Forms.Label();
            this.lblRoutingUgras = new System.Windows.Forms.Label();
            this.lblRoutingTipus = new System.Windows.Forms.Label();
            this.lblHalozatiInterfeszek = new System.Windows.Forms.Label();
            this.lblVlanKonfiguralas = new System.Windows.Forms.Label();
            this.lblRouting = new System.Windows.Forms.Label();
            this.btnEltavolitVlan = new System.Windows.Forms.Button();
            this.btnUjVlan = new System.Windows.Forms.Button();
            this.btnEltavolitRouting = new System.Windows.Forms.Button();
            this.btnUjRouting = new System.Windows.Forms.Button();
            this.lblVlanAllapot = new System.Windows.Forms.Label();
            this.lblRouterID = new System.Windows.Forms.Label();
            this.txtRouterID = new System.Windows.Forms.TextBox();
            this.lblRoutingPrioritas = new System.Windows.Forms.Label();
            this.pnlStatikus.SuspendLayout();
            this.pnlTavoliEleres.SuspendLayout();
            this.pnlSsh.SuspendLayout();
            this.pnlDHCP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEszkozHelye
            // 
            this.btnEszkozHelye.Enabled = false;
            this.btnEszkozHelye.Location = new System.Drawing.Point(15, 79);
            this.btnEszkozHelye.Name = "btnEszkozHelye";
            this.btnEszkozHelye.Size = new System.Drawing.Size(106, 23);
            this.btnEszkozHelye.TabIndex = 2;
            this.btnEszkozHelye.Text = "Eszköz helye";
            this.btnEszkozHelye.UseVisualStyleBackColor = true;
            this.btnEszkozHelye.Visible = false;
            this.btnEszkozHelye.Click += new System.EventHandler(this.btnEszkozHelye_Click);
            // 
            // cmbxTipus
            // 
            this.cmbxTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipus.FormattingEnabled = true;
            this.cmbxTipus.Items.AddRange(new object[] {
            "Router",
            "Switch"});
            this.cmbxTipus.Location = new System.Drawing.Point(53, 45);
            this.cmbxTipus.Name = "cmbxTipus";
            this.cmbxTipus.Size = new System.Drawing.Size(121, 21);
            this.cmbxTipus.TabIndex = 1;
            this.cmbxTipus.SelectedIndexChanged += new System.EventHandler(this.cmbxTipus_SelectedIndexChanged);
            // 
            // lblHosztnev
            // 
            this.lblHosztnev.AutoSize = true;
            this.lblHosztnev.Location = new System.Drawing.Point(12, 17);
            this.lblHosztnev.Name = "lblHosztnev";
            this.lblHosztnev.Size = new System.Drawing.Size(55, 13);
            this.lblHosztnev.TabIndex = 100;
            this.lblHosztnev.Text = "Hosztnév:";
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(3, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(157, 20);
            this.txtIP.TabIndex = 17;
            // 
            // txtMaszk
            // 
            this.txtMaszk.Enabled = false;
            this.txtMaszk.Location = new System.Drawing.Point(3, 32);
            this.txtMaszk.Name = "txtMaszk";
            this.txtMaszk.Size = new System.Drawing.Size(157, 20);
            this.txtMaszk.TabIndex = 18;
            // 
            // txtAtjaro
            // 
            this.txtAtjaro.Enabled = false;
            this.txtAtjaro.Location = new System.Drawing.Point(3, 58);
            this.txtAtjaro.Name = "txtAtjaro";
            this.txtAtjaro.Size = new System.Drawing.Size(157, 20);
            this.txtAtjaro.TabIndex = 19;
            // 
            // lblHalozatiAzonositas
            // 
            this.lblHalozatiAzonositas.AutoSize = true;
            this.lblHalozatiAzonositas.Location = new System.Drawing.Point(67, 120);
            this.lblHalozatiAzonositas.Name = "lblHalozatiAzonositas";
            this.lblHalozatiAzonositas.Size = new System.Drawing.Size(135, 13);
            this.lblHalozatiAzonositas.TabIndex = 100;
            this.lblHalozatiAzonositas.Text = "Hálózati azonosítás (vlan1)";
            // 
            // txtHosztnev
            // 
            this.txtHosztnev.Location = new System.Drawing.Point(70, 14);
            this.txtHosztnev.Name = "txtHosztnev";
            this.txtHosztnev.Size = new System.Drawing.Size(139, 20);
            this.txtHosztnev.TabIndex = 0;
            // 
            // lblTipus
            // 
            this.lblTipus.AutoSize = true;
            this.lblTipus.Location = new System.Drawing.Point(12, 48);
            this.lblTipus.Name = "lblTipus";
            this.lblTipus.Size = new System.Drawing.Size(38, 13);
            this.lblTipus.TabIndex = 100;
            this.lblTipus.Text = "Típus:";
            // 
            // lblAzonositasIP
            // 
            this.lblAzonositasIP.AutoSize = true;
            this.lblAzonositasIP.Location = new System.Drawing.Point(44, 169);
            this.lblAzonositasIP.Name = "lblAzonositasIP";
            this.lblAzonositasIP.Size = new System.Drawing.Size(20, 13);
            this.lblAzonositasIP.TabIndex = 100;
            this.lblAzonositasIP.Text = "IP:";
            // 
            // lblAzonositasMaszk
            // 
            this.lblAzonositasMaszk.AutoSize = true;
            this.lblAzonositasMaszk.Location = new System.Drawing.Point(44, 196);
            this.lblAzonositasMaszk.Name = "lblAzonositasMaszk";
            this.lblAzonositasMaszk.Size = new System.Drawing.Size(41, 13);
            this.lblAzonositasMaszk.TabIndex = 100;
            this.lblAzonositasMaszk.Text = "Maszk:";
            // 
            // lblAzonositasAtjaro
            // 
            this.lblAzonositasAtjaro.AutoSize = true;
            this.lblAzonositasAtjaro.Location = new System.Drawing.Point(44, 222);
            this.lblAzonositasAtjaro.Name = "lblAzonositasAtjaro";
            this.lblAzonositasAtjaro.Size = new System.Drawing.Size(37, 13);
            this.lblAzonositasAtjaro.TabIndex = 100;
            this.lblAzonositasAtjaro.Text = "Átjáró:";
            // 
            // rdbTelnet
            // 
            this.rdbTelnet.AutoSize = true;
            this.rdbTelnet.Checked = true;
            this.rdbTelnet.Location = new System.Drawing.Point(114, 8);
            this.rdbTelnet.Name = "rdbTelnet";
            this.rdbTelnet.Size = new System.Drawing.Size(55, 17);
            this.rdbTelnet.TabIndex = 10;
            this.rdbTelnet.TabStop = true;
            this.rdbTelnet.Text = "Telnet";
            this.rdbTelnet.UseVisualStyleBackColor = true;
            this.rdbTelnet.CheckedChanged += new System.EventHandler(this.rdbTelnet_CheckedChanged);
            // 
            // rdbSsh
            // 
            this.rdbSsh.AutoSize = true;
            this.rdbSsh.Location = new System.Drawing.Point(11, 8);
            this.rdbSsh.Name = "rdbSsh";
            this.rdbSsh.Size = new System.Drawing.Size(47, 17);
            this.rdbSsh.TabIndex = 9;
            this.rdbSsh.TabStop = true;
            this.rdbSsh.Text = "SSH";
            this.rdbSsh.UseVisualStyleBackColor = true;
            this.rdbSsh.CheckedChanged += new System.EventHandler(this.rdbSsh_CheckedChanged);
            // 
            // lblHalozatBiztonsag
            // 
            this.lblHalozatBiztonsag.AutoSize = true;
            this.lblHalozatBiztonsag.Location = new System.Drawing.Point(292, 12);
            this.lblHalozatBiztonsag.Name = "lblHalozatBiztonsag";
            this.lblHalozatBiztonsag.Size = new System.Drawing.Size(94, 13);
            this.lblHalozatBiztonsag.TabIndex = 100;
            this.lblHalozatBiztonsag.Text = "Hálózat biztonság:";
            // 
            // chbPrivilegizalt
            // 
            this.chbPrivilegizalt.AutoSize = true;
            this.chbPrivilegizalt.Location = new System.Drawing.Point(337, 39);
            this.chbPrivilegizalt.Name = "chbPrivilegizalt";
            this.chbPrivilegizalt.Size = new System.Drawing.Size(104, 17);
            this.chbPrivilegizalt.TabIndex = 3;
            this.chbPrivilegizalt.Text = "Privilégizált mód:";
            this.chbPrivilegizalt.UseVisualStyleBackColor = true;
            this.chbPrivilegizalt.CheckedChanged += new System.EventHandler(this.chbPrivilegizalt_CheckedChanged);
            // 
            // chbKonzol
            // 
            this.chbKonzol.AutoSize = true;
            this.chbKonzol.Location = new System.Drawing.Point(337, 62);
            this.chbKonzol.Name = "chbKonzol";
            this.chbKonzol.Size = new System.Drawing.Size(90, 17);
            this.chbKonzol.TabIndex = 5;
            this.chbKonzol.Text = "Konzol vonal:";
            this.chbKonzol.UseVisualStyleBackColor = true;
            this.chbKonzol.CheckedChanged += new System.EventHandler(this.chbKonzol_CheckedChanged);
            // 
            // chbTavoli
            // 
            this.chbTavoli.AutoSize = true;
            this.chbTavoli.Location = new System.Drawing.Point(337, 89);
            this.chbTavoli.Name = "chbTavoli";
            this.chbTavoli.Size = new System.Drawing.Size(89, 17);
            this.chbTavoli.TabIndex = 7;
            this.chbTavoli.Text = "Távoli elérés:";
            this.chbTavoli.UseVisualStyleBackColor = true;
            this.chbTavoli.CheckedChanged += new System.EventHandler(this.chbTavoli_CheckedChanged);
            // 
            // lblFelhasznev
            // 
            this.lblFelhasznev.AutoSize = true;
            this.lblFelhasznev.Location = new System.Drawing.Point(2, 3);
            this.lblFelhasznev.Name = "lblFelhasznev";
            this.lblFelhasznev.Size = new System.Drawing.Size(84, 13);
            this.lblFelhasznev.TabIndex = 100;
            this.lblFelhasznev.Text = "Felhasználónév:";
            // 
            // lblJelszo
            // 
            this.lblJelszo.AutoSize = true;
            this.lblJelszo.Location = new System.Drawing.Point(317, 227);
            this.lblJelszo.Name = "lblJelszo";
            this.lblJelszo.Size = new System.Drawing.Size(39, 13);
            this.lblJelszo.TabIndex = 100;
            this.lblJelszo.Text = "Jelszó:";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(317, 145);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(67, 13);
            this.lblDomain.TabIndex = 100;
            this.lblDomain.Text = "Domain név:";
            // 
            // lblRsa
            // 
            this.lblRsa.AutoSize = true;
            this.lblRsa.Location = new System.Drawing.Point(3, 32);
            this.lblRsa.Name = "lblRsa";
            this.lblRsa.Size = new System.Drawing.Size(96, 13);
            this.lblRsa.TabIndex = 100;
            this.lblRsa.Text = "RSA kulcs hossza:";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(390, 142);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(158, 20);
            this.txtDomain.TabIndex = 11;
            // 
            // txtFelhasznev
            // 
            this.txtFelhasznev.Enabled = false;
            this.txtFelhasznev.Location = new System.Drawing.Point(92, 4);
            this.txtFelhasznev.Name = "txtFelhasznev";
            this.txtFelhasznev.Size = new System.Drawing.Size(142, 20);
            this.txtFelhasznev.TabIndex = 12;
            // 
            // txtJelszo
            // 
            this.txtJelszo.Enabled = false;
            this.txtJelszo.Location = new System.Drawing.Point(361, 224);
            this.txtJelszo.Name = "txtJelszo";
            this.txtJelszo.Size = new System.Drawing.Size(187, 20);
            this.txtJelszo.TabIndex = 14;
            // 
            // cmbxRsa
            // 
            this.cmbxRsa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRsa.Enabled = false;
            this.cmbxRsa.FormattingEnabled = true;
            this.cmbxRsa.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048"});
            this.cmbxRsa.Location = new System.Drawing.Point(105, 29);
            this.cmbxRsa.Name = "cmbxRsa";
            this.cmbxRsa.Size = new System.Drawing.Size(129, 21);
            this.cmbxRsa.TabIndex = 13;
            // 
            // pnlStatikus
            // 
            this.pnlStatikus.Controls.Add(this.txtDNS);
            this.pnlStatikus.Controls.Add(this.txtAtjaro);
            this.pnlStatikus.Controls.Add(this.txtMaszk);
            this.pnlStatikus.Controls.Add(this.txtIP);
            this.pnlStatikus.Location = new System.Drawing.Point(92, 161);
            this.pnlStatikus.Name = "pnlStatikus";
            this.pnlStatikus.Size = new System.Drawing.Size(171, 107);
            this.pnlStatikus.TabIndex = 100;
            // 
            // txtDNS
            // 
            this.txtDNS.Enabled = false;
            this.txtDNS.Location = new System.Drawing.Point(3, 84);
            this.txtDNS.Name = "txtDNS";
            this.txtDNS.Size = new System.Drawing.Size(156, 20);
            this.txtDNS.TabIndex = 20;
            // 
            // pnlTavoliEleres
            // 
            this.pnlTavoliEleres.Controls.Add(this.rdbSsh);
            this.pnlTavoliEleres.Controls.Add(this.rdbTelnet);
            this.pnlTavoliEleres.Enabled = false;
            this.pnlTavoliEleres.Location = new System.Drawing.Point(355, 110);
            this.pnlTavoliEleres.Name = "pnlTavoliEleres";
            this.pnlTavoliEleres.Size = new System.Drawing.Size(182, 28);
            this.pnlTavoliEleres.TabIndex = 100;
            // 
            // lblAtjaroDhcp
            // 
            this.lblAtjaroDhcp.AutoSize = true;
            this.lblAtjaroDhcp.Location = new System.Drawing.Point(7, 37);
            this.lblAtjaroDhcp.Name = "lblAtjaroDhcp";
            this.lblAtjaroDhcp.Size = new System.Drawing.Size(37, 13);
            this.lblAtjaroDhcp.TabIndex = 100;
            this.lblAtjaroDhcp.Text = "Átjáró:";
            // 
            // lblHalozatCim
            // 
            this.lblHalozatCim.AutoSize = true;
            this.lblHalozatCim.Location = new System.Drawing.Point(7, 68);
            this.lblHalozatCim.Name = "lblHalozatCim";
            this.lblHalozatCim.Size = new System.Drawing.Size(67, 13);
            this.lblHalozatCim.TabIndex = 100;
            this.lblHalozatCim.Text = "Hálózat cím:";
            // 
            // lblDnsDHCP
            // 
            this.lblDnsDHCP.AutoSize = true;
            this.lblDnsDHCP.Location = new System.Drawing.Point(4, 119);
            this.lblDnsDHCP.Name = "lblDnsDHCP";
            this.lblDnsDHCP.Size = new System.Drawing.Size(33, 13);
            this.lblDnsDHCP.TabIndex = 100;
            this.lblDnsDHCP.Text = "DNS:";
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(7, 5);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(30, 13);
            this.lblNev.TabIndex = 100;
            this.lblNev.Text = "Név:";
            // 
            // txtNevDHCP
            // 
            this.txtNevDHCP.Enabled = false;
            this.txtNevDHCP.Location = new System.Drawing.Point(43, 2);
            this.txtNevDHCP.Name = "txtNevDHCP";
            this.txtNevDHCP.Size = new System.Drawing.Size(193, 20);
            this.txtNevDHCP.TabIndex = 22;
            // 
            // txtAtjaroDHCP
            // 
            this.txtAtjaroDHCP.Enabled = false;
            this.txtAtjaroDHCP.Location = new System.Drawing.Point(50, 34);
            this.txtAtjaroDHCP.Name = "txtAtjaroDHCP";
            this.txtAtjaroDHCP.Size = new System.Drawing.Size(186, 20);
            this.txtAtjaroDHCP.TabIndex = 23;
            // 
            // txtHalozatCimDHCP
            // 
            this.txtHalozatCimDHCP.Enabled = false;
            this.txtHalozatCimDHCP.Location = new System.Drawing.Point(80, 65);
            this.txtHalozatCimDHCP.Name = "txtHalozatCimDHCP";
            this.txtHalozatCimDHCP.Size = new System.Drawing.Size(156, 20);
            this.txtHalozatCimDHCP.TabIndex = 24;
            // 
            // txtDnsDHCP
            // 
            this.txtDnsDHCP.Enabled = false;
            this.txtDnsDHCP.Location = new System.Drawing.Point(46, 116);
            this.txtDnsDHCP.Name = "txtDnsDHCP";
            this.txtDnsDHCP.Size = new System.Drawing.Size(190, 20);
            this.txtDnsDHCP.TabIndex = 26;
            // 
            // lblKihagy
            // 
            this.lblKihagy.AutoSize = true;
            this.lblKihagy.Location = new System.Drawing.Point(277, 2);
            this.lblKihagy.Name = "lblKihagy";
            this.lblKihagy.Size = new System.Drawing.Size(117, 13);
            this.lblKihagy.TabIndex = 100;
            this.lblKihagy.Text = "Kihagyni kívánt címek:";
            // 
            // rtbKihagyDHCP
            // 
            this.rtbKihagyDHCP.Enabled = false;
            this.rtbKihagyDHCP.Location = new System.Drawing.Point(256, 18);
            this.rtbKihagyDHCP.Name = "rtbKihagyDHCP";
            this.rtbKihagyDHCP.Size = new System.Drawing.Size(242, 114);
            this.rtbKihagyDHCP.TabIndex = 27;
            this.rtbKihagyDHCP.Text = "";
            // 
            // txtPrivilegizalt
            // 
            this.txtPrivilegizalt.Enabled = false;
            this.txtPrivilegizalt.Location = new System.Drawing.Point(447, 37);
            this.txtPrivilegizalt.Name = "txtPrivilegizalt";
            this.txtPrivilegizalt.Size = new System.Drawing.Size(130, 20);
            this.txtPrivilegizalt.TabIndex = 4;
            // 
            // txtKonzol
            // 
            this.txtKonzol.Enabled = false;
            this.txtKonzol.Location = new System.Drawing.Point(432, 62);
            this.txtKonzol.Name = "txtKonzol";
            this.txtKonzol.Size = new System.Drawing.Size(145, 20);
            this.txtKonzol.TabIndex = 6;
            // 
            // pnlSsh
            // 
            this.pnlSsh.Controls.Add(this.cmbxRsa);
            this.pnlSsh.Controls.Add(this.txtFelhasznev);
            this.pnlSsh.Controls.Add(this.lblRsa);
            this.pnlSsh.Controls.Add(this.lblFelhasznev);
            this.pnlSsh.Location = new System.Drawing.Point(314, 168);
            this.pnlSsh.Name = "pnlSsh";
            this.pnlSsh.Size = new System.Drawing.Size(242, 51);
            this.pnlSsh.TabIndex = 49;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(1151, 585);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 34;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // chbDHCPszolg
            // 
            this.chbDHCPszolg.AutoSize = true;
            this.chbDHCPszolg.Enabled = false;
            this.chbDHCPszolg.Location = new System.Drawing.Point(231, 284);
            this.chbDHCPszolg.Name = "chbDHCPszolg";
            this.chbDHCPszolg.Size = new System.Drawing.Size(114, 17);
            this.chbDHCPszolg.TabIndex = 21;
            this.chbDHCPszolg.Text = "DHCP szolgáltatás";
            this.chbDHCPszolg.UseVisualStyleBackColor = true;
            this.chbDHCPszolg.CheckedChanged += new System.EventHandler(this.chbDHCPszolg_CheckedChanged);
            // 
            // pnlDHCP
            // 
            this.pnlDHCP.Controls.Add(this.lblHalozatMaszkDhcp);
            this.pnlDHCP.Controls.Add(this.txtMaszkDHCP);
            this.pnlDHCP.Controls.Add(this.rtbKihagyDHCP);
            this.pnlDHCP.Controls.Add(this.lblKihagy);
            this.pnlDHCP.Controls.Add(this.txtDnsDHCP);
            this.pnlDHCP.Controls.Add(this.txtHalozatCimDHCP);
            this.pnlDHCP.Controls.Add(this.txtAtjaroDHCP);
            this.pnlDHCP.Controls.Add(this.txtNevDHCP);
            this.pnlDHCP.Controls.Add(this.lblNev);
            this.pnlDHCP.Controls.Add(this.lblDnsDHCP);
            this.pnlDHCP.Controls.Add(this.lblHalozatCim);
            this.pnlDHCP.Controls.Add(this.lblAtjaroDhcp);
            this.pnlDHCP.Location = new System.Drawing.Point(27, 307);
            this.pnlDHCP.Name = "pnlDHCP";
            this.pnlDHCP.Size = new System.Drawing.Size(510, 142);
            this.pnlDHCP.TabIndex = 100;
            // 
            // lblHalozatMaszkDhcp
            // 
            this.lblHalozatMaszkDhcp.AutoSize = true;
            this.lblHalozatMaszkDhcp.Location = new System.Drawing.Point(7, 94);
            this.lblHalozatMaszkDhcp.Name = "lblHalozatMaszkDhcp";
            this.lblHalozatMaszkDhcp.Size = new System.Drawing.Size(79, 13);
            this.lblHalozatMaszkDhcp.TabIndex = 47;
            this.lblHalozatMaszkDhcp.Text = "Hálózat maszk:";
            // 
            // txtMaszkDHCP
            // 
            this.txtMaszkDHCP.Enabled = false;
            this.txtMaszkDHCP.Location = new System.Drawing.Point(89, 91);
            this.txtMaszkDHCP.Name = "txtMaszkDHCP";
            this.txtMaszkDHCP.Size = new System.Drawing.Size(147, 20);
            this.txtMaszkDHCP.TabIndex = 25;
            // 
            // chbStatikus
            // 
            this.chbStatikus.AutoSize = true;
            this.chbStatikus.Enabled = false;
            this.chbStatikus.Location = new System.Drawing.Point(27, 138);
            this.chbStatikus.Name = "chbStatikus";
            this.chbStatikus.Size = new System.Drawing.Size(64, 17);
            this.chbStatikus.TabIndex = 15;
            this.chbStatikus.Text = "Statikus";
            this.chbStatikus.UseVisualStyleBackColor = true;
            this.chbStatikus.CheckedChanged += new System.EventHandler(this.chbStatikus_CheckedChanged);
            // 
            // chbBekapcsolva
            // 
            this.chbBekapcsolva.AutoSize = true;
            this.chbBekapcsolva.Enabled = false;
            this.chbBekapcsolva.Location = new System.Drawing.Point(163, 138);
            this.chbBekapcsolva.Name = "chbBekapcsolva";
            this.chbBekapcsolva.Size = new System.Drawing.Size(88, 17);
            this.chbBekapcsolva.TabIndex = 16;
            this.chbBekapcsolva.Text = "Bekapcsolva";
            this.chbBekapcsolva.UseVisualStyleBackColor = true;
            // 
            // lblHalozatiInterfesz
            // 
            this.lblHalozatiInterfesz.AutoSize = true;
            this.lblHalozatiInterfesz.Location = new System.Drawing.Point(597, 28);
            this.lblHalozatiInterfesz.Name = "lblHalozatiInterfesz";
            this.lblHalozatiInterfesz.Size = new System.Drawing.Size(47, 13);
            this.lblHalozatiInterfesz.TabIndex = 100;
            this.lblHalozatiInterfesz.Text = "Interfész";
            // 
            // lblHalozatiIP
            // 
            this.lblHalozatiIP.AutoSize = true;
            this.lblHalozatiIP.Location = new System.Drawing.Point(670, 29);
            this.lblHalozatiIP.Name = "lblHalozatiIP";
            this.lblHalozatiIP.Size = new System.Drawing.Size(35, 13);
            this.lblHalozatiIP.TabIndex = 100;
            this.lblHalozatiIP.Text = "IPcím";
            // 
            // lblHalozatiMaszk
            // 
            this.lblHalozatiMaszk.AutoSize = true;
            this.lblHalozatiMaszk.Location = new System.Drawing.Point(766, 30);
            this.lblHalozatiMaszk.Name = "lblHalozatiMaszk";
            this.lblHalozatiMaszk.Size = new System.Drawing.Size(85, 13);
            this.lblHalozatiMaszk.TabIndex = 100;
            this.lblHalozatiMaszk.Text = "Alhálózati maszk";
            // 
            // lblHalozatiAllapot
            // 
            this.lblHalozatiAllapot.AutoSize = true;
            this.lblHalozatiAllapot.Location = new System.Drawing.Point(879, 30);
            this.lblHalozatiAllapot.Name = "lblHalozatiAllapot";
            this.lblHalozatiAllapot.Size = new System.Drawing.Size(39, 13);
            this.lblHalozatiAllapot.TabIndex = 100;
            this.lblHalozatiAllapot.Text = "Állapot";
            // 
            // btnUjInterfesz
            // 
            this.btnUjInterfesz.Location = new System.Drawing.Point(1113, 4);
            this.btnUjInterfesz.Name = "btnUjInterfesz";
            this.btnUjInterfesz.Size = new System.Drawing.Size(30, 23);
            this.btnUjInterfesz.TabIndex = 28;
            this.btnUjInterfesz.Text = "+";
            this.btnUjInterfesz.UseVisualStyleBackColor = true;
            this.btnUjInterfesz.Click += new System.EventHandler(this.btnUjInterfesz_Click);
            // 
            // btnEltavolitInterfesz
            // 
            this.btnEltavolitInterfesz.Enabled = false;
            this.btnEltavolitInterfesz.Location = new System.Drawing.Point(1087, 4);
            this.btnEltavolitInterfesz.Name = "btnEltavolitInterfesz";
            this.btnEltavolitInterfesz.Size = new System.Drawing.Size(27, 23);
            this.btnEltavolitInterfesz.TabIndex = 29;
            this.btnEltavolitInterfesz.Text = "-";
            this.btnEltavolitInterfesz.UseVisualStyleBackColor = true;
            this.btnEltavolitInterfesz.Click += new System.EventHandler(this.btnEltavolitInterfesz_Click);
            // 
            // tlpInterfeszek
            // 
            this.tlpInterfeszek.AutoScroll = true;
            this.tlpInterfeszek.ColumnCount = 7;
            this.tlpInterfeszek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpInterfeszek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpInterfeszek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpInterfeszek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlpInterfeszek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpInterfeszek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpInterfeszek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tlpInterfeszek.Location = new System.Drawing.Point(600, 48);
            this.tlpInterfeszek.Name = "tlpInterfeszek";
            this.tlpInterfeszek.RowCount = 1;
            this.tlpInterfeszek.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInterfeszek.Size = new System.Drawing.Size(650, 401);
            this.tlpInterfeszek.TabIndex = 100;
            // 
            // lblHalozatiPort
            // 
            this.lblHalozatiPort.AutoSize = true;
            this.lblHalozatiPort.Location = new System.Drawing.Point(1065, 30);
            this.lblHalozatiPort.Name = "lblHalozatiPort";
            this.lblHalozatiPort.Size = new System.Drawing.Size(49, 13);
            this.lblHalozatiPort.TabIndex = 100;
            this.lblHalozatiPort.Text = "Port mód";
            // 
            // lblHalozatiVlan
            // 
            this.lblHalozatiVlan.AutoSize = true;
            this.lblHalozatiVlan.Location = new System.Drawing.Point(1129, 29);
            this.lblHalozatiVlan.Name = "lblHalozatiVlan";
            this.lblHalozatiVlan.Size = new System.Drawing.Size(97, 13);
            this.lblHalozatiVlan.TabIndex = 100;
            this.lblHalozatiVlan.Text = "Engedélyezett vlan";
            // 
            // lblHalozatiDhcpHelper
            // 
            this.lblHalozatiDhcpHelper.AutoSize = true;
            this.lblHalozatiDhcpHelper.Location = new System.Drawing.Point(968, 30);
            this.lblHalozatiDhcpHelper.Name = "lblHalozatiDhcpHelper";
            this.lblHalozatiDhcpHelper.Size = new System.Drawing.Size(80, 13);
            this.lblHalozatiDhcpHelper.TabIndex = 100;
            this.lblHalozatiDhcpHelper.Text = "DHCP helper ip";
            // 
            // chbJelszoTitkosit
            // 
            this.chbJelszoTitkosit.AutoSize = true;
            this.chbJelszoTitkosit.Location = new System.Drawing.Point(447, 88);
            this.chbJelszoTitkosit.Name = "chbJelszoTitkosit";
            this.chbJelszoTitkosit.Size = new System.Drawing.Size(125, 17);
            this.chbJelszoTitkosit.TabIndex = 8;
            this.chbJelszoTitkosit.Text = "Jelszavak titkosítása";
            this.chbJelszoTitkosit.UseVisualStyleBackColor = true;
            // 
            // lblAzonositasDNS
            // 
            this.lblAzonositasDNS.AutoSize = true;
            this.lblAzonositasDNS.Location = new System.Drawing.Point(44, 248);
            this.lblAzonositasDNS.Name = "lblAzonositasDNS";
            this.lblAzonositasDNS.Size = new System.Drawing.Size(33, 13);
            this.lblAzonositasDNS.TabIndex = 100;
            this.lblAzonositasDNS.Text = "DNS:";
            // 
            // tlpVlanok
            // 
            this.tlpVlanok.AutoScroll = true;
            this.tlpVlanok.ColumnCount = 3;
            this.tlpVlanok.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpVlanok.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tlpVlanok.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpVlanok.Location = new System.Drawing.Point(38, 502);
            this.tlpVlanok.Name = "tlpVlanok";
            this.tlpVlanok.RowCount = 1;
            this.tlpVlanok.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVlanok.Size = new System.Drawing.Size(337, 106);
            this.tlpVlanok.TabIndex = 100;
            // 
            // lblVlanSzam
            // 
            this.lblVlanSzam.AutoSize = true;
            this.lblVlanSzam.Location = new System.Drawing.Point(44, 486);
            this.lblVlanSzam.Name = "lblVlanSzam";
            this.lblVlanSzam.Size = new System.Drawing.Size(33, 13);
            this.lblVlanSzam.TabIndex = 100;
            this.lblVlanSzam.Text = "Szám";
            // 
            // lblVlanNev
            // 
            this.lblVlanNev.AutoSize = true;
            this.lblVlanNev.Location = new System.Drawing.Point(160, 489);
            this.lblVlanNev.Name = "lblVlanNev";
            this.lblVlanNev.Size = new System.Drawing.Size(27, 13);
            this.lblVlanNev.TabIndex = 100;
            this.lblVlanNev.Text = "Név";
            // 
            // tlpRouting
            // 
            this.tlpRouting.AutoScroll = true;
            this.tlpRouting.ColumnCount = 6;
            this.tlpRouting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpRouting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpRouting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpRouting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpRouting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpRouting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpRouting.Location = new System.Drawing.Point(459, 503);
            this.tlpRouting.Name = "tlpRouting";
            this.tlpRouting.RowCount = 1;
            this.tlpRouting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRouting.Size = new System.Drawing.Size(522, 108);
            this.tlpRouting.TabIndex = 100;
            // 
            // lblRoutingCim
            // 
            this.lblRoutingCim.AutoSize = true;
            this.lblRoutingCim.Location = new System.Drawing.Point(484, 486);
            this.lblRoutingCim.Name = "lblRoutingCim";
            this.lblRoutingCim.Size = new System.Drawing.Size(64, 13);
            this.lblRoutingCim.TabIndex = 100;
            this.lblRoutingCim.Text = "Hálózat cím";
            // 
            // lblRoutingMaszk
            // 
            this.lblRoutingMaszk.AutoSize = true;
            this.lblRoutingMaszk.Location = new System.Drawing.Point(579, 486);
            this.lblRoutingMaszk.Name = "lblRoutingMaszk";
            this.lblRoutingMaszk.Size = new System.Drawing.Size(85, 13);
            this.lblRoutingMaszk.TabIndex = 100;
            this.lblRoutingMaszk.Text = "Alhálózati maszk";
            // 
            // lblRoutingPassziv
            // 
            this.lblRoutingPassziv.AutoSize = true;
            this.lblRoutingPassziv.Location = new System.Drawing.Point(661, 487);
            this.lblRoutingPassziv.Name = "lblRoutingPassziv";
            this.lblRoutingPassziv.Size = new System.Drawing.Size(99, 13);
            this.lblRoutingPassziv.TabIndex = 100;
            this.lblRoutingPassziv.Text = "Passzív interfészek";
            // 
            // lblRoutingUgras
            // 
            this.lblRoutingUgras.AutoSize = true;
            this.lblRoutingUgras.Location = new System.Drawing.Point(831, 486);
            this.lblRoutingUgras.Name = "lblRoutingUgras";
            this.lblRoutingUgras.Size = new System.Drawing.Size(87, 13);
            this.lblRoutingUgras.TabIndex = 100;
            this.lblRoutingUgras.Text = "Következő ugrás";
            // 
            // lblRoutingTipus
            // 
            this.lblRoutingTipus.AutoSize = true;
            this.lblRoutingTipus.Location = new System.Drawing.Point(766, 486);
            this.lblRoutingTipus.Name = "lblRoutingTipus";
            this.lblRoutingTipus.Size = new System.Drawing.Size(35, 13);
            this.lblRoutingTipus.TabIndex = 100;
            this.lblRoutingTipus.Text = "Típus";
            // 
            // lblHalozatiInterfeszek
            // 
            this.lblHalozatiInterfeszek.AutoSize = true;
            this.lblHalozatiInterfeszek.Location = new System.Drawing.Point(843, 9);
            this.lblHalozatiInterfeszek.Name = "lblHalozatiInterfeszek";
            this.lblHalozatiInterfeszek.Size = new System.Drawing.Size(99, 13);
            this.lblHalozatiInterfeszek.TabIndex = 100;
            this.lblHalozatiInterfeszek.Text = "Hálózati interfészek";
            // 
            // lblVlanKonfiguralas
            // 
            this.lblVlanKonfiguralas.AutoSize = true;
            this.lblVlanKonfiguralas.Location = new System.Drawing.Point(157, 466);
            this.lblVlanKonfiguralas.Name = "lblVlanKonfiguralas";
            this.lblVlanKonfiguralas.Size = new System.Drawing.Size(106, 13);
            this.lblVlanKonfiguralas.TabIndex = 100;
            this.lblVlanKonfiguralas.Text = "Vlanok konfigurálása";
            // 
            // lblRouting
            // 
            this.lblRouting.AutoSize = true;
            this.lblRouting.Location = new System.Drawing.Point(694, 466);
            this.lblRouting.Name = "lblRouting";
            this.lblRouting.Size = new System.Drawing.Size(44, 13);
            this.lblRouting.TabIndex = 100;
            this.lblRouting.Text = "Routing";
            // 
            // btnEltavolitVlan
            // 
            this.btnEltavolitVlan.Enabled = false;
            this.btnEltavolitVlan.Location = new System.Drawing.Point(396, 560);
            this.btnEltavolitVlan.Name = "btnEltavolitVlan";
            this.btnEltavolitVlan.Size = new System.Drawing.Size(30, 23);
            this.btnEltavolitVlan.TabIndex = 31;
            this.btnEltavolitVlan.Text = "-";
            this.btnEltavolitVlan.UseVisualStyleBackColor = true;
            this.btnEltavolitVlan.Click += new System.EventHandler(this.btnEltavolitVlan_Click);
            // 
            // btnUjVlan
            // 
            this.btnUjVlan.Location = new System.Drawing.Point(396, 514);
            this.btnUjVlan.Name = "btnUjVlan";
            this.btnUjVlan.Size = new System.Drawing.Size(30, 23);
            this.btnUjVlan.TabIndex = 30;
            this.btnUjVlan.Text = "+";
            this.btnUjVlan.UseVisualStyleBackColor = true;
            this.btnUjVlan.Click += new System.EventHandler(this.btnUjVlan_Click);
            // 
            // btnEltavolitRouting
            // 
            this.btnEltavolitRouting.Enabled = false;
            this.btnEltavolitRouting.Location = new System.Drawing.Point(987, 560);
            this.btnEltavolitRouting.Name = "btnEltavolitRouting";
            this.btnEltavolitRouting.Size = new System.Drawing.Size(30, 23);
            this.btnEltavolitRouting.TabIndex = 33;
            this.btnEltavolitRouting.Text = "-";
            this.btnEltavolitRouting.UseVisualStyleBackColor = true;
            this.btnEltavolitRouting.Click += new System.EventHandler(this.btnEltavolitRouting_Click);
            // 
            // btnUjRouting
            // 
            this.btnUjRouting.Location = new System.Drawing.Point(987, 514);
            this.btnUjRouting.Name = "btnUjRouting";
            this.btnUjRouting.Size = new System.Drawing.Size(30, 23);
            this.btnUjRouting.TabIndex = 32;
            this.btnUjRouting.Text = "+";
            this.btnUjRouting.UseVisualStyleBackColor = true;
            this.btnUjRouting.Click += new System.EventHandler(this.btnUjRouting_Click);
            // 
            // lblVlanAllapot
            // 
            this.lblVlanAllapot.AutoSize = true;
            this.lblVlanAllapot.Location = new System.Drawing.Point(292, 486);
            this.lblVlanAllapot.Name = "lblVlanAllapot";
            this.lblVlanAllapot.Size = new System.Drawing.Size(39, 13);
            this.lblVlanAllapot.TabIndex = 101;
            this.lblVlanAllapot.Text = "Állapot";
            // 
            // lblRouterID
            // 
            this.lblRouterID.AutoSize = true;
            this.lblRouterID.Location = new System.Drawing.Point(317, 255);
            this.lblRouterID.Name = "lblRouterID";
            this.lblRouterID.Size = new System.Drawing.Size(56, 13);
            this.lblRouterID.TabIndex = 102;
            this.lblRouterID.Text = "Router ID:";
            // 
            // txtRouterID
            // 
            this.txtRouterID.Enabled = false;
            this.txtRouterID.Location = new System.Drawing.Point(379, 251);
            this.txtRouterID.Name = "txtRouterID";
            this.txtRouterID.Size = new System.Drawing.Size(169, 20);
            this.txtRouterID.TabIndex = 103;
            // 
            // lblRoutingPrioritas
            // 
            this.lblRoutingPrioritas.AutoSize = true;
            this.lblRoutingPrioritas.Location = new System.Drawing.Point(924, 487);
            this.lblRoutingPrioritas.Name = "lblRoutingPrioritas";
            this.lblRoutingPrioritas.Size = new System.Drawing.Size(44, 13);
            this.lblRoutingPrioritas.TabIndex = 104;
            this.lblRoutingPrioritas.Text = "Prioritás";
            // 
            // Uj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 624);
            this.Controls.Add(this.lblRoutingPrioritas);
            this.Controls.Add(this.txtRouterID);
            this.Controls.Add(this.lblRouterID);
            this.Controls.Add(this.lblVlanAllapot);
            this.Controls.Add(this.btnEltavolitRouting);
            this.Controls.Add(this.btnUjRouting);
            this.Controls.Add(this.btnEltavolitVlan);
            this.Controls.Add(this.btnUjVlan);
            this.Controls.Add(this.lblRouting);
            this.Controls.Add(this.lblVlanKonfiguralas);
            this.Controls.Add(this.lblHalozatiInterfeszek);
            this.Controls.Add(this.lblRoutingTipus);
            this.Controls.Add(this.lblRoutingUgras);
            this.Controls.Add(this.lblRoutingPassziv);
            this.Controls.Add(this.lblRoutingMaszk);
            this.Controls.Add(this.lblRoutingCim);
            this.Controls.Add(this.tlpRouting);
            this.Controls.Add(this.lblVlanNev);
            this.Controls.Add(this.lblVlanSzam);
            this.Controls.Add(this.tlpVlanok);
            this.Controls.Add(this.lblAzonositasDNS);
            this.Controls.Add(this.chbJelszoTitkosit);
            this.Controls.Add(this.lblHalozatiDhcpHelper);
            this.Controls.Add(this.lblHalozatiVlan);
            this.Controls.Add(this.lblHalozatiPort);
            this.Controls.Add(this.tlpInterfeszek);
            this.Controls.Add(this.btnEltavolitInterfesz);
            this.Controls.Add(this.btnUjInterfesz);
            this.Controls.Add(this.lblHalozatiAllapot);
            this.Controls.Add(this.lblHalozatiMaszk);
            this.Controls.Add(this.lblHalozatiIP);
            this.Controls.Add(this.lblHalozatiInterfesz);
            this.Controls.Add(this.chbBekapcsolva);
            this.Controls.Add(this.lblAzonositasAtjaro);
            this.Controls.Add(this.chbStatikus);
            this.Controls.Add(this.lblAzonositasMaszk);
            this.Controls.Add(this.lblAzonositasIP);
            this.Controls.Add(this.pnlDHCP);
            this.Controls.Add(this.chbDHCPszolg);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.pnlSsh);
            this.Controls.Add(this.txtKonzol);
            this.Controls.Add(this.txtPrivilegizalt);
            this.Controls.Add(this.pnlTavoliEleres);
            this.Controls.Add(this.pnlStatikus);
            this.Controls.Add(this.txtJelszo);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblJelszo);
            this.Controls.Add(this.chbTavoli);
            this.Controls.Add(this.chbKonzol);
            this.Controls.Add(this.chbPrivilegizalt);
            this.Controls.Add(this.lblHalozatBiztonsag);
            this.Controls.Add(this.lblTipus);
            this.Controls.Add(this.txtHosztnev);
            this.Controls.Add(this.lblHalozatiAzonositas);
            this.Controls.Add(this.lblHosztnev);
            this.Controls.Add(this.cmbxTipus);
            this.Controls.Add(this.btnEszkozHelye);
            this.Name = "Uj";
            this.Text = "Uj";
            this.Load += new System.EventHandler(this.Uj_Load);
            this.pnlStatikus.ResumeLayout(false);
            this.pnlStatikus.PerformLayout();
            this.pnlTavoliEleres.ResumeLayout(false);
            this.pnlTavoliEleres.PerformLayout();
            this.pnlSsh.ResumeLayout(false);
            this.pnlSsh.PerformLayout();
            this.pnlDHCP.ResumeLayout(false);
            this.pnlDHCP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEszkozHelye;
        private System.Windows.Forms.ComboBox cmbxTipus;
        private System.Windows.Forms.Label lblHosztnev;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtMaszk;
        private System.Windows.Forms.TextBox txtAtjaro;
        private System.Windows.Forms.Label lblHalozatiAzonositas;
        private System.Windows.Forms.TextBox txtHosztnev;
        private System.Windows.Forms.Label lblTipus;
        private System.Windows.Forms.Label lblAzonositasIP;
        private System.Windows.Forms.Label lblAzonositasMaszk;
        private System.Windows.Forms.Label lblAzonositasAtjaro;
        private System.Windows.Forms.RadioButton rdbTelnet;
        private System.Windows.Forms.RadioButton rdbSsh;
        private System.Windows.Forms.Label lblHalozatBiztonsag;
        private System.Windows.Forms.CheckBox chbPrivilegizalt;
        private System.Windows.Forms.CheckBox chbKonzol;
        private System.Windows.Forms.CheckBox chbTavoli;
        private System.Windows.Forms.Label lblFelhasznev;
        private System.Windows.Forms.Label lblJelszo;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblRsa;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtFelhasznev;
        private System.Windows.Forms.TextBox txtJelszo;
        private System.Windows.Forms.ComboBox cmbxRsa;
        private System.Windows.Forms.Panel pnlStatikus;
        private System.Windows.Forms.Panel pnlTavoliEleres;
        private System.Windows.Forms.Label lblAtjaroDhcp;
        private System.Windows.Forms.Label lblHalozatCim;
        private System.Windows.Forms.Label lblDnsDHCP;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.TextBox txtNevDHCP;
        private System.Windows.Forms.TextBox txtAtjaroDHCP;
        private System.Windows.Forms.TextBox txtHalozatCimDHCP;
        private System.Windows.Forms.TextBox txtDnsDHCP;
        private System.Windows.Forms.Label lblKihagy;
        private System.Windows.Forms.RichTextBox rtbKihagyDHCP;
        private System.Windows.Forms.TextBox txtPrivilegizalt;
        private System.Windows.Forms.TextBox txtKonzol;
        private System.Windows.Forms.Panel pnlSsh;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.CheckBox chbDHCPszolg;
        private System.Windows.Forms.Panel pnlDHCP;
        private System.Windows.Forms.CheckBox chbStatikus;
        private System.Windows.Forms.CheckBox chbBekapcsolva;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHalozatMaszkDhcp;
        private System.Windows.Forms.TextBox txtMaszkDHCP;
        private System.Windows.Forms.Label lblHalozatiInterfesz;
        private System.Windows.Forms.Label lblHalozatiIP;
        private System.Windows.Forms.Label lblHalozatiMaszk;
        private System.Windows.Forms.Label lblHalozatiAllapot;
        private System.Windows.Forms.Button btnUjInterfesz;
        private System.Windows.Forms.Button btnEltavolitInterfesz;
        private System.Windows.Forms.TableLayoutPanel tlpInterfeszek;
        private System.Windows.Forms.Label lblHalozatiPort;
        private System.Windows.Forms.Label lblHalozatiVlan;
        private System.Windows.Forms.Label lblHalozatiDhcpHelper;
        private System.Windows.Forms.CheckBox chbJelszoTitkosit;
        private System.Windows.Forms.TextBox txtDNS;
        private System.Windows.Forms.Label lblAzonositasDNS;
        private System.Windows.Forms.TableLayoutPanel tlpVlanok;
        private System.Windows.Forms.Label lblVlanSzam;
        private System.Windows.Forms.Label lblVlanNev;
        private System.Windows.Forms.TableLayoutPanel tlpRouting;
        private System.Windows.Forms.Label lblRoutingCim;
        private System.Windows.Forms.Label lblRoutingMaszk;
        private System.Windows.Forms.Label lblRoutingPassziv;
        private System.Windows.Forms.Label lblRoutingUgras;
        private System.Windows.Forms.Label lblRoutingTipus;
        private System.Windows.Forms.Label lblHalozatiInterfeszek;
        private System.Windows.Forms.Label lblVlanKonfiguralas;
        private System.Windows.Forms.Label lblRouting;
        private System.Windows.Forms.Button btnEltavolitVlan;
        private System.Windows.Forms.Button btnUjVlan;
        private System.Windows.Forms.Button btnEltavolitRouting;
        private System.Windows.Forms.Button btnUjRouting;
        private Label lblVlanAllapot;
        private Label lblRouterID;
        private TextBox txtRouterID;
        private Label lblRoutingPrioritas;
    }
}