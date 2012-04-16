using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WinGit.ViewModels
{
    class ViewModelGit
    {
        public ObservableCollection<RepoLocation> RecentlyOpened { get; set; }
        public String RootFolder { get; set; }

        public ViewModelGit()
        {
            RootFolder = String.Format(@"{0}\Git", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            RecentlyOpened = new ObservableCollection<RepoLocation>();
            RecentlyOpened.Add(new RepoLocation() { Name = "RepositoryOne", FolderPath = @"~\repo1" });
            RecentlyOpened.Add(new RepoLocation() { Name = "RepositoryTwo", FolderPath =  @"~\repo2" });
            RecentlyOpened.Add(new RepoLocation() { Name = "RepositoryThree", FolderPath = @"~\repo3" });
            RecentlyOpened.Add(new RepoLocation() { Name = "RepositoryFour", FolderPath = @"~\repo4" });
        }

        public void OpenRepo(string filepath)
        {
        }

        public void CreateRepo(string filepath)
        {
        }

        public void CloneRepo(string location)
        {
        }


    }

    struct RepoLocation
    {
        public string Name {get; set;}
        public string FolderPath {get; set;}

        public void Open()
        {
            
        }
    }
}
