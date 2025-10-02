using MauiCollectionControls.Models;

namespace MauiCollectionControls.Pages;

public partial class CarouselViewDemo : ContentPage
{
	public CarouselViewDemo()
	{



        InitializeComponent();
        var items = new List<CollectionItem>
        {
            new CollectionItem { Title = "codingDroplets", Description="welcome"},
            new CollectionItem { Title = "Title 2",Description="Description 2" },
            new CollectionItem { Title = "Title 3",Description="Description 3" },
            new CollectionItem { Title = "Title 4",Description="Description 4" },
            new CollectionItem { Title = "Title 5",Description="Description 5" }


        };
        carouselView.ItemsSource = items;
    }
}