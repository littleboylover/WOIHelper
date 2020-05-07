using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WOIHelper.Data.Models;
using WOIHelper.Services;

namespace WOIHelper
{
    public partial class frmStardusts : Form
    {
        private List<Stardust> _stardusts;
        private readonly StardustService _stardustService = new StardustService();
        private readonly MessageBoxService _mboxService = new MessageBoxService();

        public frmStardusts()
        {
            InitializeComponent();
        }

        private void frmStardusts_Load(object sender, EventArgs e)
        {
            InitStardusts();
        }

        private void InitStardusts()
        {
            _stardusts = _stardustService.GetStardusts();

            cboStardusts.Items.AddRange(_stardusts.Select(s => s.Name).ToArray());
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                _mboxService.ShowErrorMessageBox(
                    "Please make sure to select a stardust to craft and amount is a valid number.");
                return;
            }

            lblRequirements.Text = GetRequirements();
        }

        private string GetRequirements()
        {
            var builder = new StringBuilder();
            var allRequirements = _stardustService.GetRequirements(cboStardusts.Text);

            if (chkGathered.Checked)
            {
                allRequirements = allRequirements.Where(r => r.IsGathered).ToList();
            }

            foreach (var requirement in allRequirements)
            {
                builder.AppendLine($"{requirement.Amount * int.Parse(txtAmt.Text)}x {requirement.Name}");
            }

            return builder.ToString();
        }

        private bool IsValidInput()
        {
            var temp = 0;
            return cboStardusts.SelectedIndex > -1 && int.TryParse(txtAmt.Text, out temp);
        }
    }
}
