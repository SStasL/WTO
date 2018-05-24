using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.DataModel;
using Eplan.EplApi.DataModel.EObjects;
using Eplan.EplApi.DataModel.E3D;
using Eplan.EplApi.HEServices;


namespace Wto.EplAddIn.v1
{
    public class EplAddInModule : IEplAddIn
    {
        public bool OnExit()
        {
            return true;
        }

        public bool OnInit()
        {
            return true;
        }

        public bool OnInitGui()
        {
            return true;
        }

        public bool OnRegister(ref bool bLoadOnStart)
        {
            bLoadOnStart = true;
            return true;
        }

        public bool OnUnregister()
        {
            return true;
        }
    }
    class Wto : IEplAction
    {
        public bool Execute(ActionCallingContext oActionCallingContext)
        {

            int count = 0;

            SelectionSet selectionSet = new SelectionSet();     //Выбор выделенных объектов
            StorableObject[] storableObjects = selectionSet.SelectionRecursive;

            foreach (StorableObject so in storableObjects)
            {
                MessageBox.Show(so.GetType().ToString());
            }

            return true;
        }

        public void GetActionProperties(ref ActionProperties actionProperties)
        {
            throw new NotImplementedException();
        }

        public bool OnRegister(ref string Name, ref int Ordinal)
        {
            Name = "Wto";
            Ordinal = 20;
            return true;
        }
    }
}
