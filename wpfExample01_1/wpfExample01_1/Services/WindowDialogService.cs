using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfExample01_1.Services
{
    public class WindowDialogService : IDialogService
    {
		
        public string OpenFile(string filter)
		{
			var dialog = new OpenFileDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.FileName;
			}

			return null;
		}

		public void ShowMessageBox(string message)
        {
            throw new NotImplementedException();
        }
    }
}
