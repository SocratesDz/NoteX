using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Notex
{
	public partial class NoteListView : ContentPage
	{
		public NoteListView()
		{
			InitializeComponent();
			this.BindingContext = new NoteListViewModel();
		}

		public void AddNote(object sender, EventArgs e)
		{
			
		}
	}
}
