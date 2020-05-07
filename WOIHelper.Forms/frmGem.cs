using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WOIHelper.Services;

namespace WOIHelper
{
    public partial class frmGem : Form
    {
        private readonly MessageBoxService _msgBoxService = new MessageBoxService();
        private readonly GemService _gemService = new GemService();
        private readonly ZenService _zenService = new ZenService();

        public frmGem()
        {
            InitializeComponent();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                return;
            }

            var gemRequirement =
                _gemService.CalculateGemRequirement(int.Parse(cboStartingLevel.Text),
                    int.Parse(cboTargetGemLevel.Text));

            var zenRequirement = _zenService.CalculateZenRequirement(gemRequirement, cboStartingLevel.Text);

            PrintRequirements(gemRequirement, zenRequirement);
        }

        private void PrintRequirements(int gemRequirement, int zenRequirement)
        {
            var builder = new StringBuilder();

            builder.AppendLine(
                $"You will need {gemRequirement:N0}x level {cboStartingLevel.Text} gems to make 1x level {cboTargetGemLevel.Text} gem.");
            builder.AppendLine($"Zen cost is approximately {zenRequirement:N0} zen.");

            lblSummary.Text = builder.ToString();
        }

        private bool IsValidInput()
        {
            if (!IsValidStartingGemLevel())
            {
                _msgBoxService.ShowErrorMessageBox("Please select a starting gem level", "Select starting gem level");
                return false;
            }

            if (!IsValidTargetGemLevel())
            {
                _msgBoxService.ShowErrorMessageBox("Please select a target gem level", "Select target gem level");
                return false;
            }

            if (!IsValidCalculation())
            {
                _msgBoxService.ShowErrorMessageBox("Starting gem level must be less than target gem level",
                    "Invalid input");
                return false;
            }

            return true;
        }

        private bool IsValidCalculation()
        {
            return int.Parse(cboStartingLevel.Text) < int.Parse(cboTargetGemLevel.Text);
        }


        private bool IsValidTargetGemLevel()
        {
            return cboTargetGemLevel.SelectedIndex > -1;
        }

        private bool IsValidStartingGemLevel()
        {
            return cboStartingLevel.SelectedIndex > -1;
        }
    }
}