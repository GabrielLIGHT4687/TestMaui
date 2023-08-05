using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace UltimaVez;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}
