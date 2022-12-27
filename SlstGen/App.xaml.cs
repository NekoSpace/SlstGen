﻿using System;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using NekoSpace.SlstGen.Services;

namespace NekoSpace.SlstGen;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    public App()
    {
        Ioc.Default.ConfigureServices(GetServiceProvider());
    }

    private IServiceProvider GetServiceProvider()
    {
        return new ServiceCollection()
            .AddSingleton<SlstService>()
            .BuildServiceProvider();
    }
}