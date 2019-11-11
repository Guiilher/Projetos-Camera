using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace KeyenceSensor
{
    public partial class IPePortasSensor : UserControl
    {
        private bool enableIPAddress;
        private bool enablePortNo;

        public IPePortasSensor()
        {
            InitializeComponent();
            MaskedTextBoxIpAddressValidating(this, null);
            TextBoxPortNoValidating(this, null);
        }

        public IPAddress IpAddress { private set; get; }
        public ushort PortNo { private set; get; }

        public bool EnableAddress
        {
            get { return enableIPAddress && enablePortNo; }
        }

        private void MaskedTextBoxIpAddressValidating(object sender, CancelEventArgs e)
        {
            const int ipAddressPartsCount = 4;
            MatchCollection match = Regex.Matches(maskedTextBoxIpAddress.Text, "[0-9]+");
            if (match.Count != ipAddressPartsCount)
            {
                SetIPAddressDisable();
                return;
            }
            var ipParts = new byte[ipAddressPartsCount];
            for (int i = 0; i < ipAddressPartsCount; i++)
            {
                bool successParse = byte.TryParse(match[i].ToString(), out ipParts[i]);
                if (successParse) continue;
                SetIPAddressDisable();
                return;
            }
            errorProvider.Clear();
            IpAddress = new IPAddress(ipParts);
            enableIPAddress = true;
            return;
        }

        private void SetIPAddressDisable()
        {
            errorProvider.SetError(maskedTextBoxIpAddress, "Error");
            enableIPAddress = false;
        }

        private void TextBoxPortNoValidating(object sender, CancelEventArgs e)
        {
            ushort portNo;
            enablePortNo = ushort.TryParse(textBoxPortNo.Text, out portNo);
            if (enablePortNo)
            {
                errorProvider.Clear();
                PortNo = portNo;
            }
            else
            {
                errorProvider.SetError(textBoxPortNo, "Error");
            }
        }
    }
}
