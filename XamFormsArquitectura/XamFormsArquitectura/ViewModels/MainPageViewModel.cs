using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Acr.UserDialogs;
using Xamarin.Forms;
using XamFormsArquitectura.Helpers;
using XamFormsArquitectura.Models;
using XamFormsArquitectura.Services.DialogService;
using XamFormsArquitectura.ViewModels.Base;

namespace XamFormsArquitectura.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<Result> _animeList;

        public ObservableCollection<Result> AnimeList
        {
            get => _animeList;
            set
            {
                _animeList = value; 
                RaisePropertyChanged(() => AnimeList);
            }
        }

        public Result SelectedAnime { get; set; }

        public ICommand QueryCommand { get; set; }
        private IDialogService _dialogService;
        public ICommand ItemTappedCommand { get; set; }

        public MainPageViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            QueryCommand = new Command(async (query) =>
            {
                _dialogService.StartLoading("Cargando");
                var result = await HttpHelper<AnimeData>.ConsultarWSAsync($"https://api.jikan.moe/v3/search/anime?q={query}");
                AnimeList = new ObservableCollection<Result>(result.results);
                _dialogService.StopLoading();
            });

            ItemTappedCommand = new Command(async() =>
            {
                await NavigationService.NavigateToAsync<DetailsPageViewModel>(SelectedAnime);
            });

        }


    }
}
