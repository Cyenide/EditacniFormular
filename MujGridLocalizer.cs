using DevExpress.XtraGrid.Localization;
using System;
using System.Linq;

namespace EditacniFormular
{
    public class MujGridLocalizer : GridLocalizer
    {
        //slouží k přepsání předdefinovaných textů tlačítek v GridControl searchbaru
        public override string GetLocalizedString(GridStringId id)
        {
            switch (id)
            {
                case GridStringId.FindControlFindButton:
                    return "Hledat";
                case GridStringId.FindControlClearButton:
                    return "Vymazat";
                default:
                    // výchozí nastavení pro výše nespecifikované vlastnosti
                    return base.GetLocalizedString(id);
            }
        }
    }
}
