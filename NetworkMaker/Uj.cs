using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMaker
{
    public partial class Uj : Form
    {
        //private bool isListening = false;
        //private Point clickLocation;

        public Uj()
        {
            InitializeComponent();
        }
        private void Uj_Load(object sender, EventArgs e)
        {
            cmbxRsa.SelectedIndex = 1; // 1024
            cmbxTipus.SelectedIndex = 0; //router
        }

        private void cmbxTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control[] controls = tlpInterfeszek.Controls.Cast<Control>()
                    .Where(c => tlpInterfeszek.GetColumn(c) == tlpInterfeszek.ColumnCount - 2 || tlpInterfeszek.GetColumn(c) == tlpInterfeszek.ColumnCount - 1)
                    .ToArray();
            if (cmbxTipus.SelectedIndex == 0) //Router
            {
                pnlDHCP.Enabled = true;
                chbDHCPszolg.Enabled = true;

                tlpVlanok.Enabled = false;
                btnUjVlan.Enabled = false;
                lblVlanKonfiguralas.Enabled = false;
                lblVlanNev.Enabled = false;
                lblVlanSzam.Enabled = false;
                lblVlanAllapot.Enabled = false;

                tlpRouting.Enabled = true;
                btnUjRouting.Enabled = true;
                lblRouterID.Enabled = true;
                lblRouting.Enabled = true;
                lblRoutingMaszk.Enabled = true;
                lblRoutingCim.Enabled = true;
                lblRoutingPassziv.Enabled = true;
                lblRoutingPrioritas.Enabled = true;
                lblRoutingTipus.Enabled = true;
                lblRoutingUgras.Enabled = true;

                foreach (var control in controls)
                {
                    control.Enabled = false;
                }

            }
            else //Switch
            {
                pnlDHCP.Enabled = false;
                chbDHCPszolg.Enabled = false;

                tlpVlanok.Enabled = true;
                btnUjVlan.Enabled = true;
                lblVlanKonfiguralas.Enabled = true;
                lblVlanNev.Enabled = true;
                lblVlanSzam.Enabled = true;
                lblVlanAllapot.Enabled = true;

                tlpRouting.Enabled = false;
                btnUjRouting.Enabled = false;
                lblRouterID.Enabled = false;
                lblRouting.Enabled = false;
                lblRoutingMaszk.Enabled = false;
                lblRoutingCim.Enabled = false;
                lblRoutingPassziv.Enabled = false;
                lblRoutingPrioritas.Enabled = false;
                lblRoutingTipus.Enabled = false;
                lblRoutingUgras.Enabled = false;

                foreach (var control in controls)
                {
                    control.Enabled = true;
                }
            }
            chbStatikus.Enabled = true;
            chbBekapcsolva.Enabled = true;
        }

        private void chbStatikus_CheckedChanged(object sender, EventArgs e)
        {
            if (chbStatikus.Checked)
            {
                txtIP.Enabled = true;
                txtMaszk.Enabled = true;
                txtAtjaro.Enabled = true;
                txtDNS.Enabled = true;
            }
            else
            {
                txtIP.Enabled = false;
                txtMaszk.Enabled = false;
                txtAtjaro.Enabled = false;
                txtDNS.Enabled = false;
            }
        }

        private void chbPrivilegizalt_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPrivilegizalt.Checked)
            {
                txtPrivilegizalt.Enabled = true;
            }
            else
            {
                txtPrivilegizalt.Enabled = false;
            }
        }

        private void chbKonzol_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKonzol.Checked)
            {
                txtKonzol.Enabled = true;
            }
            else
            {
                txtKonzol.Enabled = false;
            }
        }

        private void chbTavoli_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTavoli.Checked)
            {
                pnlTavoliEleres.Enabled = true;
                txtJelszo.Enabled = true;
            }
            else
            {
                pnlTavoliEleres.Enabled = false;
                txtJelszo.Enabled = false;
                txtFelhasznev.Enabled = false;
                cmbxRsa.Enabled = false;
            }
        }

        private void rdbSsh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSsh.Checked)
            {
                txtFelhasznev.Enabled = true;
                cmbxRsa.Enabled = true;
            }
            else
            {
                txtFelhasznev.Enabled = false;
                cmbxRsa.Enabled = false;
            }
        }

        private void rdbTelnet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTelnet.Checked)
            {
                txtFelhasznev.Enabled = false;
                cmbxRsa.Enabled = false;
            }
            else
            {
                txtFelhasznev.Enabled = true;
                cmbxRsa.Enabled = true;
            }
        }

        private void chbDHCPszolg_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDHCPszolg.Checked)
            {
                txtNevDHCP.Enabled = true;
                txtAtjaroDHCP.Enabled = true;
                txtHalozatCimDHCP.Enabled = true;
                txtDnsDHCP.Enabled = true;
                rtbKihagyDHCP.Enabled = true;
                txtMaszkDHCP.Enabled = true;
            }
            else
            {
                txtNevDHCP.Enabled = false;
                txtAtjaroDHCP.Enabled = false;
                txtHalozatCimDHCP.Enabled = false;
                txtDnsDHCP.Enabled = false;
                rtbKihagyDHCP.Enabled = false;
                txtMaszkDHCP.Enabled = false;
            }
        }

        private void btnEszkozHelye_Click(object sender, EventArgs e)
        {
            btnEszkozHelye.Text = "Figyelés aktív...";
            /* timer1.Interval = 100;
             timer1.Tick += Timer1_Tick;
             timer1.Start();*/
        }

        private void btnUjInterfesz_Click(object sender, EventArgs e)
        {
            if (!btnEltavolitInterfesz.Enabled)
            {
                btnEltavolitInterfesz.Enabled = true;
            }

            tlpInterfeszek.SuspendLayout();
            tlpInterfeszek.RowCount = tlpInterfeszek.RowCount + 1;
            tlpInterfeszek.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            bool PortEna = false;
            if (cmbxTipus.SelectedIndex == 1) //Switch
            {
                PortEna = true;
            }
            tlpInterfeszek.Controls.Add(new TextBox() { Text = "", Size = new Size(40, 20) }, 0, tlpInterfeszek.RowCount - 1);
            tlpInterfeszek.Controls.Add(new TextBox() { Text = "", Size = new Size(106, 20) }, 1, tlpInterfeszek.RowCount - 1);
            tlpInterfeszek.Controls.Add(new TextBox() { Text = "", Size = new Size(106, 20) }, 2, tlpInterfeszek.RowCount - 1);
            tlpInterfeszek.Controls.Add(new CheckBox() { Text = "Bekapcsolva", Size = new Size(90, 20) }, 3, tlpInterfeszek.RowCount - 1);
            tlpInterfeszek.Controls.Add(new TextBox() { Text = "", Size = new Size(106, 20) }, 4, tlpInterfeszek.RowCount - 1);
            tlpInterfeszek.Controls.Add(new ComboBox() { Items = { "Trunk", "Access" }, Size = new Size(77, 20), Enabled = PortEna }, 5, tlpInterfeszek.RowCount - 1);
            tlpInterfeszek.Controls.Add(new TextBox() { Text = "", Enabled = PortEna, Size = new Size(93, 20) }, 6, tlpInterfeszek.RowCount - 1);

            tlpInterfeszek.ResumeLayout();
        }

        private void btnEltavolitInterfesz_Click(object sender, EventArgs e)
        {
            tlpInterfeszek.SuspendLayout();

            int controlCount = tlpInterfeszek.Controls.Count;

            for (int i = 1; i <= 7 && controlCount > 0; i++)
            {
                Control control = tlpInterfeszek.Controls[controlCount - 1];
                tlpInterfeszek.Controls.Remove(control);
                control.Dispose();
                controlCount--;
            }

            tlpInterfeszek.RowCount = tlpInterfeszek.RowCount - 1;

            if (tlpInterfeszek.Controls.Count == 0)
            {
                btnEltavolitInterfesz.Enabled = false;
            }

            tlpInterfeszek.ResumeLayout();

        }

        private void btnUjVlan_Click(object sender, EventArgs e)
        {
            if (!btnEltavolitVlan.Enabled)
            {
                btnEltavolitVlan.Enabled = true;
            }
            tlpVlanok.SuspendLayout();

            tlpVlanok.RowCount = tlpVlanok.RowCount + 1;
            tlpVlanok.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpVlanok.Controls.Add(new TextBox() { Text = "", Size = new Size(41, 20) }, 0, tlpVlanok.RowCount - 1);
            tlpVlanok.Controls.Add(new TextBox() { Text = "", Size = new Size(190, 20) }, 1, tlpVlanok.RowCount - 1);
            tlpVlanok.Controls.Add(new CheckBox() { Text = "Bekapcsolva", Size = new Size(90, 20) }, 2, tlpVlanok.RowCount - 1);

            tlpVlanok.ResumeLayout();
        }

        private void btnEltavolitVlan_Click(object sender, EventArgs e)
        {
            tlpVlanok.SuspendLayout();
            int controlCount = tlpVlanok.Controls.Count;

            for (int i = 1; i <= 3 && controlCount > 0; i++)
            {
                Control control = tlpVlanok.Controls[controlCount - 1];
                tlpVlanok.Controls.Remove(control);
                control.Dispose();
                controlCount--;
            }

            if (tlpVlanok.Controls.Count == 0)
            {
                btnEltavolitVlan.Enabled = false;
            }

            tlpVlanok.ResumeLayout();
        }

        private void btnUjRouting_Click(object sender, EventArgs e)
        {
            if (!btnEltavolitRouting.Enabled)
            {
                btnEltavolitRouting.Enabled = true;
            }
            tlpRouting.SuspendLayout();
            tlpRouting.RowCount = tlpRouting.RowCount + 1;
            tlpRouting.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpRouting.Controls.Add(new TextBox() { Text = "", Size = new Size(106, 20) }, 0, tlpRouting.RowCount - 1);
            tlpRouting.Controls.Add(new TextBox() { Text = "", Size = new Size(106, 20) }, 1, tlpRouting.RowCount - 1);
            tlpRouting.Controls.Add(new TextBox() { Text = "", Size = new Size(70, 20) }, 2, tlpRouting.RowCount - 1);
            tlpRouting.Controls.Add(new ComboBox() { Items = { "Static", "RIP", "RIPv2", "OSPF" }, Size = new Size(80, 20), DropDownStyle = ComboBoxStyle.DropDownList, }, 3, tlpRouting.RowCount - 1);
            (tlpRouting.GetControlFromPosition(3, tlpRouting.RowCount - 1) as ComboBox).SelectedIndexChanged += cmbxUjRoutingType_SelectedIndexChanged;
            tlpRouting.Controls.Add(new TextBox() { Text = "", Size = new Size(106, 20) }, 4, tlpRouting.RowCount - 1);
            tlpRouting.Controls.Add(new TextBox() { Text = "", Size = new Size(30, 20) }, 5, tlpRouting.RowCount - 1);

            tlpRouting.ResumeLayout();
        }

        private void btnEltavolitRouting_Click(object sender, EventArgs e)
        {
            tlpRouting.SuspendLayout();
            int controlCount = tlpRouting.Controls.Count;

            for (int i = 1; i <= 6 && controlCount > 0; i++)
            {
                Control control = tlpRouting.Controls[controlCount - 1];
                tlpRouting.Controls.Remove(control);
                control.Dispose();
                controlCount--;
            }

            tlpRouting.RowCount--;

            if (tlpInterfeszek.Controls.Cast<Control>()
                .Count(c => tlpInterfeszek.GetColumn(c) == 4 &&
                (c as ComboBox).SelectedIndex == 3) == 0
                )
            {
                txtRouterID.Enabled = false;
            }

            if (tlpRouting.Controls.Count == 0)
            {
                btnEltavolitRouting.Enabled = false;
            }

            tlpRouting.ResumeLayout();
        }

        private void cmbxUjRoutingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition senderHely = ((sender as ComboBox).Parent as TableLayoutPanel).GetPositionFromControl(sender as Control);

            List<Control> cont = tlpRouting.Controls
                .Cast<Control>()
                .Where(c => 
                    tlpRouting.GetColumn(c) == senderHely.Column &&
                    tlpRouting.GetRow(c) >= senderHely.Row)
                .ToList();

            foreach (ComboBox control in cont)
            {
                if (control.Text == "")
                {
                    control.SelectedIndex = (sender as ComboBox).SelectedIndex;
                }
            }


            if ((sender as ComboBox).SelectedIndex == 0)
            {
                (tlpRouting.GetControlFromPosition(1, senderHely.Row) as TextBox).Enabled = true;
                (tlpRouting.GetControlFromPosition(2, senderHely.Row) as TextBox).Enabled = false;
                (tlpRouting.GetControlFromPosition(4, senderHely.Row) as TextBox).Enabled = true;
                (tlpRouting.GetControlFromPosition(5, senderHely.Row) as TextBox).Enabled = true;
                if (txtRouterID.Enabled)
                {
                    txtRouterID.Enabled = false;
                }
            }
            else if ((sender as ComboBox).SelectedIndex == 3)
            {
                (tlpRouting.GetControlFromPosition(1, senderHely.Row) as TextBox).Enabled = true;
                (tlpRouting.GetControlFromPosition(2, senderHely.Row) as TextBox).Enabled = true;
                (tlpRouting.GetControlFromPosition(4, senderHely.Row) as TextBox).Enabled = true;
                (tlpRouting.GetControlFromPosition(5, senderHely.Row) as TextBox).Enabled = false;
                if (!txtRouterID.Enabled)
                {
                    txtRouterID.Enabled = true;
                }
            }
            else
            {
                (tlpRouting.GetControlFromPosition(1, senderHely.Row) as TextBox).Enabled = false;
                (tlpRouting.GetControlFromPosition(2, senderHely.Row) as TextBox).Enabled = true;
                (tlpRouting.GetControlFromPosition(4, senderHely.Row) as TextBox).Enabled = false;
                (tlpRouting.GetControlFromPosition(5, senderHely.Row) as TextBox).Enabled = false;
                if (txtRouterID.Enabled)
                {
                    txtRouterID.Enabled = false;
                }
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (txtHosztnev.Text == "" ||
                (chbPrivilegizalt.Checked && txtPrivilegizalt.Text == "") ||
                (chbKonzol.Checked && txtKonzol.Text == "") ||
                (chbTavoli.Checked && rdbTelnet.Checked && txtJelszo.Text == "") ||
                (chbTavoli.Checked && rdbSsh.Checked && (txtDomain.Text == "" || txtFelhasznev.Text == "" || txtJelszo.Text == ""))
             )
            {
                return;
            }

            string Parancs = "";

            Parancs += "ena" + "\n" + "conf t" + "\n" + "\n";
            Parancs += $"hostname {txtHosztnev.Text}" + "\n";

            if (txtDomain.Text != "")
            {
                Parancs += $"ip domain-name {txtDomain.Text}" + "\n";
            }

            if (chbJelszoTitkosit.Checked)
            {
                Parancs += "service password-encryption" + "\n";
            }

            if (chbBekapcsolva.Checked || chbStatikus.Checked)
            {
                Parancs += "int vlan1" + "\n";
                if (chbBekapcsolva.Checked)
                {
                    Parancs += "no sh" + "\n";
                }
                if (chbStatikus.Checked)
                {
                    Parancs += $"ip add {txtIP.Text} {txtMaszk.Text}" + "\n";

                    if (txtDNS.Text != "")
                    {
                        Parancs += $"ip name-server {txtDNS.Text}" + "\n";
                    }
                    if (txtAtjaro.Text != "")
                    {
                        Parancs += $"ip default-gateway {txtAtjaro.Text}" + "\n";
                    }
                    else
                    {
                        Parancs += "exit" + "\n";
                    }
                }
            }

            if (tlpVlanok.Controls.Count > 0)
            {
                for (int i = 0; i < tlpVlanok.Controls.Count; i += 3)
                {
                    Parancs += $"int vlan{(tlpVlanok.Controls[i] as TextBox).Text}" + "\n";
                    Parancs += $"name {(tlpVlanok.Controls[i + 1] as TextBox).Text}" + "\n";
                    if ((tlpVlanok.Controls[i + 2] as CheckBox).Checked)
                    {
                        Parancs += "no sh" + "\n";
                    }
                    else
                    {
                        Parancs += "sh" + "\n";
                    }
                }
            }

            if (tlpRouting.Controls.Count > 0)
            {
                if (txtRouterID.Enabled)
                {
                    Parancs += "router ospf 1" + "\n";
                    Parancs += $"router-id {txtRouterID.Text}" + "\n";
                    Parancs += "exit" + "\n";
                }
                for (int i = 0; i < tlpRouting.Controls.Count; i += 6)
                {
                    string RoutingTipus = (tlpRouting.Controls[i + 3] as ComboBox).Text;
                    if (RoutingTipus.Contains("RIP"))
                    {
                        Parancs += "router rip" + "\n";
                        Parancs += "no auto-summary" + "\n";
                        if (RoutingTipus.Contains("2"))
                        {
                            Parancs += "version 2" + "\n";
                        }
                        Parancs += $"network {(tlpRouting.Controls[i] as TextBox).Text}" + "\n"; 
                        if ((tlpRouting.Controls[i + 2] as TextBox).Text != "")
                        {
                            Parancs += $"passive-interface {(tlpRouting.Controls[i + 2] as TextBox).Text.Replace(",", ", ")}" + "\n";
                        }
                        Parancs += "exit" + "\n";
                    }
                    else if (RoutingTipus == "OSPF")
                    {
                        List<int> WildCardMaszk = (tlpRouting.Controls[i + 1] as TextBox).Text.Split('.').ToList().Select(s => 255 - int.Parse(s)).ToList();
                        Parancs += "router ospf 1" + "\n";
                        Parancs += $"network {(tlpRouting.Controls[i] as TextBox).Text} {WildCardMaszk[0]}.{WildCardMaszk[1]}.{WildCardMaszk[2]}.{WildCardMaszk[3]} area 5" + "\n";
                        if ((tlpRouting.Controls[i + 2] as TextBox).Text != "")
                        {
                            Parancs += $"passive-interface {(tlpRouting.Controls[i + 2] as TextBox).Text.Replace(",", ", ")}" + "\n";
                        }
                        Parancs += "exit" + "\n";
                    }
                    else if (RoutingTipus == "Static")
                    {
                        Parancs += $"ip route {(tlpRouting.Controls[i] as TextBox).Text} {(tlpRouting.Controls[i + 1] as TextBox).Text} {(tlpRouting.Controls[i + 4] as TextBox).Text} {(tlpRouting.Controls[i + 5] as TextBox).Text}" + "\n";
                    }
                }
            }

            if (tlpInterfeszek.Controls.Count > 0)
            {
                for (int i = 0; i < tlpInterfeszek.Controls.Count; i += 7)
                {
                    Parancs += $"int {(tlpInterfeszek.Controls[i] as TextBox).Text}" + "\n";
                    if ((tlpInterfeszek.Controls[i + 1] as TextBox).Text != "" &&
                        (tlpInterfeszek.Controls[i + 2] as TextBox).Text != ""
                    )
                    {
                        Parancs += $"ip add {(tlpInterfeszek.Controls[i + 1] as TextBox).Text} {(tlpInterfeszek.Controls[i + 2] as TextBox).Text}" + "\n";
                    }
                    if ((tlpInterfeszek.Controls[i + 3] as CheckBox).Checked)
                    {
                        Parancs += "no sh" + "\n";
                    }
                    else
                    {
                        Parancs += "sh" + "\n";
                    }
                    if ((tlpInterfeszek.Controls[i + 4] as TextBox).Text != "")
                    {
                        Parancs += $"ip helper-address {(tlpInterfeszek.Controls[i + 4] as TextBox).Text}" + "\n";
                    }
                    if ((tlpInterfeszek.Controls[i + 5] as ComboBox).Text != "")
                    {
                        Parancs += $"switchport mode {(tlpInterfeszek.Controls[i + 4] as ComboBox).Text} {(tlpInterfeszek.Controls[i + 5] as TextBox).Text}" + "\n";
                    }
                }
            }

            if (chbPrivilegizalt.Checked)
            {
                Parancs += $"enable password {txtPrivilegizalt.Text}" + "\n";
            }

            if (chbKonzol.Checked)
            {
                Parancs += "line console 0" + "\n";
                Parancs += $"password {txtKonzol.Text}" + "\n";
                Parancs += "login" + "\n";
                Parancs += "exit" + "\n";
            }

            if (chbTavoli.Checked)
            {
                if (rdbSsh.Checked)
                {
                    Parancs += "crypto key gen rsa" + "\n";
                    if (cmbxRsa.Text == "512")
                    {
                        Parancs += "\n";
                    }
                    else
                    {
                        Parancs += $"{cmbxRsa.Text}" + "\n";
                        Parancs += "ip ssh version 2" + "\n";
                    }
                    Parancs += $"username {txtFelhasznev.Text} password {txtJelszo.Text}" + "\n";
                    Parancs += "line vty 0 15" + "\n";
                    Parancs += "transport input ssh" + "\n";
                    Parancs += "login local" + "\n";
                }
                if (rdbTelnet.Checked)
                {
                    Parancs += "line vty 0 15" + "\n";
                    Parancs += $"password {txtJelszo.Text}" + "\n";
                    Parancs += "login" + "\n";
                }
                Parancs += "exit" + "\n";
            }

            if (chbDHCPszolg.Checked)
            {
                Parancs += $"ip dhcp pool {txtNevDHCP.Text}" + "\n";
                Parancs += $"default-router {txtAtjaroDHCP.Text}" + "\n";
                Parancs += $"network {txtHalozatCimDHCP.Text} {txtMaszkDHCP.Text}" + "\n";
                if (txtDnsDHCP.Text != "")
                {
                    Parancs += $"dns-server {txtDnsDHCP.Text}" + "\n";
                }
                Parancs += $"exit" + "\n";
            }

            if (rtbKihagyDHCP.Text != "")
            {
                foreach (var sor in rtbKihagyDHCP.Lines)
                {
                    if (sor.Contains('-'))
                    {
                        Parancs += $"ip dhcp excluded-address {sor.Replace('-', ' ')}" + "\n";
                    }
                    else
                    {
                        Parancs += $"ip dhcp excluded-address {sor}" + "\n";
                    }
                }
            }

            Form1.Parancsok.Add(Parancs);
            Form1.Eszkoznev = txtHosztnev.Text;

            MessageBox.Show("Sikeres volt az új eszköz hozzáadása", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
