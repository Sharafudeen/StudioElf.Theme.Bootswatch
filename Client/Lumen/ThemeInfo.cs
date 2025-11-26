using Oqtane.Models;
using Oqtane.Themes;
using System.Collections.Generic;

namespace StudioElf.Theme.Bootswatch.Lumen
{
    public class ThemeInfo : ITheme
    {
        public Oqtane.Models.Theme Theme => new Oqtane.Models.Theme
        {
            Name = "Bootswatch Lumen",
            Version = "10.5.3.8",
            ThemeSettingsType = "StudioElf.Theme.Bootswatch.ThemeSettings, StudioElf.Theme.Bootswatch.Oqtane",
            ContainerSettingsType = "StudioElf.Theme.Bootswatch.ContainerSettings, StudioElf.Theme.Bootswatch.Oqtane",
            PackageName = "StudioElf.Theme.Bootswatch",
            Resources = new List<Resource>()
            {
                new Stylesheet("https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.3.8/lumen/bootstrap.min.css", "sha512-9hyXgCKp4VYaY6/jPBljOr3fNPphAvyGl4rxBZH2BZ1TLQgMtNgBPbkBQjYOaiV9Ne/Q4IjyC4VbEE2AawWH8w==", "anonymous"),

                new Stylesheet("Themes/AyroUI/assets/css/glightbox.min.css"),
                new Stylesheet("Themes/AyroUI/assets/css/lineicons.css"),
                new Stylesheet("Themes/AyroUI/assets/css/loading-bar.min.css"),
                new Stylesheet("Themes/AyroUI/assets/css/tiny-slider.css"),

                new Stylesheet("Themes/AyroUI/assets/scss/starter.css"),
                new Stylesheet("Themes/AyroUI/assets/scss/tabs-accordions/tabs.css"),

                new Script("Themes/AyroUI/assets/js/count-up.min.js"),
                new Script("Themes/AyroUI/assets/js/glightbox.min.js"),
                new Script("Themes/AyroUI/assets/js/loading-bar.min.js"),
                new Script("Themes/AyroUI/assets/js/tiny-slider.js"),

                new Stylesheet("Themes/StudioElf.Theme.Bootswatch/Theme.css"),
                new Stylesheet($"Themes/StudioElf.Theme.Bootswatch/Lumen.css"),
                new Script("https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.8/js/bootstrap.bundle.min.js", "sha512-HvOjJrdwNpDbkGJIG2ZNqDlVqMo77qbs4Me4cah0HoDrfhrbA+8SBlZn1KrvAQw7cILLPFJvdwIgphzQmMm+Pw==", "anonymous")
            }
        };
    }
}