using AasCore.Aas3_0;
using AasxServer;
using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aas = AasCore.Aas3_0;

namespace AasxServerAssetInterfacesDescription
{
    //public class AidSetup
    //{
    //    //public AidAllInterfaceStatus _allInterfaceStatus = null;
     
    //    AidAllInterfaceStatus _allInterfaceStatus = new AidAllInterfaceStatus();

    //    public bool InitAidInterface()
    //    {
            
    //        List<ISubmodel> submodels;

    //        submodels = Program.env[0].AasEnv.Submodels;
    //        bool AIDSubmodelLoaded = false;
    //        bool AIMCSubmodelLoaded = false;

    //        if(submodels != null)
    //        {
    //            foreach (Aas.Submodel sm in submodels)
    //            {
    //                //check for AID
    //                if (sm.SemanticId?.GetAsExactlyOneKey().Value.ToString() == "https://admin-shell.io/idta/AssetInterfacesDescription/1/0/Submodel")
    //                {
    //                    _allInterfaceStatus.RememberAidSubmodel(sm, adoptUseFlags: true); // load AID submodel
    //                    AIDSubmodelLoaded = true;
    //                }
                        


    //                else if (sm.SemanticId?.GetAsExactlyOneKey().Value.ToString() == "https://admin-shell.io/idta/AssetInterfacesMappingConfiguration/1/0/Submodel")
    //                {
    //                    _allInterfaceStatus.RememberMappingSubmodel(sm); // load AIMC submodel
    //                    AIMCSubmodelLoaded = true;
    //                }

    //                else if (AIDSubmodelLoaded && AIMCSubmodelLoaded) // break if both submodels are loaded.
    //                    break;
                       
    //            }
    //            return true;
    //        }

    //        else
    //            return false;

    //    }
    //    public bool prepareDatapoints()
    //    {
    //        //build up data structures
    //        _allInterfaceStatus.PrepareAidInformation(
    //            _allInterfaceStatus.SmAidDescription,
    //            _allInterfaceStatus.SmAidMapping,
    //            lambdaLookupReference: (rf) => Program.env[0].AasEnv.FindReferableByReference(rf));
    //        _allInterfaceStatus.SetAidInformationForUpdateAndTimeout();
    //        return true;
    //    }

    //    public bool singleUpdate()
    //    {
    //        try
    //        {
    //            if (_allInterfaceStatus?.ContinousRun == true)
    //                return false;

    //            //single shot
    //            _allInterfaceStatus.UpdateValuesSingleShot();

    //        }
              
    //        catch (Exception ex)
    //        {
    //            ;
    //        }

    //        return true;
    //    }
    //    public bool continousRunStart()
    //    {
    //        try
    //        {
    //            if (_allInterfaceStatus != null)
    //            {
    //                //start continous run
    //                _allInterfaceStatus.StartContinousRun();
    //            }
                

    //        }

    //        catch (Exception ex)
    //        {
    //            ;
    //        }

    //        return true;
    //    }

    //    public bool continousRunStop()
    //    {
    //        try
    //        {
    //            if (_allInterfaceStatus != null)
    //            {
    //                //stop continous run
    //                _allInterfaceStatus.StopContinousRun();
    //            }


    //        }

    //        catch (Exception ex)
    //        {
    //            ;
    //        }

    //        return true;
    //    }
    //}
}
