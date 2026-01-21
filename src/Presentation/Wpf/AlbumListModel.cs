using System.Collections.Generic;
using BerryAIGC.Common;
using System.Windows.Input;
using BerryAIGC.Database.Models;
using BerryAIGC.Toolkit.Models;

namespace BerryAIGC.Toolkit;

public class AlbumListModel : BaseNotify
{
    public ICommand Escape { get; set; }

    public bool IsNewAlbum
    {
        get;
        set => SetField(ref field, value);
    }

    public bool IsExistingAlbum
    {
        get;
        set => SetField(ref field, value);
    }

    public Album? SelectedAlbum
    {
        get;
        set => SetField(ref field, value);
    }

    public string AlbumName
    {
        get;
        set => SetField(ref field, value);
    }

    public IEnumerable<Album> Albums
    {
        get;
        set => SetField(ref field, value);
    }

    public bool CanClickOk
    {
        get;
        set => SetField(ref field, value);
    }
}







