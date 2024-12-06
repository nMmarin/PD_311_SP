using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TaskManager
{
	class ListViewColumnSorter : IComparer
	{
		int columnToSort;
		SortOrder orderOfSort;
		CaseInsensitiveComparer objectCompare;
		public ListViewColumnSorter()
		{
			columnToSort = 0;
			orderOfSort = SortOrder.None;
			objectCompare = new CaseInsensitiveComparer();
		}
		public int Compare(object x, object y)
		{
			ListViewItem listViewX = (ListViewItem)x;
			ListViewItem listViewY = (ListViewItem)y;
			int compareResult;
			if (double.TryParse(listViewX.SubItems[columnToSort].Text, out _))
			{
				compareResult = objectCompare.Compare
					(
					Convert.ToDouble(listViewX.SubItems[columnToSort].Text),
					Convert.ToDouble(listViewY.SubItems[columnToSort].Text)
					);
			}
			else
			{
				compareResult =
					objectCompare.Compare(listViewX.SubItems[columnToSort].Text, listViewY.SubItems[columnToSort].Text); 
			}

			if (orderOfSort == SortOrder.Ascending)
				return compareResult;
			else if (orderOfSort == SortOrder.Descending)
				return -compareResult;
			else
				return compareResult;
		}

		public int SortColumn
		{
			get => columnToSort;
			set => columnToSort = value;
		}
		public SortOrder Order
		{
			get => orderOfSort;
			set => orderOfSort = value;
		}
	}
}
