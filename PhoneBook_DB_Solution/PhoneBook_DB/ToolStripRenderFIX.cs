using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook_DB
{
    public class ToolStripRenderFIX : ToolStripSystemRenderer
    {
        public ToolStripRenderFIX() : base() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (!(e.ToolStrip is ToolStrip))
                base.OnRenderToolStripBorder(e);
        }
    }
}
