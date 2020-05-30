using System;
using System.Linq;
using System.Windows.Forms;
using WOIHelper.Data.Models;
using WOIHelper.Data.Utilities;
using WOIHelper.Services;

namespace WOIHelper
{
    public partial class frmPacks : Form
    {
        private readonly PackService _packService = new PackService();

        public frmPacks()
        {
            InitializeComponent();
        }

        private void frmPacks_Load(object sender, EventArgs e)
        {
            InitCbos();
        }

        private void InitCbos()
        {
            var packNames = _packService.GetAllPacks().OrderBy(x => x.Name)
                .Select(x => new ComboBoxItem(x.Name, x.Name))
                .ToArray();
            cboPack.Items.AddRange(packNames);

            var itemNames = _packService.GetAllItems().Select(pi => pi.Name).Distinct().OrderBy(x => x)
                .ToArray();
            cboItemName.Items.AddRange(itemNames);

            cboPack.DisplayMember = cboItemName.DisplayMember = "Name";
            cboPack.ValueMember = cboItemName.ValueMember = "Name";
        }

        private void cboPack_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePackDetailView();
        }

        private void UpdatePackDetailView(string packName = null)
        {
            if (cboPack.SelectedIndex < 0)
            {
                return;
            }

            if (!string.IsNullOrWhiteSpace(packName))
            {
                cboPack.Text = packName;
            }

            lvPackDetails.Items.Clear();

            var pack = _packService.GetPackByName(cboPack.Text);

            if (pack == null)
            {
                return;
            }

            var items = pack.Items.Select(p => new ListViewItem
            {
                Text = p.Name,
                SubItems = {$"{p.Chance}%"}
            }).ToArray();

            lvPackDetails.Items.AddRange(items);
        }

        private void lvPackDetails_DoubleClick(object sender, EventArgs e)
        {
            if (lvPackDetails.SelectedItems.Count < 1)
            {
                return;
            }

            ViewItemDetail(lvPackDetails.SelectedItems[0].Text);
        }

        private void ViewItemDetail(string itemName)
        {
            cboItemName.Text = itemName;

            lvItemPacks.Items.Clear();

            var listViewItems = (from pack in _packService.GetAllPacks()
                let item = pack.Items.FirstOrDefault(pi => pi.Name.Equals(itemName))
                where item != null
                select new ListViewItem
                {
                    Text = pack.Name,
                    SubItems = {$"{item.Chance}%"}
                }).ToArray();

            lvItemPacks.Items.AddRange(listViewItems);

            if (lvItemPacks.Items.Count < 1)
            {
                return;
            }

            tabMain.SelectedIndex = 1;
        }

        private void lvItemPacks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvItemPacks.ListViewItemSorter = new ListViewItemSorter(e.Column);
        }

        private void cboItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItemName.SelectedIndex < 0)
            {
                return;
            }

            ViewItemDetail(cboItemName.Text);
        }

        private void lvPackDetails_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvPackDetails.ListViewItemSorter = new ListViewItemSorter(e.Column);
        }

        private void lvItemPacks_DoubleClick(object sender, EventArgs e)
        {
            if (lvItemPacks.SelectedItems.Count < 1)
            {
                return;
            }

            UpdatePackDetailView(lvItemPacks.SelectedItems[0].Text);

            tabMain.SelectedIndex = 0;
        }
    }
}