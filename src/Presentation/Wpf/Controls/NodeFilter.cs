using System.Windows.Input;
using BerryAIGC.Common;
using BerryAIGC.Common.Query;
using BerryAIGC.Toolkit.Models;

namespace BerryAIGC.Toolkit.Controls;

public class NodeFilter : BaseNotify
{
    public bool IsActive
    {
        get;
        set => SetField(ref field, value);
    }

    public NodeOperation Operation
    {
        get;
        set => SetField(ref field, value);
    }

    public string Node
    {
        get;
        set => SetField(ref field, value);
    }

    public string Property
    {
        get;
        set => SetField(ref field, value);
    }


    public NameValue<NodeComparison> SelectedComparison
    {
        get;
        set => SetField(ref field, value);
    }

    public NodeComparison Comparison
    {
        get;
        set => SetField(ref field, value);
    }

    public string Value
    {
        get;
        set => SetField(ref field, value);
    }

    public ICommand RemoveCommand { get; set; }

    public bool IsFirst
    {
        get;
        set => SetField(ref field, value);
    }
}







