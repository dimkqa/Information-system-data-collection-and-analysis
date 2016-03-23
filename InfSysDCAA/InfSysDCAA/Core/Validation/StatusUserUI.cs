namespace InfSysDCAA.Core.Validation
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    public static class StatusUserUI
    {
        /// <summary>
        /// Устанавливает значение Enabled Control в зависимости от состояния
        /// </summary>
        /// <param name="formControls"></param>
        public static void StatusFunctionalityPartsOfTheWindow(List<Control> formControls)
        {
            foreach (Control c in formControls)
            {
                if (c.Enabled)
                {
                    c.Enabled = false;
                }
                else
                {
                    c.Enabled = true;
                }
            }
        }
    }
}
