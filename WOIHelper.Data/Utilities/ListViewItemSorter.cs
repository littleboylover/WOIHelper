using System.Collections;
using System.Windows.Forms;

namespace WOIHelper.Data.Utilities
{
    public class ListViewItemSorter : IComparer
    {
        private readonly int col;

        public ListViewItemSorter()
        {
            col = 0;
        }

        public ListViewItemSorter(int column)
        {
            col = column;
        }

        public int Compare(object x, object y)
        {
            return string.Compare(((ListViewItem) x).SubItems[col].Text, ((ListViewItem) y).SubItems[col].Text);
        }
    }
}