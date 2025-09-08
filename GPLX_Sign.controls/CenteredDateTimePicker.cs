using System.Drawing;
using System.Windows.Forms;

namespace GPLX_Sign.controls;

public class CenteredDateTimePicker : DateTimePicker
{
	public CenteredDateTimePicker()
	{
		SetStyle(ControlStyles.UserPaint, value: true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), base.ClientRectangle, new StringFormat
		{
			Alignment = StringAlignment.Center,
			LineAlignment = StringAlignment.Center
		});
	}
}
