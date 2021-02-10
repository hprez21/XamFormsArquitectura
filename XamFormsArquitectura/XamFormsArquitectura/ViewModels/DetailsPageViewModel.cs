using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamFormsArquitectura.Models;
using XamFormsArquitectura.ViewModels.Base;

namespace XamFormsArquitectura.ViewModels
{
    public class DetailsPageViewModel : ViewModelBase
    {
        private Result _anime;

        public Result Anime
        {
            get => _anime;
            set
            {
                _anime = value;
                RaisePropertyChanged(() => Anime);
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            Anime = navigationData as Result;
            return base.InitializeAsync(navigationData);
        }
    }


}
