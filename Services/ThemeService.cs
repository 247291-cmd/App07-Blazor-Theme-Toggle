namespace App07_ThemeToggle.Services;

public class ThemeService
{
    public string CurrentTheme { get; private set; } = "light";
    public bool IsDarkMode => CurrentTheme == "dark";
    public event Action? OnThemeChanged;

    public void SetTheme(string theme) { CurrentTheme = theme == "dark" ? "dark" : "light"; OnThemeChanged?.Invoke(); }
    public void Toggle() => SetTheme(IsDarkMode ? "light" : "dark");
}
