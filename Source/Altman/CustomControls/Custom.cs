﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eto.Forms;

namespace Altman.Desktop.CustomControls
{
	public class Custom
	{

	}

	public class DialogPlus : Dialog
	{
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Language.UpdateLanguage(this);
		}
	}

	public class FormPlus : Form
	{
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Language.UpdateLanguage(this);
		}
	}

	public class PanelPlus : Panel
	{
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Language.UpdateLanguage(this);
		}
	}

}