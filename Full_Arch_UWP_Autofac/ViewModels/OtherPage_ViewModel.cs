﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using System.Diagnostics;
using Full_Arch_UWP_Autofac.Helpers;

namespace Full_Arch_UWP_Autofac.ViewModels
{
    public class OtherPage_ViewModel
    {
        public MyICommand<Button> OtherButtonClickCommand { get; private set; }
        public OtherPage_ViewModel()
        {
            OtherButtonClickCommand = new MyICommand<Button>(ButtonClicked);
        }

        public void ButtonClicked(Button button)
        {
            string CurrContent = button.Content.ToString();
            switch (CurrContent)
            {
                case "DoPopup":

                    // get instance of DataAdaptor, which access the Domain PopupWriteString

                    Debug.WriteLine("toets geslaag Popup");
                    break;
            }
        }
    }
}