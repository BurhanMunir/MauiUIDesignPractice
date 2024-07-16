using System;
using System.Collections.ObjectModel;
using MauiUIDesignPractice.Models;

namespace MauiUIDesignPractice.ViewModels
{
    public class ProfileViewModel
    {
        public ObservableCollection<HomeWork> homeWorks { get; set; }
        public ProfileViewModel()
        {
            homeWorks = new ObservableCollection<HomeWork>()
            {
                new HomeWork { FileName = "English_speakingmeeting.docx" },
                new HomeWork { FileName = "German_writingnotes.docx" },
                new HomeWork { FileName = "German_writingnotes.docx" }
            };
        }
    }
}

