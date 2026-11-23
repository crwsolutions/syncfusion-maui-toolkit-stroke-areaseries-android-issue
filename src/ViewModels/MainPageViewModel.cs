using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;

namespace syncfusion_maui_toolkit_stroke_areaseries_android_issue.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    public partial List<LineModel>? IncomeData { get; set; }

    // Constructor to initialize the data
    public MainPageViewModel()
    {
        IncomeData = ToLineModel(yearlyTotalIncomeRaw);
    }

    private static List<LineModel> ToLineModel(int[] data)
    {
        var list = new List<LineModel>();
        var startYear = 2025;
        for (int i = 0; i < data.Length; i++)
        {
            startYear++;
            list.Add(new LineModel(startYear, data[i]));
        }
        return list;
    }

    // --- Yearly Values ---
    int[] yearlyTotalIncomeRaw = [66245, 66245, 80662, 66245, 66244, 66244, 66244, 66245, 66245, 66244, 66245, 66246, 66244, 66245, 66245, 66245, 66245, 66245, 66245, 66245, 66245, 66245, 66245, 66245, 66244, 66245, 66245, 66245, 66245, 66245, 66245, 66245, 39085, 0, 0, 1150, 13660, 13521, 22055, 26124, 25863, 25607, 25357, 25111, 24870, 24634, 24402, 24175, 23953, 23734, 23520];
}

[DebuggerDisplay("{Year} {Amount}")]
public record LineModel(int Year, decimal Amount);
