using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Notex
{
	public class NoteListViewModel : BaseViewModel
	{
		ObservableCollection<Note> Notes { get; set; }

		public NoteListViewModel()
		{
			Notes = new ObservableCollection<Note>();

			Notes.Add(new Note { Title = "Test", Description = "Some text example", CreationDate = DateTime.Today, ModifiedDate = DateTime.Today });
		}

		public bool Empty()
		{
			return Notes.Count == 0;
		}

		public bool NotEmpty()
		{
			return !Empty();
		}
	}
}
