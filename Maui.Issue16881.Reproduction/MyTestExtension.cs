namespace Maui.Issue16881.Reproduction;

public class MyTestExtension : IMarkupExtension<string>
{
    public string ProvideValue(IServiceProvider serviceProvider)
        => (serviceProvider.GetService(typeof(IRootObjectProvider)) is not null).ToString();

    object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        => ProvideValue(serviceProvider);
}