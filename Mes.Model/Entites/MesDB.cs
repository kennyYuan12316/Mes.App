using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Mes.Model.Entites
{
    public partial class MesDB : DbContext
    {
        public MesDB()
            : base("name=MesDB")
        {
        }

        public virtual DbSet<TB_Sys_DataDictionaryDetail> TB_Sys_DataDictionaryDetail { get; set; }
        public virtual DbSet<TB_Sys_DataDictionaryMaster> TB_Sys_DataDictionaryMaster { get; set; }
        public virtual DbSet<TB_Sys_Department> TB_Sys_Department { get; set; }
        public virtual DbSet<TB_Sys_AccountPerm> TB_Sys_AccountPerm { get; set; }

        public virtual DbSet<TB_Sys_AccountRole> TB_Sys_AccountRole { get; set; }

        public virtual DbSet<TB_Sys_RoleMaster> TB_Sys_RoleMaster { get; set; }
        public virtual DbSet<TB_Sys_RoleDetail> TB_Sys_RoleDetail { get; set; }
        public virtual DbSet<TB_Sys_Account> TB_Sys_Account { get; set; }


        public virtual DbSet<TB_Sys_ModuleDetail> TB_Sys_ModuleDetail { get; set; }

        public virtual DbSet<TB_Sys_ModuleMaster> TB_Sys_ModuleMaster { get; set; }

        public virtual DbSet<User> User { get; set; }

        public virtual DbSet<User_MTM_Department> User_MTM_Department { get; set; }

        public virtual DbSet<TB_Pub_NoticeMessage> TB_Pub_NoticeMessage { get; set; }




        public virtual DbSet<TB_Web_UserOprs> TB_Web_UserOprs { get; set; }
        public virtual DbSet<LableConfigD> LableConfigD { get; set; }
        public virtual DbSet<LableConfigM> LableConfigM { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TB_HR_Dept> TB_HR_Dept { get; set; }
        public virtual DbSet<TB_HR_DeptManas> TB_HR_DeptManas { get; set; }
        public virtual DbSet<TB_HR_Employees> TB_HR_Employees { get; set; }
        public virtual DbSet<TB_Pck_PrtRec> TB_Pck_PrtRec { get; set; }
        public virtual DbSet<TB_Pck_PrtSeqD> TB_Pck_PrtSeqD { get; set; }
        public virtual DbSet<TB_Pck_PrtSeqM> TB_Pck_PrtSeqM { get; set; }
        public virtual DbSet<TB_Pck_PrtSeqRec> TB_Pck_PrtSeqRec { get; set; }
        public virtual DbSet<TB_Prd_AAData> TB_Prd_AAData { get; set; }
        public virtual DbSet<TB_Prd_AccDetail> TB_Prd_AccDetail { get; set; }
        public virtual DbSet<TB_Prd_AccessoriesD> TB_Prd_AccessoriesD { get; set; }
        public virtual DbSet<TB_Prd_AccessoriesD_History> TB_Prd_AccessoriesD_History { get; set; }
        public virtual DbSet<TB_Prd_AccessoriesM> TB_Prd_AccessoriesM { get; set; }
        public virtual DbSet<TB_Prd_AdjWarn> TB_Prd_AdjWarn { get; set; }
        public virtual DbSet<TB_Prd_App_System> TB_Prd_App_System { get; set; }
        public virtual DbSet<TB_Prd_ArrangeInfo> TB_Prd_ArrangeInfo { get; set; }
        public virtual DbSet<TB_Prd_ArrangeStatus> TB_Prd_ArrangeStatus { get; set; }
        public virtual DbSet<TB_Prd_BackAdjMat> TB_Prd_BackAdjMat { get; set; }
        public virtual DbSet<TB_Prd_BackNg> TB_Prd_BackNg { get; set; }
        public virtual DbSet<TB_Prd_BackNumSN> TB_Prd_BackNumSN { get; set; }
        public virtual DbSet<TB_Prd_BackPOD> TB_Prd_BackPOD { get; set; }
        public virtual DbSet<TB_Prd_BackPOM> TB_Prd_BackPOM { get; set; }
        public virtual DbSet<TB_Prd_BackPOSetup> TB_Prd_BackPOSetup { get; set; }
        public virtual DbSet<TB_Prd_BackPOSND> TB_Prd_BackPOSND { get; set; }
        public virtual DbSet<TB_Prd_BakeTimeControl> TB_Prd_BakeTimeControl { get; set; }
        public virtual DbSet<TB_Prd_BatchBackMat> TB_Prd_BatchBackMat { get; set; }
        public virtual DbSet<TB_Prd_BatchDevice> TB_Prd_BatchDevice { get; set; }
        public virtual DbSet<TB_Prd_BatchDownCount> TB_Prd_BatchDownCount { get; set; }
        public virtual DbSet<TB_Prd_BatchGetMat> TB_Prd_BatchGetMat { get; set; }
        public virtual DbSet<TB_Prd_BatchMat> TB_Prd_BatchMat { get; set; }
        public virtual DbSet<TB_Prd_BatchUseMat> TB_Prd_BatchUseMat { get; set; }
        public virtual DbSet<TB_Prd_BatchUseMat2> TB_Prd_BatchUseMat2 { get; set; }
        public virtual DbSet<TB_Prd_BatchUseMatD> TB_Prd_BatchUseMatD { get; set; }
        public virtual DbSet<TB_Prd_BindBatchFPC> TB_Prd_BindBatchFPC { get; set; }
        public virtual DbSet<TB_Prd_BindBatchFPCSN> TB_Prd_BindBatchFPCSN { get; set; }
        public virtual DbSet<TB_Prd_BreakPackLog> TB_Prd_BreakPackLog { get; set; }
        public virtual DbSet<TB_Prd_ChangeLog> TB_Prd_ChangeLog { get; set; }
        public virtual DbSet<TB_Prd_COBOutNum> TB_Prd_COBOutNum { get; set; }
        public virtual DbSet<TB_Prd_CopyData> TB_Prd_CopyData { get; set; }
        public virtual DbSet<TB_Prd_CopyPower> TB_Prd_CopyPower { get; set; }
        public virtual DbSet<TB_Prd_CredentialPrinting> TB_Prd_CredentialPrinting { get; set; }
        public virtual DbSet<TB_Prd_DateChar> TB_Prd_DateChar { get; set; }
        public virtual DbSet<TB_Prd_DayPlan> TB_Prd_DayPlan { get; set; }
        public virtual DbSet<TB_Prd_DayPlanD> TB_Prd_DayPlanD { get; set; }
        public virtual DbSet<TB_Prd_DeviceTranInfo> TB_Prd_DeviceTranInfo { get; set; }
        public virtual DbSet<TB_Prd_DeviceTranNGInfo> TB_Prd_DeviceTranNGInfo { get; set; }
        public virtual DbSet<TB_Prd_EolYeildRate> TB_Prd_EolYeildRate { get; set; }
        public virtual DbSet<TB_Prd_FinshChks> TB_Prd_FinshChks { get; set; }
        public virtual DbSet<TB_Prd_FPCBindMat> TB_Prd_FPCBindMat { get; set; }
        public virtual DbSet<TB_Prd_GetAdjMS> TB_Prd_GetAdjMS { get; set; }
        public virtual DbSet<TB_Prd_HaiWeiWeekData> TB_Prd_HaiWeiWeekData { get; set; }
        public virtual DbSet<TB_Prd_IncomingMatScrap> TB_Prd_IncomingMatScrap { get; set; }
        public virtual DbSet<TB_Prd_InputOverWarehousingLog> TB_Prd_InputOverWarehousingLog { get; set; }
        public virtual DbSet<TB_Prd_LaserEngravingPoDownNumber> TB_Prd_LaserEngravingPoDownNumber { get; set; }
        public virtual DbSet<TB_Prd_LaserEngravingPrintSN> TB_Prd_LaserEngravingPrintSN { get; set; }
        public virtual DbSet<TB_Prd_LaserEngravingRecordSN> TB_Prd_LaserEngravingRecordSN { get; set; }
        public virtual DbSet<TB_Prd_LockSNOrSensorID> TB_Prd_LockSNOrSensorID { get; set; }
        public virtual DbSet<TB_Prd_LockStatus> TB_Prd_LockStatus { get; set; }
        public virtual DbSet<TB_Prd_MachineReport> TB_Prd_MachineReport { get; set; }
        public virtual DbSet<TB_Prd_MachineUPHReport> TB_Prd_MachineUPHReport { get; set; }
        public virtual DbSet<TB_Prd_MatClose> TB_Prd_MatClose { get; set; }
        public virtual DbSet<TB_Prd_MatKeepRight> TB_Prd_MatKeepRight { get; set; }
        public virtual DbSet<TB_Prd_MatMouting> TB_Prd_MatMouting { get; set; }
        public virtual DbSet<TB_Prd_MESPOEX> TB_Prd_MESPOEX { get; set; }
        public virtual DbSet<TB_Prd_MoveD> TB_Prd_MoveD { get; set; }
        public virtual DbSet<TB_Prd_MoveM> TB_Prd_MoveM { get; set; }
        public virtual DbSet<TB_Prd_NGSplitDetial> TB_Prd_NGSplitDetial { get; set; }
        public virtual DbSet<TB_Prd_NGSplitMain> TB_Prd_NGSplitMain { get; set; }
        public virtual DbSet<TB_Prd_NGSplitOutD> TB_Prd_NGSplitOutD { get; set; }
        public virtual DbSet<TB_Prd_NGSplitOutM> TB_Prd_NGSplitOutM { get; set; }
        public virtual DbSet<TB_Prd_OldMatBarcodeBindNewMatBarcode> TB_Prd_OldMatBarcodeBindNewMatBarcode { get; set; }
        public virtual DbSet<TB_Prd_OutsideBatchInfo> TB_Prd_OutsideBatchInfo { get; set; }
        public virtual DbSet<TB_Prd_OvenTemperaturePaperUpload> TB_Prd_OvenTemperaturePaperUpload { get; set; }
        public virtual DbSet<TB_Prd_PackValidate> TB_Prd_PackValidate { get; set; }
        public virtual DbSet<TB_Prd_PickingMat> TB_Prd_PickingMat { get; set; }
        public virtual DbSet<TB_Prd_PO> TB_Prd_PO { get; set; }
        public virtual DbSet<TB_Prd_POBatch> TB_Prd_POBatch { get; set; }
        public virtual DbSet<TB_Prd_POBatchProd> TB_Prd_POBatchProd { get; set; }
        public virtual DbSet<TB_Prd_POBatchPSN> TB_Prd_POBatchPSN { get; set; }
        public virtual DbSet<TB_Prd_POLinkD> TB_Prd_POLinkD { get; set; }
        public virtual DbSet<TB_Prd_POLinkM> TB_Prd_POLinkM { get; set; }
        public virtual DbSet<TB_Prd_POMats> TB_Prd_POMats { get; set; }
        public virtual DbSet<TB_Prd_PoPackInfo> TB_Prd_PoPackInfo { get; set; }
        public virtual DbSet<TB_Prd_PoPackList> TB_Prd_PoPackList { get; set; }
        public virtual DbSet<TB_Prd_POPars> TB_Prd_POPars { get; set; }
        public virtual DbSet<TB_Prd_PoPSMat> TB_Prd_PoPSMat { get; set; }
        public virtual DbSet<TB_Prd_POSetup> TB_Prd_POSetup { get; set; }
        public virtual DbSet<TB_Prd_POSetupEX> TB_Prd_POSetupEX { get; set; }
        public virtual DbSet<TB_Prd_POStart> TB_Prd_POStart { get; set; }
        public virtual DbSet<TB_Prd_PoUPHReport> TB_Prd_PoUPHReport { get; set; }
        public virtual DbSet<TB_Prd_PPacks> TB_Prd_PPacks { get; set; }
        public virtual DbSet<TB_Prd_PPacksD> TB_Prd_PPacksD { get; set; }
        public virtual DbSet<TB_Prd_PrintLableData> TB_Prd_PrintLableData { get; set; }
        public virtual DbSet<TB_Prd_ProcMans> TB_Prd_ProcMans { get; set; }
        public virtual DbSet<TB_Prd_ProdTran> TB_Prd_ProdTran { get; set; }
        public virtual DbSet<TB_Prd_PrtBatchList> TB_Prd_PrtBatchList { get; set; }
        public virtual DbSet<TB_Prd_PSMatMaintain> TB_Prd_PSMatMaintain { get; set; }
        public virtual DbSet<TB_Prd_RecLog> TB_Prd_RecLog { get; set; }
        public virtual DbSet<TB_Prd_RecMatDucWebService> TB_Prd_RecMatDucWebService { get; set; }
        public virtual DbSet<TB_Prd_RecMats> TB_Prd_RecMats { get; set; }
        public virtual DbSet<TB_Prd_RecordSN> TB_Prd_RecordSN { get; set; }
        public virtual DbSet<TB_Prd_RepairBackMat> TB_Prd_RepairBackMat { get; set; }
        public virtual DbSet<TB_Prd_RepairIn> TB_Prd_RepairIn { get; set; }
        public virtual DbSet<TB_Prd_RepairOut> TB_Prd_RepairOut { get; set; }
        public virtual DbSet<TB_Prd_RepairScrap> TB_Prd_RepairScrap { get; set; }
        public virtual DbSet<TB_Prd_RollBackLog> TB_Prd_RollBackLog { get; set; }
        public virtual DbSet<TB_Prd_RoutineCheckSNRecord> TB_Prd_RoutineCheckSNRecord { get; set; }
        public virtual DbSet<TB_Prd_SimpleBindMat> TB_Prd_SimpleBindMat { get; set; }
        public virtual DbSet<TB_Prd_SizeDetectionData> TB_Prd_SizeDetectionData { get; set; }
        public virtual DbSet<TB_Prd_SMTMatSetDetail> TB_Prd_SMTMatSetDetail { get; set; }
        public virtual DbSet<TB_Prd_SMTMatSetM> TB_Prd_SMTMatSetM { get; set; }
        public virtual DbSet<TB_Prd_SNData> TB_Prd_SNData { get; set; }
        public virtual DbSet<TB_Prd_SNPLog> TB_Prd_SNPLog { get; set; }
        public virtual DbSet<TB_Prd_SPIAOIData> TB_Prd_SPIAOIData { get; set; }
        public virtual DbSet<TB_Prd_StockInfo> TB_Prd_StockInfo { get; set; }
        public virtual DbSet<TB_Prd_Stocks> TB_Prd_Stocks { get; set; }
        public virtual DbSet<TB_Prd_StoreRemoveD> TB_Prd_StoreRemoveD { get; set; }
        public virtual DbSet<TB_Prd_StoreRemoveM> TB_Prd_StoreRemoveM { get; set; }
        public virtual DbSet<TB_Prd_StoreScrapD> TB_Prd_StoreScrapD { get; set; }
        public virtual DbSet<TB_Prd_StoreScrapM> TB_Prd_StoreScrapM { get; set; }
        public virtual DbSet<TB_Prd_StoreScrapSND> TB_Prd_StoreScrapSND { get; set; }
        public virtual DbSet<TB_Prd_ThawingAndDeaerate> TB_Prd_ThawingAndDeaerate { get; set; }
        public virtual DbSet<TB_Prd_TranInfo> TB_Prd_TranInfo { get; set; }
        public virtual DbSet<TB_Prd_TranInfoLog> TB_Prd_TranInfoLog { get; set; }
        public virtual DbSet<TB_Prd_TranMac> TB_Prd_TranMac { get; set; }
        public virtual DbSet<TB_Prd_TranNGInfo> TB_Prd_TranNGInfo { get; set; }
        public virtual DbSet<TB_Prd_TranPPar> TB_Prd_TranPPar { get; set; }
        public virtual DbSet<TB_Prd_TranSNNGInfo> TB_Prd_TranSNNGInfo { get; set; }
        public virtual DbSet<TB_Prd_UnBindSNLog> TB_Prd_UnBindSNLog { get; set; }
        public virtual DbSet<TB_Prd_UnLockSNOrSensorID> TB_Prd_UnLockSNOrSensorID { get; set; }
        public virtual DbSet<TB_Prd_UseAdjMat> TB_Prd_UseAdjMat { get; set; }
        public virtual DbSet<TB_Prd_UserUPHReport> TB_Prd_UserUPHReport { get; set; }
        public virtual DbSet<TB_Pub_BalanceMatD> TB_Pub_BalanceMatD { get; set; }
        public virtual DbSet<TB_Pub_BalanceMatM> TB_Pub_BalanceMatM { get; set; }
        public virtual DbSet<TB_Pub_CurrentReciveMat> TB_Pub_CurrentReciveMat { get; set; }
        public virtual DbSet<TB_Pub_DictDetail> TB_Pub_DictDetail { get; set; }
        public virtual DbSet<TB_Pub_DictMaster> TB_Pub_DictMaster { get; set; }
        public virtual DbSet<TB_Pub_Machines> TB_Pub_Machines { get; set; }
        public virtual DbSet<TB_Pub_MatCon> TB_Pub_MatCon { get; set; }
        public virtual DbSet<TB_Pub_MatListD> TB_Pub_MatListD { get; set; }
        public virtual DbSet<TB_Pub_MatListM> TB_Pub_MatListM { get; set; }
        public virtual DbSet<TB_Pub_MatRec> TB_Pub_MatRec { get; set; }
        public virtual DbSet<TB_Pub_MatUseRec> TB_Pub_MatUseRec { get; set; }
        public virtual DbSet<TB_Pub_NGClass> TB_Pub_NGClass { get; set; }
        public virtual DbSet<TB_Pub_NGCodes> TB_Pub_NGCodes { get; set; }
        public virtual DbSet<TB_Pub_NGGroup> TB_Pub_NGGroup { get; set; }
        public virtual DbSet<TB_Pub_OperateLog> TB_Pub_OperateLog { get; set; }
        public virtual DbSet<TB_Pub_POPars> TB_Pub_POPars { get; set; }
        public virtual DbSet<TB_Pub_PreventErrorMatD> TB_Pub_PreventErrorMatD { get; set; }
        public virtual DbSet<TB_Pub_PreventErrorMatM> TB_Pub_PreventErrorMatM { get; set; }
        public virtual DbSet<TB_Pub_ProcClass> TB_Pub_ProcClass { get; set; }
        public virtual DbSet<TB_Pub_ProcMans> TB_Pub_ProcMans { get; set; }
        public virtual DbSet<TB_Pub_ProcPriceCount> TB_Pub_ProcPriceCount { get; set; }
        public virtual DbSet<TB_Pub_ProcProdAbility> TB_Pub_ProcProdAbility { get; set; }
        public virtual DbSet<TB_Pub_ProcSetup> TB_Pub_ProcSetup { get; set; }
        public virtual DbSet<TB_Pub_ProcSPs> TB_Pub_ProcSPs { get; set; }
        public virtual DbSet<TB_Pub_PSWK> TB_Pub_PSWK { get; set; }
        public virtual DbSet<TB_Pub_PWarehouse> TB_Pub_PWarehouse { get; set; }
        public virtual DbSet<TB_Pub_QCParms> TB_Pub_QCParms { get; set; }
        public virtual DbSet<TB_Pub_ReciveMat> TB_Pub_ReciveMat { get; set; }
        public virtual DbSet<TB_Pub_RoutingPlanD> TB_Pub_RoutingPlanD { get; set; }
        public virtual DbSet<TB_Pub_RoutingPlanM> TB_Pub_RoutingPlanM { get; set; }
        public virtual DbSet<TB_Pub_RPlanType> TB_Pub_RPlanType { get; set; }
        public virtual DbSet<TB_Pub_SNListD> TB_Pub_SNListD { get; set; }
        public virtual DbSet<TB_Pub_SNListM> TB_Pub_SNListM { get; set; }
        public virtual DbSet<TB_Pub_SNRec> TB_Pub_SNRec { get; set; }
        public virtual DbSet<TB_Pub_SNUseRec> TB_Pub_SNUseRec { get; set; }
        public virtual DbSet<TB_Pub_Storage> TB_Pub_Storage { get; set; }
        public virtual DbSet<TB_Pub_UserDictDetail> TB_Pub_UserDictDetail { get; set; }
        public virtual DbSet<TB_Pub_UserDictMaster> TB_Pub_UserDictMaster { get; set; }
        public virtual DbSet<TB_Pub_WarClass> TB_Pub_WarClass { get; set; }
        public virtual DbSet<TB_Pub_Warehouse> TB_Pub_Warehouse { get; set; }
        public virtual DbSet<TB_Pub_WCClass> TB_Pub_WCClass { get; set; }
        public virtual DbSet<TB_Pub_WCQCParms> TB_Pub_WCQCParms { get; set; }
        public virtual DbSet<TB_Pub_WorkCenter> TB_Pub_WorkCenter { get; set; }
        public virtual DbSet<TB_QC_OQCAQL> TB_QC_OQCAQL { get; set; }
        public virtual DbSet<TB_QC_OQCCheck> TB_QC_OQCCheck { get; set; }
        public virtual DbSet<TB_QC_OQCCheckNG> TB_QC_OQCCheckNG { get; set; }
        public virtual DbSet<TB_QC_RPCPlan> TB_QC_RPCPlan { get; set; }
        public virtual DbSet<TB_QC_SPCPlanD> TB_QC_SPCPlanD { get; set; }
        public virtual DbSet<TB_QC_SPCRec> TB_QC_SPCRec { get; set; }
        public virtual DbSet<TB_QC_SPCRecD> TB_QC_SPCRecD { get; set; }
        public virtual DbSet<TB_SAPNGCodes> TB_SAPNGCodes { get; set; }
        public virtual DbSet<TB_SYS_AutoNo_Detail> TB_SYS_AutoNo_Detail { get; set; }
        public virtual DbSet<TB_SYS_AutoNo_Master> TB_SYS_AutoNo_Master { get; set; }
        public virtual DbSet<TB_SYS_AutoNo_Rec> TB_SYS_AutoNo_Rec { get; set; }
        public virtual DbSet<TB_SYS_Config> TB_SYS_Config { get; set; }
        public virtual DbSet<TB_SYS_ConfigDetail> TB_SYS_ConfigDetail { get; set; }
        public virtual DbSet<TB_Sys_ExceptionLog> TB_Sys_ExceptionLog { get; set; }
        public virtual DbSet<TB_Sys_Log> TB_Sys_Log { get; set; }
        public virtual DbSet<TB_SYS_System> TB_SYS_System { get; set; }
        public virtual DbSet<TB_SYS_UserInfo> TB_SYS_UserInfo { get; set; }
        public virtual DbSet<TB_War_ChkLab> TB_War_ChkLab { get; set; }
        public virtual DbSet<TB_War_ERPInput> TB_War_ERPInput { get; set; }
        public virtual DbSet<TB_War_ERPInputBG> TB_War_ERPInputBG { get; set; }
        public virtual DbSet<TB_War_ERPInputD> TB_War_ERPInputD { get; set; }
        public virtual DbSet<TB_War_ERPInputLab> TB_War_ERPInputLab { get; set; }
        public virtual DbSet<TB_War_NGERPInput> TB_War_NGERPInput { get; set; }
        public virtual DbSet<TB_War_NGERPInputBG> TB_War_NGERPInputBG { get; set; }
        public virtual DbSet<TB_War_NGERPInputD> TB_War_NGERPInputD { get; set; }
        public virtual DbSet<TB_War_PackB> TB_War_PackB { get; set; }
        public virtual DbSet<TB_War_PackLab> TB_War_PackLab { get; set; }
        public virtual DbSet<TB_War_PackM> TB_War_PackM { get; set; }
        public virtual DbSet<TB_War_StoreExcD> TB_War_StoreExcD { get; set; }
        public virtual DbSet<TB_War_StoreExcM> TB_War_StoreExcM { get; set; }
        public virtual DbSet<TB_Web_ModuleDetail> TB_Web_ModuleDetail { get; set; }
        public virtual DbSet<TB_Web_ModuleMaster> TB_Web_ModuleMaster { get; set; }
        public virtual DbSet<TB_Web_RolesDetail> TB_Web_RolesDetail { get; set; }
        public virtual DbSet<TB_Web_RolesMaster> TB_Web_RolesMaster { get; set; }
        public virtual DbSet<TB_Web_UserRoles> TB_Web_UserRoles { get; set; }
        public virtual DbSet<TB_WIP_POBatch> TB_WIP_POBatch { get; set; }
        public virtual DbSet<TB_WIP_POBatchLog> TB_WIP_POBatchLog { get; set; }
        public virtual DbSet<TB_WIP_POBatchMats> TB_WIP_POBatchMats { get; set; }
        public virtual DbSet<TB_WIP_StopInfo> TB_WIP_StopInfo { get; set; }
        public virtual DbSet<TB_Prd_NgStoreRW> TB_Prd_NgStoreRW { get; set; }
        public virtual DbSet<TB_Prd_POBatch_20220607> TB_Prd_POBatch_20220607 { get; set; }
        public virtual DbSet<TB_Prd_SnNgInfo> TB_Prd_SnNgInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // 去除表名复数形式
            //modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();


            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_Guid)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_LabName)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_LabKey)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_LabValue)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_LabType)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_LableDes)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_Split)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_SNRule)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_PackType)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_TxtType)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigD>()
                .Property(e => e.FC_TxtName)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigM>()
                .Property(e => e.FC_Guid)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigM>()
                .Property(e => e.FC_LabName)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigM>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigM>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigM>()
                .Property(e => e.FC_SNRule)
                .IsUnicode(false);

            modelBuilder.Entity<LableConfigM>()
                .Property(e => e.FC_PackType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_DeptID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FN_Level)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_Tel)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_Zip)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_Mobel)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_EMail)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_ParentID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_DeptType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Dept>()
                .Property(e => e.FC_StockFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_DeptManas>()
                .Property(e => e.FC_ManaNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_DeptManas>()
                .Property(e => e.FC_DeptID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_DeptManas>()
                .Property(e => e.FC_EmpID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_DeptManas>()
                .Property(e => e.FC_ManaID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_DeptManas>()
                .Property(e => e.FC_ProxEmpID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_DeptManas>()
                .Property(e => e.FC_ExtInfo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_DeptManas>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_DeptManas>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_DeptManas>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_EmpID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_DeptID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_EmpCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_Sex)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_WorkStatus)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_WorkType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_Edu)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_Nation)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_Tel)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_Mobel)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_EMail)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_QQ)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_WeiXi)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HR_Employees>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_PrtID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_PVer)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtRec>()
                .Property(e => e.FC_FMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtSeqD>()
                .Property(e => e.FC_FixChar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtSeqD>()
                .Property(e => e.FC_PartID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtSeqD>()
                .Property(e => e.FN_CurrNum)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Pck_PrtSeqM>()
                .Property(e => e.FC_PartID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtSeqM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtSeqM>()
                .HasMany(e => e.TB_Pck_PrtSeqD)
                .WithRequired(e => e.TB_Pck_PrtSeqM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Pck_PrtSeqRec>()
                .Property(e => e.FC_UseID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtSeqRec>()
                .Property(e => e.FC_PartID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtSeqRec>()
                .Property(e => e.FN_GetNum)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Pck_PrtSeqRec>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pck_PrtSeqRec>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_Process)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_Equipment)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_Model)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_LotNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_TestResult)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_ErrorCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_JobLocation)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_SonsorIDResult)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_SonsorID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FD_SonsorIDTime)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA1Result)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA1CC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA1UL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA1UR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA1LL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA1LR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA1PLOT_AA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA1ImageCount)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA1ImageCountTestTime)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA2Result)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA2CC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA2UL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA2UR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA2LL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA2LR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA2PLOT_AA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA2ImageCount)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AAData>()
                .Property(e => e.FC_AA2ImageCountTestTime)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccDetail>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccDetail>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccDetail>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccDetail>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccDetail>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccDetail>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_AccessoriesD>()
                .Property(e => e.FC_AccessoriesNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD>()
                .Property(e => e.FC_AccessoriesBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD>()
                .Property(e => e.FC_AccessoriesName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD>()
                .Property(e => e.FC_AccessoriesStatus)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD>()
                .Property(e => e.FC_CreatPeople)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD_History>()
                .Property(e => e.FC_AccessoriesNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD_History>()
                .Property(e => e.FC_AccessoriesBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD_History>()
                .Property(e => e.FC_AccessoriesName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD_History>()
                .Property(e => e.FC_AccessoriesStatus)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD_History>()
                .Property(e => e.FC_CreatPeople)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD_History>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD_History>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesD_History>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_AccessoriesName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_AccessoriesNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_AccessoriesType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_brand)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_Spec)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_CreatPeople)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_BackCount)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_AccessoriesRule)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AccessoriesM>()
                .Property(e => e.FC_AccessoriesPrdType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AdjWarn>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AdjWarn>()
                .Property(e => e.FC_BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_AdjWarn>()
                .Property(e => e.FC_Prompt)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_App_System>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_App_System>()
                .Property(e => e.APP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_App_System>()
                .Property(e => e.APP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_App_System>()
                .Property(e => e.SECRET)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_EditionNums)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_Material)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_PeculiarCraft)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_Remarks1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_Remarks2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_Remarks3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_Remarks4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_SuccessProduct)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_ArrangeInfo>()
                .Property(e => e.FC_UrgencyRemarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeStatus>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeStatus>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeStatus>()
                .Property(e => e.FC_OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeStatus>()
                .Property(e => e.FC_Remarks2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeStatus>()
                .Property(e => e.FC_Remarks3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ArrangeStatus>()
                .Property(e => e.FC_Remarks4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackAdjMat>()
                .Property(e => e.FC_BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackAdjMat>()
                .Property(e => e.FC_AJPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackAdjMat>()
                .Property(e => e.FC_BackMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackAdjMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackAdjMat>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackAdjMat>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNg>()
                .Property(e => e.FC_BackNgID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNg>()
                .Property(e => e.FC_BackNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNg>()
                .Property(e => e.FC_StockID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNg>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNg>()
                .Property(e => e.FC_NgGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNg>()
                .Property(e => e.FC_NGCodeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNumSN>()
                .Property(e => e.FC_BackNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNumSN>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNumSN>()
                .Property(e => e.FC_CheckMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNumSN>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackNumSN>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOD>()
                .Property(e => e.FC_BackDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOD>()
                .Property(e => e.FC_BackNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOD>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOD>()
                .Property(e => e.FC_NGCodeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOD>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_BackNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_SubMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.AccFN_BackNums)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .Property(e => e.NGNums)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_BackPOM>()
                .HasMany(e => e.TB_Prd_BackPOSND)
                .WithRequired(e => e.TB_Prd_BackPOM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_WKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ProcType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FN_StdProcTime)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_BGType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ERPCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ERPWC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ERPPTNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ERPBG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_TranTypeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FN_ERPPer)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ERPUnit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FN_ERPPSNums)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ERPConFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ERPOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_TSType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ConMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ConMPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ConPPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ConLabPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ConPCSPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ScanIDT1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ScanIDT2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_ScanIDT3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_NeedMat)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_BackNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSetup>()
                .Property(e => e.FC_BackID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_BackSNDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_PONO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_BatchNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_BackNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_backBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_UDF02)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_UDF03)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_UDF04)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_UDF05)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BackPOSND>()
                .Property(e => e.FC_Status)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BakeTimeControl>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BakeTimeControl>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BakeTimeControl>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BakeTimeControl>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BakeTimeControl>()
                .Property(e => e.FC_LineID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BakeTimeControl>()
                .Property(e => e.FC_Machine)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BakeTimeControl>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BakeTimeControl>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BakeTimeControl>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchBackMat>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchBackMat>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchBackMat>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchBackMat>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchBackMat>()
                .Property(e => e.FC_BackUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchBackMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchBackMat>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDevice>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDevice>()
                .Property(e => e.FC_DeviceID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDevice>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDevice>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDevice>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDevice>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDevice>()
                .Property(e => e.FC_LineID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDevice>()
                .Property(e => e.FC_Sharp)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDevice>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDownCount>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDownCount>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchDownCount>()
                .Property(e => e.FC_DownCount)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchGetMat>()
                .Property(e => e.FC_GetMatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchGetMat>()
                .Property(e => e.FC_GetMatMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchGetMat>()
                .Property(e => e.FC_OutputStorage)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchGetMat>()
                .Property(e => e.FC_InputStorage)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchGetMat>()
                .Property(e => e.FC_GetMatFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchGetMat>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchGetMat>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchGetMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_MatSN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_MatName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_SupplierNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_ProdBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_DateCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_SendGoodsBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_SingleSetNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_MatDishNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_BottleNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_ModelNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_SerialNum)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_GetUseFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_SendGoodsBatchNum)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_GetMatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_Position)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_Line)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_InDate)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchMat>()
                .Property(e => e.FC_BackDate)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_UseMatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_UseMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_SendMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_ConMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_OutWar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_InWar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_ERPPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_PSID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_UseWC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_UseMatMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_Spec)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMat2>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_UseMatDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_POMatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_UseMatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_WarID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_PSID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_ErpRecBNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_MatSN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_SuprNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_DateCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_Spare)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.Spare)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BatchUseMatD>()
                .Property(e => e.FC_Spare2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_FPCNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_Sharp)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_UPUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPC>()
                .Property(e => e.FC_FPCNoNew)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPCSN>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPCSN>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPCSN>()
                .Property(e => e.FC_FPCNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPCSN>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPCSN>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPCSN>()
                .Property(e => e.FC_LineID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BindBatchFPCSN>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BreakPackLog>()
                .Property(e => e.FC_PackNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BreakPackLog>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_BreakPackLog>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ChangeLog>()
                .Property(e => e.FC_ChgID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ChangeLog>()
                .Property(e => e.FC_ERPPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ChangeLog>()
                .Property(e => e.FC_ChgFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ChangeLog>()
                .Property(e => e.FC_ProcFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ChangeLog>()
                .Property(e => e.FC_SendID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_COBOutNum>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_COBOutNum>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_COBOutNum>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_COBOutNum>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_COBOutNum>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_COBOutNum>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_COBOutNum>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyData>()
                .Property(e => e.FC_User)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyData>()
                .Property(e => e.FC_PS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyData>()
                .Property(e => e.FC_PNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyData>()
                .Property(e => e.FC_Version)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyData>()
                .Property(e => e.FC_OpeType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyData>()
                .Property(e => e.FC_PathFile)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyPower>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyPower>()
                .Property(e => e.FC_UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyPower>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CopyPower>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CredentialPrinting>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CredentialPrinting>()
                .Property(e => e.FC_MatPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CredentialPrinting>()
                .Property(e => e.FC_MatBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_CredentialPrinting>()
                .Property(e => e.FN_PickupNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_CredentialPrinting>()
                .Property(e => e.FN_UseNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_CredentialPrinting>()
                .Property(e => e.FN_RemainNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_CredentialPrinting>()
                .Property(e => e.FN_ThrowingRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_CredentialPrinting>()
                .Property(e => e.FN_ReturnedNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_CredentialPrinting>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DateChar>()
                .Property(e => e.FC_Char)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DateChar>()
                .Property(e => e.FC_Rule)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DateChar>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_PlanNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_ClassNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_PlanMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_SendMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_DayPlan>()
                .Property(e => e.FC_ChkMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlanD>()
                .Property(e => e.FC_PlanDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlanD>()
                .Property(e => e.FC_PlanNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlanD>()
                .Property(e => e.FC_Code)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlanD>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlanD>()
                .Property(e => e.FC_Lvl)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlanD>()
                .Property(e => e.FC_MatStatus)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlanD>()
                .Property(e => e.FC_RecType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DayPlanD>()
                .Property(e => e.FN_Per)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_TranNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_SID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_DeviceID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_ProcWK)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_ChkMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_BCType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_RecManFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_RecMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_ERPBGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_ERPBGCount)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_PWType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_SplitFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_TranTypeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_NeedBG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranInfo>()
                .Property(e => e.FC_MacNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranNGInfo>()
                .Property(e => e.FC_NGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranNGInfo>()
                .Property(e => e.FC_TranNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranNGInfo>()
                .Property(e => e.FC_CodeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranNGInfo>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranNGInfo>()
                .Property(e => e.FC_ChkMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranNGInfo>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_DeviceTranNGInfo>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_EolYeildRate>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_EolYeildRate>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_EolYeildRate>()
                .Property(e => e.FD_CDate)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_EolYeildRate>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_EolYeildRate>()
                .Property(e => e.FC_SFCCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FinshChks>()
                .Property(e => e.FC_FCNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FinshChks>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FinshChks>()
                .Property(e => e.FC_FCCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FinshChks>()
                .Property(e => e.FC_ERPCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_FPCNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_MatBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_LineID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_FPCBindMat>()
                .Property(e => e.FC_MatType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_GetAdjMS>()
                .Property(e => e.FC_BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_GetAdjMS>()
                .Property(e => e.FC_AJPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_GetAdjMS>()
                .Property(e => e.FC_Spec)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_GetAdjMS>()
                .Property(e => e.FC_GetMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_GetAdjMS>()
                .Property(e => e.FC_GetFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_GetAdjMS>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_GetAdjMS>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_GetAdjMS>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_GetAdjMS>()
                .Property(e => e.FC_AccessoriesName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_HaiWeiWeekData>()
                .Property(e => e.FC_WeekCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_HaiWeiWeekData>()
                .Property(e => e.FC_WeekDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_MatBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_NGName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_SCrapType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_MatPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_IncomingMatScrap>()
                .Property(e => e.FC_MatPNoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_InputOverWarehousingLog>()
                .Property(e => e.FC_InputNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_InputOverWarehousingLog>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_InputOverWarehousingLog>()
                .Property(e => e.FC_Status)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingPoDownNumber>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingPrintSN>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingPrintSN>()
                .Property(e => e.FC_PONO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingPrintSN>()
                .Property(e => e.FC_FPCNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingPrintSN>()
                .Property(e => e.FC_FPCNoBehind)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingPrintSN>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingPrintSN>()
                .Property(e => e.FC_FPCBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingPrintSN>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingRecordSN>()
                .Property(e => e.FC_Date)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LaserEngravingRecordSN>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LockSNOrSensorID>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LockSNOrSensorID>()
                .Property(e => e.FC_SensorID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LockSNOrSensorID>()
                .Property(e => e.FC_LockReason)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LockSNOrSensorID>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LockSNOrSensorID>()
                .Property(e => e.FC_PsCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LockStatus>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LockStatus>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LockStatus>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_LockStatus>()
                .Property(e => e.FC_UDF02)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MachineReport>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MachineReport>()
                .Property(e => e.FC_SFCCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MachineReport>()
                .Property(e => e.MachineNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MachineReport>()
                .Property(e => e.FD_CDate)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FN_SumQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FN_GoodQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FN_NGQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FN_RepairtQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FN_RepeatQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FN_StanderOfflineQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MachineUPHReport>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatClose>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatClose>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatClose>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatKeepRight>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatKeepRight>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatKeepRight>()
                .Property(e => e.FC_WorkNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatKeepRight>()
                .Property(e => e.FC_Seat)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatKeepRight>()
                .Property(e => e.FC_Mat)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatKeepRight>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatKeepRight>()
                .Property(e => e.FC_MachineName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatKeepRight>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_FPCNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_DeviceID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_MatBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_LineID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_MatTable)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_MatType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FC_MatPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MatMouting>()
                .Property(e => e.FN_UseNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_POEXNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_POEX)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_EXMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_ERPCustNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_SalePNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FN_ERPInPer)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_ERPWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_EXNote)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MESPOEX>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveD>()
                .Property(e => e.FC_DID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveD>()
                .Property(e => e.FC_MoveID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveD>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveD>()
                .Property(e => e.FC_NewBNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_MoveID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_NewPONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_MoveType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_CMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_ConMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_MoveM>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_NGSplitDetial>()
                .Property(e => e.FC_DID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitDetial>()
                .Property(e => e.FC_NGSplitNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitDetial>()
                .Property(e => e.FC_StockID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitDetial>()
                .Property(e => e.FC_PType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitDetial>()
                .Property(e => e.FC_NGCodeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitDetial>()
                .Property(e => e.FC_PSNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitDetial>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitDetial>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_NGSplitNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_WarID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_SubMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_ConMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitMain>()
                .Property(e => e.FD_APPType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutD>()
                .Property(e => e.FC_DID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutD>()
                .Property(e => e.FC_SplitOutNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutD>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutD>()
                .Property(e => e.FC_PType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutD>()
                .Property(e => e.FC_WarType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutD>()
                .Property(e => e.FC_WarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutD>()
                .Property(e => e.FC_StockID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutD>()
                .Property(e => e.FC_SourceStockID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutD>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutM>()
                .Property(e => e.FC_SplitOutNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutM>()
                .Property(e => e.FC_NGSplitNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutM>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutM>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutM>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NGSplitOutM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OldMatBarcodeBindNewMatBarcode>()
                .Property(e => e.FC_OldPoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OldMatBarcodeBindNewMatBarcode>()
                .Property(e => e.FC_OldMatBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OldMatBarcodeBindNewMatBarcode>()
                .Property(e => e.FC_NewPoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OldMatBarcodeBindNewMatBarcode>()
                .Property(e => e.FC_NewMatBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OldMatBarcodeBindNewMatBarcode>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OutsideBatchInfo>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OutsideBatchInfo>()
                .Property(e => e.FC_PickNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_OutsideBatchInfo>()
                .Property(e => e.FC_UseNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_OutsideBatchInfo>()
                .Property(e => e.FC_RemainNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_OvenTemperaturePaperUpload>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OvenTemperaturePaperUpload>()
                .Property(e => e.FC_FromPatch)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OvenTemperaturePaperUpload>()
                .Property(e => e.FC_ToPatch)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OvenTemperaturePaperUpload>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OvenTemperaturePaperUpload>()
                .Property(e => e.FC_LocalFile)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_OvenTemperaturePaperUpload>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PackValidate>()
                .Property(e => e.FC_InnerID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PackValidate>()
                .Property(e => e.FC_CartonID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PackValidate>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PackValidate>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FC_MatBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FC_MatType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FN_PickNumber)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FC_PNoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FN_StanderNumber)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FN_RemainNumber)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PickingMat>()
                .Property(e => e.FN_UseNumber)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_LinkNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_PVer)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_CreateType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_POType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ConMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_PMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_MESRMNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_SONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPCustNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPYWDept)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPRNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPRVer)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPPTNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPYWEmpNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_HisFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_RecBatch)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_FacPOType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPUnitISO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_SalePNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPSaleItem)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_RecMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FN_ERPInPer)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPLG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FN_ERPLG)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_LCDQWC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_ERPCustSo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_CustMatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_CustMatNoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .Property(e => e.FC_CustOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PO>()
                .HasMany(e => e.TB_Prd_POPars)
                .WithRequired(e => e.TB_Prd_PO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_BatchCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_CurrPS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_CurrPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_ERPBCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_BFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_HisFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_BCType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_TCID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_BackNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_PSCodeID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_CurrBPS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_CurrBPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FN_ERPBNo)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_MatFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_SplitFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_OldBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_SplitPS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_SplitPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_BPrtFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .Property(e => e.FC_BatchMat)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch>()
                .HasOptional(e => e.TB_Prd_POBatch1)
                .WithRequired(e => e.TB_Prd_POBatch2);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_ProdID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_CurrPS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_CurrPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_ProdType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_ProdCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_ProdFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_PID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_NGPSID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_NGPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_ProdType2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_ProdCode2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_ProdType3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_ProdCode3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_MBoxID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_CodeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchProd>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_PO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_Code)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_SNType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_SFC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_UDF02)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_UDF03)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_UDF04)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_UDF05)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FN_UDF51)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FN_UDF52)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FN_UDF53)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FN_UDF54)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FN_UDF55)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatchPSN>()
                .Property(e => e.FC_MaterialID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POLinkD>()
                .Property(e => e.FC_LinkDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POLinkD>()
                .Property(e => e.FC_LinkNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POLinkD>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POLinkD>()
                .Property(e => e.FC_EndPONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POLinkD>()
                .Property(e => e.FC_FPONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POLinkM>()
                .Property(e => e.FC_LinkNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_POMatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_RDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FN_PerOne)
                .HasPrecision(18, 5);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_Units)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_MatTNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_ERPMatTNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_ERPWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_ERPBNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_ERPReOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_MatConType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_ERPGFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_ERPMGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_ERPSZFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POMats>()
                .Property(e => e.FC_ERPSFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackInfo>()
                .Property(e => e.FC_PackID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackInfo>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackInfo>()
                .Property(e => e.FC_PackType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackInfo>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackInfo>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackInfo>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackInfo>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_ParentID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_PrtID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_PackType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_BatchCodes)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_PrtFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPackList>()
                .Property(e => e.FC_BoxNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POPars>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POPars>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POPars>()
                .Property(e => e.FC_PoParNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POPars>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POPars>()
                .Property(e => e.FC_ParValue)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPSMat>()
                .Property(e => e.FC_PONO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPSMat>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPSMat>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPSMat>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPSMat>()
                .Property(e => e.FC_MatName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPSMat>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoPSMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_WKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ProcType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FN_StdProcTime)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_BGType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ERPCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ERPWC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ERPPTNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ERPBG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_TranTypeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FN_ERPPer)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ERPUnit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FN_ERPPSNums)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ERPConFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ERPOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_TSType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ConMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ConMPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ConPPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ConLabPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ConPCSPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ScanIDT1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ScanIDT2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ScanIDT3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_NeedMat)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_CodeReg)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_CurrPSControlCondition)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_PrePSControlCondition)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_SoftVersion)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetup>()
                .Property(e => e.FC_ReleaseDeviceFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_WKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ProcType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_BGType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_TranTypeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ERPOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ERPCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ERPWC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ERPPTNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ERPBG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FN_ERPPer)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ERPUnit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FN_ERPPSNums)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ERPConFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_TSType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ConMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ConMPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ConPPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ConLabPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ConPCSPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ScanIDT1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ScanIDT2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_ScanIDT3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FN_OOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_OPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_OProcType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_OTranTypeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POSetupEX>()
                .Property(e => e.FC_OBGType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POStart>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POStart>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POStart>()
                .Property(e => e.FC_PMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POStart>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POStart>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POStart>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POStart>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POStart>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_POStart>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POStart>()
                .HasMany(e => e.TB_Prd_POBatch)
                .WithOptional(e => e.TB_Prd_POStart)
                .HasForeignKey(e => e.FC_TCID);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FN_PoStanderQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FN_PoOfflineQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FN_RemainQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FC_PoOfflineYeild)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FC_UUserD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FN_RepairIn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FN_RepairOut)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FN_BackQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FN_RepairOffline)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FN_CustBackQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_PoUPHReport>()
                .Property(e => e.FN_CustOfflineQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_PID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_PVer)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Ext2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_PrdLabRegular)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_SNSql)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_SNFix1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_SNFix2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_SNFix3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_SNFix4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field5)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field6)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field7)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field8)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field9)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_Field10)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacks>()
                .Property(e => e.FC_BYDSupNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacksD>()
                .Property(e => e.FC_PackID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacksD>()
                .Property(e => e.FC_PID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacksD>()
                .Property(e => e.FC_PackType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacksD>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacksD>()
                .Property(e => e.FC_Ext2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacksD>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacksD>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PPacksD>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PrintLableData>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PrintLableData>()
                .Property(e => e.FC_PrintLableInfo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PrintLableData>()
                .Property(e => e.FC_PrintData)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PrintLableData>()
                .Property(e => e.FC_PackSN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProcMans>()
                .Property(e => e.FC_RecNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProcMans>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProcMans>()
                .Property(e => e.FC_TranNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProcMans>()
                .Property(e => e.FC_EmpCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProcMans>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProcMans>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProcMans>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_ProdTran>()
                .Property(e => e.FC_PTranID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProdTran>()
                .Property(e => e.FC_ProdID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProdTran>()
                .Property(e => e.FC_ProdFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProdTran>()
                .Property(e => e.FC_TrPS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProdTran>()
                .Property(e => e.FC_TrPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ProdTran>()
                .Property(e => e.FC_TrUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PrtBatchList>()
                .Property(e => e.FC_BID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PrtBatchList>()
                .Property(e => e.FC_PrtID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PrtBatchList>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PSMatMaintain>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PSMatMaintain>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PSMatMaintain>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PSMatMaintain>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PSMatMaintain>()
                .Property(e => e.FC_UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PSMatMaintain>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_PSMatMaintain>()
                .Property(e => e.FC_UpUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecLog>()
                .Property(e => e.FC_ERPPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecLog>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecLog>()
                .Property(e => e.FC_SendID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecLog>()
                .Property(e => e.FC_Err)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMatDucWebService>()
                .Property(e => e.FC_Exception)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMatDucWebService>()
                .Property(e => e.FC_Json)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_POMatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_WarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_SetupNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_SuprNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_SoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_ErpRecNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_ErpRecBNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_ErpWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_ErpSetupNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_WarID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_RowItem)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_MatTNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_MatGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_ERPMVType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_ERPUseNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_ERPYear)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_MatGNote)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_MatTNote)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_ERPSDate)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_ERPRecDate)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecMats>()
                .Property(e => e.FC_MatCheck)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecordSN>()
                .Property(e => e.FC_Date)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RecordSN>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairBackMat>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairBackMat>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairBackMat>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairBackMat>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairBackMat>()
                .Property(e => e.FC_MatBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairBackMat>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairBackMat>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairBackMat>()
                .Property(e => e.FC_MatPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairBackMat>()
                .Property(e => e.FC_MatDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_Factroy)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_PO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_NgGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_NGCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_NGDetail)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_LineID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_RepairUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_RePairType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairIn>()
                .Property(e => e.FC_CurrentBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_Factroy)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_PO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_BackBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_NgGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_NGDetail)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_NGCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_NGDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_NGReason)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_MantainFunc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_ReworkPsCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_MantianResult)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_MantainUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairOut>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_MatPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RepairScrap>()
                .Property(e => e.FC_MatPNoDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RollBackLog>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RollBackLog>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RollBackLog>()
                .Property(e => e.FC_RollBackFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RollBackLog>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RoutineCheckSNRecord>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RoutineCheckSNRecord>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RoutineCheckSNRecord>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RoutineCheckSNRecord>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_RoutineCheckSNRecord>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_MatBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_LineID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SimpleBindMat>()
                .Property(e => e.FC_MatType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SizeDetectionData>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SizeDetectionData>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SizeDetectionData>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SizeDetectionData>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SizeDetectionData>()
                .Property(e => e.FC_Machine)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SizeDetectionData>()
                .Property(e => e.FC_TestData)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SizeDetectionData>()
                .Property(e => e.FC_TestResult)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_PID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_Line)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_MachineNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_MachineTable)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_Track)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_Group)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_Plant)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_MatPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_MatDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_Location)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetDetail>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_ASYM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_ProgrameName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_ModelName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_Date)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_PCBANo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_Version)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_PreparedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_ApprovedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SMTMatSetM>()
                .Property(e => e.FC_PID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm5)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm6)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm7)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm8)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm9)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm10)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm11)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm12)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm13)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm14)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm15)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm16)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm17)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm18)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm19)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm20)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm21)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm22)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm23)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm24)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm25)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm26)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm27)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm28)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm29)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm30)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm31)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm32)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm33)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm34)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm35)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm36)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm37)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm38)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm39)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm40)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm41)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm42)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm43)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm44)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm45)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm46)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm47)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm48)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm49)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm50)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm51)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm52)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm53)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm54)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm55)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm56)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm57)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm58)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm59)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm60)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm61)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm62)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm63)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm64)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm65)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm66)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm67)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm68)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm69)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Parm70)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Machine)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Text1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Text2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Text3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Text4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Text5)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNData>()
                .Property(e => e.FC_Text6)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_SID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_LineID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_WorkID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_SFCCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_Status)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_NGCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_UDF02)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_UDF03)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_UDF04)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_UDF05)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FN_UDF51)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FN_UDF52)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FN_UDF53)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FN_UDF54)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FN_UDF55)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SNPLog>()
                .Property(e => e.FC_MaterialID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SPIAOIData>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SPIAOIData>()
                .Property(e => e.FC_FPCNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SPIAOIData>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SPIAOIData>()
                .Property(e => e.FC_PositionNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SPIAOIData>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SPIAOIData>()
                .Property(e => e.FC_EquipNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SPIAOIData>()
                .Property(e => e.TestResult)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StockInfo>()
                .Property(e => e.FC_ChgID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StockInfo>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StockInfo>()
                .Property(e => e.FC_ChgType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StockInfo>()
                .Property(e => e.FC_BillNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_WarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_TranNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_WarType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_PType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_NGCodeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_PSNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_Units)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_SONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_ERPPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_RetFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_WKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_Stocks>()
                .Property(e => e.FC_NGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveD>()
                .Property(e => e.FC_StoreRemoveDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveD>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveD>()
                .Property(e => e.FC_StoreRemoveNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveD>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveD>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_StoreRemoveNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_OutType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_MesWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_ERPWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_SubMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_ERPUpdFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreRemoveM>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_StoreScrapD>()
                .Property(e => e.FC_ScrapDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapD>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapD>()
                .Property(e => e.FC_ScrapNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapD>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapD>()
                .Property(e => e.TB__FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapD>()
                .Property(e => e.FC_NGCodeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FC_ScrapNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FC_ScrapType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FC_SubMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_StoreScrapM>()
                .HasMany(e => e.TB_Prd_StoreScrapSND)
                .WithRequired(e => e.TB_Prd_StoreScrapM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Prd_StoreScrapSND>()
                .Property(e => e.FC_ScrapSNNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapSND>()
                .Property(e => e.FC_ScrapNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapSND>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapSND>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapSND>()
                .Property(e => e.FC_UDF02)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapSND>()
                .Property(e => e.FC_UDF03)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapSND>()
                .Property(e => e.FC_UDF04)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_StoreScrapSND>()
                .Property(e => e.FC_UDF05)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ThawingAndDeaerate>()
                .Property(e => e.FC_BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ThawingAndDeaerate>()
                .Property(e => e.FC_OpreType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_ThawingAndDeaerate>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_TranNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_SID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_ProcWK)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_ChkMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_BCType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_RecManFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_RecMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_ERPBGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_ERPBGCount)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_PWType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_SplitFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_TranTypeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_NeedBG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .Property(e => e.FC_MacNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .HasMany(e => e.TB_Prd_ProcMans)
                .WithRequired(e => e.TB_Prd_TranInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Prd_TranInfo>()
                .HasMany(e => e.TB_Prd_TranNGInfo)
                .WithRequired(e => e.TB_Prd_TranInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Prd_TranInfoLog>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfoLog>()
                .Property(e => e.FC_TranNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfoLog>()
                .Property(e => e.FC_ERPPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfoLog>()
                .Property(e => e.FC_Message)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranInfoLog>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranMac>()
                .Property(e => e.FC_TMacID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranMac>()
                .Property(e => e.FC_TranNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranMac>()
                .Property(e => e.FC_MacID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranMac>()
                .Property(e => e.FC_ProcMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranNGInfo>()
                .Property(e => e.FC_NGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranNGInfo>()
                .Property(e => e.FC_TranNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranNGInfo>()
                .Property(e => e.FC_CodeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranNGInfo>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranNGInfo>()
                .Property(e => e.FC_ChkMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranNGInfo>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranNGInfo>()
                .Property(e => e.FC_NGGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranPPar>()
                .Property(e => e.FC_TranParID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranPPar>()
                .Property(e => e.FC_TranNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranPPar>()
                .Property(e => e.FC_PSID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranSNNGInfo>()
                .Property(e => e.FC_SNNGNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranSNNGInfo>()
                .Property(e => e.FC_PONO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranSNNGInfo>()
                .Property(e => e.FC_Batch)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranSNNGInfo>()
                .Property(e => e.FC_NGNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranSNNGInfo>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranSNNGInfo>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranSNNGInfo>()
                .Property(e => e.FC_PSOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_TranSNNGInfo>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnBindSNLog>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnBindSNLog>()
                .Property(e => e.FC_FuseID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnBindSNLog>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnBindSNLog>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnLockSNOrSensorID>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnLockSNOrSensorID>()
                .Property(e => e.FC_SensorID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnLockSNOrSensorID>()
                .Property(e => e.FC_LockReason)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnLockSNOrSensorID>()
                .Property(e => e.FC_CUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnLockSNOrSensorID>()
                .Property(e => e.FC_PsCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UnLockSNOrSensorID>()
                .Property(e => e.FC_UnLockCUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_PONO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_FC_AJPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_UseMatMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_UseFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_PNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_Spec)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_FC_AJPName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UseAdjMat>()
                .Property(e => e.FC_FBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FN_SumQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FN_GoodQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FN_NGQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FN_RepairtQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FN_RepeatQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FN_StanderOfflineQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FD_CDate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FC_PoNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_UserUPHReport>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatD>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatD>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatD>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatD>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatD>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatD>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatD>()
                .Property(e => e.FN_ThrowingRate)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Pub_BalanceMatD>()
                .Property(e => e.FN_SingleDosage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Pub_BalanceMatD>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatM>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatM>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatM>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatM>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_BalanceMatM>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_CurrentReciveMat>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_CurrentReciveMat>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_CurrentReciveMat>()
                .Property(e => e.FC_MatDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_CurrentReciveMat>()
                .Property(e => e.FN_ActualIssue)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Pub_DictDetail>()
                .Property(e => e.FC_CatCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictDetail>()
                .Property(e => e.FC_ItemValue)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictDetail>()
                .Property(e => e.FC_ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictDetail>()
                .Property(e => e.FC_ItemValue2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictDetail>()
                .Property(e => e.FC_ItemValue3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictDetail>()
                .Property(e => e.FC_ItemValue4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictDetail>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictDetail>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictDetail>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_DictMaster>()
                .Property(e => e.FC_CatCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictMaster>()
                .Property(e => e.FC_CatName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictMaster>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictMaster>()
                .Property(e => e.FC_Bak)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictMaster>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictMaster>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictMaster>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_DictMaster>()
                .Property(e => e.FC_Parent)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_DictMaster>()
                .HasMany(e => e.TB_Pub_DictDetail)
                .WithRequired(e => e.TB_Pub_DictMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_WKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_ERPFactory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_SoftwareVer)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_PSName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Line)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Space)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Space2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Space3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Space4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Space5)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Machines>()
                .Property(e => e.FC_Space6)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatCon>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatCon>()
                .Property(e => e.FC_Code)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatCon>()
                .Property(e => e.FC_Enabled)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatCon>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatCon>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatCon>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_SNDID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_Value)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_ValueType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_CodeType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_FillChar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_Upper)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListD>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListM>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListM>()
                .Property(e => e.FC_SNType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListM>()
                .Property(e => e.FC_SQL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListM>()
                .Property(e => e.FC_Enable)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListM>()
                .Property(e => e.FC_Bak)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListM>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatListM>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatRec>()
                .Property(e => e.FC_Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatRec>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatRec>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatUseRec>()
                .Property(e => e.FC_UseID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatUseRec>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_MatUseRec>()
                .Property(e => e.FN_GetNum)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Pub_MatUseRec>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGClass>()
                .Property(e => e.FC_ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGClass>()
                .Property(e => e.FC_Parent)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGClass>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGClass>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGClass>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGClass>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGClass>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_CodeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_Code)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_ERPCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_RetFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_SFCCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGCodes>()
                .Property(e => e.FC_NGCodeNer)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGGroup>()
                .Property(e => e.FC_GroupNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGGroup>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGGroup>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGGroup>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_NGGroup>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_PoParNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_DictNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_Ext1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_Ext2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_Ext3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_POPars>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_POPars>()
                .HasMany(e => e.TB_Prd_POPars)
                .WithRequired(e => e.TB_Pub_POPars)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatD>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatD>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatD>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatD>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatD>()
                .Property(e => e.FC_Position)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatD>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatD>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatD>()
                .Property(e => e.FC_Line)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatM>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatM>()
                .Property(e => e.FC_UUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatM>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PreventErrorMatM>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcClass>()
                .Property(e => e.FC_ClassNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcClass>()
                .Property(e => e.FC_Parent)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcClass>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcClass>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcClass>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcClass>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcClass>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_Id)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_PSNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_MacID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_EmpCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_EmpName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FN_Value1)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FN_Value2)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FN_Value3)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FN_Value4)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FN_Value5)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FN_Value6)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_Value7)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_Value8)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_Value9)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_Value10)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcMans>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcPriceCount>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcPriceCount>()
                .Property(e => e.FC_PSNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcPriceCount>()
                .Property(e => e.FC_Remarks1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcPriceCount>()
                .Property(e => e.FC_Remarks2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcPriceCount>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcProdAbility>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcProdAbility>()
                .Property(e => e.FC_PSNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcProdAbility>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcProdAbility>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcProdAbility>()
                .Property(e => e.FC_Remarks1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcProdAbility>()
                .Property(e => e.FC_Remarks2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_PSNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_ClassNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_Code)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_ProcType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_DefWKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_PWType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_TranType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .Property(e => e.FC_AutoType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSetup>()
                .HasMany(e => e.TB_Pub_PSWK)
                .WithRequired(e => e.TB_Pub_ProcSetup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Pub_ProcSPs>()
                .Property(e => e.FC_PSID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSPs>()
                .Property(e => e.FC_PSNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ProcSPs>()
                .Property(e => e.FC_MustCon)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PSWK>()
                .Property(e => e.FC_DID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PSWK>()
                .Property(e => e.FC_PSNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PSWK>()
                .Property(e => e.FC_WKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PWarehouse>()
                .Property(e => e.FC_WarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PWarehouse>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PWarehouse>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PWarehouse>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PWarehouse>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PWarehouse>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PWarehouse>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PWarehouse>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_PWarehouse>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_QCParms>()
                .Property(e => e.FC_CheckNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_QCParms>()
                .Property(e => e.FC_CheckType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_QCParms>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_QCParms>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_QCParms>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_QCParms>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_QCParms>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_MatDuc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_MatTranType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_MatNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_InventoryLocation)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_MatBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FN_Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_ErpNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_BomRowNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_ReversalVoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_PostingNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_PostingDocumentDes)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FN_ActualIssue)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_MatDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_MatType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_ReciveMat>()
                .Property(e => e.FC_MatGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_No)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_WKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ProcType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FN_StdProcTime)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_BGType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_TranTypeNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ERPCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ERPWC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ERPPTNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ERPBG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_TSType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ConMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ConMPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ConPPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ConLabPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ConPCSPar)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ScanIDT1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ScanIDT2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ScanIDT3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_CurrPSControlCondition)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_PrePSControlCondition)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_SoftVersion)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanD>()
                .Property(e => e.FC_ReleaseDeviceFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanM>()
                .Property(e => e.FC_No)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanM>()
                .Property(e => e.FC_ClassNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanM>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanM>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanM>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RoutingPlanM>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_RPlanType>()
                .Property(e => e.FC_ClassNO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RPlanType>()
                .Property(e => e.FC_Parent)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RPlanType>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RPlanType>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RPlanType>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RPlanType>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_RPlanType>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_SNDID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_Value)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_ValueType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_CodeType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_FillChar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_Upper)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListD>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListM>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListM>()
                .Property(e => e.FC_SNType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListM>()
                .Property(e => e.FC_SQL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListM>()
                .Property(e => e.FC_Enable)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListM>()
                .Property(e => e.FC_Bak)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListM>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListM>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNListM>()
                .HasMany(e => e.TB_Pub_SNRec)
                .WithRequired(e => e.TB_Pub_SNListM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Pub_SNRec>()
                .Property(e => e.FC_Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNRec>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNRec>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNUseRec>()
                .Property(e => e.FC_UseID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNUseRec>()
                .Property(e => e.FC_SNID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_SNUseRec>()
                .Property(e => e.FN_GetNum)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Pub_SNUseRec>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Storage>()
                .Property(e => e.FC_StorageNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Storage>()
                .Property(e => e.FC_WarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictDetail>()
                .Property(e => e.FC_CatCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictDetail>()
                .Property(e => e.FC_ItemValue)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictDetail>()
                .Property(e => e.FC_ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictDetail>()
                .Property(e => e.FC_ItemValue1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictDetail>()
                .Property(e => e.FC_ItemValue2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictDetail>()
                .Property(e => e.FC_ItemValue3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictDetail>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictDetail>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictDetail>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_UserDictMaster>()
                .Property(e => e.FC_CatCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictMaster>()
                .Property(e => e.FC_CatName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictMaster>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictMaster>()
                .Property(e => e.FC_Bak)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictMaster>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictMaster>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_UserDictMaster>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_UserDictMaster>()
                .Property(e => e.FC_Parent)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WarClass>()
                .Property(e => e.FC_ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WarClass>()
                .Property(e => e.FC_Parent)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WarClass>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WarClass>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WarClass>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WarClass>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WarClass>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FC_WarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FC_ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_Warehouse>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_WCClass>()
                .Property(e => e.FC_ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WCClass>()
                .Property(e => e.FC_Parent)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WCClass>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WCClass>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WCClass>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WCClass>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WCClass>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_WCQCParms>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WCQCParms>()
                .Property(e => e.FC_WKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WCQCParms>()
                .Property(e => e.FC_CheckNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_WKNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_WarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_WKType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_DeptID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_ERPFactory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_ERPNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Pub_WorkCenter>()
                .HasMany(e => e.TB_Pub_PSWK)
                .WithRequired(e => e.TB_Pub_WorkCenter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_QC_OQCAQL>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCAQL>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCAQL>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCAQL>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCAQL>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCAQL>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_WorkCenter)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_SendMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_SendShap)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_CheckType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_BoxNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheck>()
                .Property(e => e.FC_ChkNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheckNG>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheckNG>()
                .Property(e => e.FC_NgID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheckNG>()
                .Property(e => e.FC_Code)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_OQCCheckNG>()
                .Property(e => e.FC_NgGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .Property(e => e.FC_PId)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_QC_RPCPlan>()
                .HasMany(e => e.TB_QC_SPCRec)
                .WithRequired(e => e.TB_QC_RPCPlan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_QC_SPCPlanD>()
                .Property(e => e.FC_PItemId)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCPlanD>()
                .Property(e => e.FC_PId)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCPlanD>()
                .Property(e => e.FC_CheckNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCPlanD>()
                .Property(e => e.FN_GCCK)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_QC_SPCPlanD>()
                .Property(e => e.FN_SPC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_QC_SPCPlanD>()
                .Property(e => e.FN_XPC)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_QC_SPCPlanD>()
                .Property(e => e.FN_JXZ)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_QC_SPCPlanD>()
                .Property(e => e.FN_ZJZ)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_QC_SPCPlanD>()
                .Property(e => e.FN_JDZ)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_QC_SPCRec>()
                .Property(e => e.FC_PDId)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCRec>()
                .Property(e => e.FC_PId)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCRec>()
                .Property(e => e.FC_ChkID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCRec>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCRec>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCRec>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCRec>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_QC_SPCRecD>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCRecD>()
                .Property(e => e.FC_PDId)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCRecD>()
                .Property(e => e.FC_CheckNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_QC_SPCRecD>()
                .Property(e => e.FN_CheckValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_SAPNGCodes>()
                .Property(e => e.CODEGRUPPE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SAPNGCodes>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SAPNGCodes>()
                .Property(e => e.KURZTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Detail>()
                .Property(e => e.FC_TableName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Detail>()
                .Property(e => e.FC_ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Detail>()
                .Property(e => e.FC_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Detail>()
                .Property(e => e.FC_Value)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Detail>()
                .Property(e => e.FC_FillChar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Detail>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Detail>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Master>()
                .Property(e => e.FC_TableName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Master>()
                .Property(e => e.FC_ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Master>()
                .Property(e => e.FC_Bak)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Master>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Master>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Master>()
                .HasMany(e => e.TB_SYS_AutoNo_Detail)
                .WithRequired(e => e.TB_SYS_AutoNo_Master)
                .HasForeignKey(e => new { e.FC_TableName, e.FC_ColumnName })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Master>()
                .HasMany(e => e.TB_SYS_AutoNo_Rec)
                .WithRequired(e => e.TB_SYS_AutoNo_Master)
                .HasForeignKey(e => new { e.FC_TableName, e.FC_ColumnName })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Rec>()
                .Property(e => e.FC_TableName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Rec>()
                .Property(e => e.FC_ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Rec>()
                .Property(e => e.FC_Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Rec>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_AutoNo_Rec>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_Config>()
                .Property(e => e.FC_CoinfigID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_Config>()
                .Property(e => e.FC_Bak)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_Config>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_Config>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_Config>()
                .HasMany(e => e.TB_SYS_ConfigDetail)
                .WithRequired(e => e.TB_SYS_Config)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SYS_ConfigDetail>()
                .Property(e => e.FC_CoinfigID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_ConfigDetail>()
                .Property(e => e.FC_Code)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_ConfigDetail>()
                .Property(e => e.FC_Name)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_ConfigDetail>()
                .Property(e => e.FC_Value)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_ConfigDetail>()
                .Property(e => e.FC_Bak)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_ExceptionLog>()
                .Property(e => e.FN_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Sys_ExceptionLog>()
                .Property(e => e.FC_Sender)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_ExceptionLog>()
                .Property(e => e.FC_Message)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_ExceptionLog>()
                .Property(e => e.FC_Call)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_ExceptionLog>()
                .Property(e => e.FC_Source)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_ExceptionLog>()
                .Property(e => e.FC_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_ExceptionLog>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_ExceptionLog>()
                .Property(e => e.FC_UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_ExceptionLog>()
                .Property(e => e.FC_ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_Log>()
                .Property(e => e.FN_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TB_Sys_Log>()
                .Property(e => e.FC_ModuleID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_Log>()
                .Property(e => e.FC_FuncCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_Log>()
                .Property(e => e.FC_OprNote)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_Log>()
                .Property(e => e.FC_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_Log>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_Log>()
                .Property(e => e.FC_UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sys_Log>()
                .Property(e => e.FC_ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_System>()
                .Property(e => e.SystemID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_System>()
                .Property(e => e.FC_ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_System>()
                .Property(e => e.SystemName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_System>()
                .Property(e => e.UpdateUrl)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_System>()
                .Property(e => e.CurrVer)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_System>()
                .Property(e => e.FC_LogUser)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_System>()
                .Property(e => e.FC_LogUserPwd)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_System>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_System>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_HRID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_Password)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_PasswordType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_AllowData)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_AllowData2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_AllowData3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_AllowData4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_AllowData5)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_Ext1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_Ext2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .Property(e => e.FC_Ext3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SYS_UserInfo>()
                .HasMany(e => e.TB_Web_UserRoles)
                .WithRequired(e => e.TB_SYS_UserInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_ChkID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_PackType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_FMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ChkLab>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_INNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_MesWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_ERPWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_SubMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_ERPUpdFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_RLFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInput>()
                .Property(e => e.FC_ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_INNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_PSID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_ERPOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_ERPBGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_ERPBGCount)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputBG>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_WarDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_INNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_PVer)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_BatchCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_SONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_ERPPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputD>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputLab>()
                .Property(e => e.FC_LID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputLab>()
                .Property(e => e.FC_INNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputLab>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_ERPInputLab>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_INNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_MesWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_ERPWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_SubMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_ERPUpdFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInput>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_INNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_PSID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_ERPOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_ERPBGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_ERPBGCount)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputBG>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_WarDNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_INNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_PVer)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_BatchCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_SONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_ERPPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_NGERPInputD>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackB>()
                .Property(e => e.FC_BID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackB>()
                .Property(e => e.FC_LowLabID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackB>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackB>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_LowLabID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_LowPID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_BoxID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_WeiUnit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_ParentID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_ChkFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FD_ChkMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_ChkID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackLab>()
                .Property(e => e.FC_ChkRemark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_LowPID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_PackType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_InputType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_FMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_PackM>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcD>()
                .Property(e => e.FC_EXNoD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcD>()
                .Property(e => e.FC_ExNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcD>()
                .Property(e => e.FD_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcD>()
                .Property(e => e.FC_StockD)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcD>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcD>()
                .Property(e => e.FC_Shape)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcD>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcM>()
                .Property(e => e.FC_ExNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcM>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcM>()
                .Property(e => e.FC_OutWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcM>()
                .Property(e => e.FC_InWarNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcM>()
                .Property(e => e.FC_SubMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcM>()
                .Property(e => e.FC_Flag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcM>()
                .Property(e => e.FC_Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcM>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_War_StoreExcM>()
                .Property(e => e.FC_CMan)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FC_ModuleID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FC_FuncCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FC_Ext1)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FC_Ext2)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FC_Ext3)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FC_Ext4)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .Property(e => e.FC_Ext5)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleDetail>()
                .HasMany(e => e.TB_Web_RolesDetail)
                .WithRequired(e => e.TB_Web_ModuleDetail)
                .HasForeignKey(e => new { e.FC_ModuleID, e.FC_FuncCode })
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<TB_Web_ModuleDetail>()
            //    .HasMany(e => e.TB_SYS_UserInfo)
            //    .WithMany(e => e.TB_Web_ModuleDetail)
            //    .Map(m => m.ToTable("TB_Web_UserOprs").MapLeftKey(new[] { "FC_ModuleID", "FC_FuncCode" }).MapRightKey("FC_UserID"));

            modelBuilder.Entity<TB_Web_ModuleMaster>()
                .Property(e => e.FC_ModuleID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleMaster>()
                .Property(e => e.FC_ParentID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleMaster>()
                .Property(e => e.FC_Dicts)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleMaster>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleMaster>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleMaster>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_Web_ModuleMaster>()
                .Property(e => e.FC_ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleMaster>()
                .Property(e => e.FC_Command)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_ModuleMaster>()
                .HasMany(e => e.TB_Web_ModuleDetail)
                .WithRequired(e => e.TB_Web_ModuleMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Web_RolesDetail>()
                .Property(e => e.FC_ModuleID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesDetail>()
                .Property(e => e.FC_FuncCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesDetail>()
                .Property(e => e.FC_RoleID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesDetail>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesDetail>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesDetail>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_Web_RolesMaster>()
                .Property(e => e.FC_RoleID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesMaster>()
                .Property(e => e.FC_RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesMaster>()
                .Property(e => e.FC_Bak)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesMaster>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesMaster>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_RolesMaster>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_Web_RolesMaster>()
                .HasMany(e => e.TB_Web_RolesDetail)
                .WithRequired(e => e.TB_Web_RolesMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Web_RolesMaster>()
                .HasMany(e => e.TB_Web_UserRoles)
                .WithRequired(e => e.TB_Web_RolesMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_Web_UserRoles>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_UserRoles>()
                .Property(e => e.FC_RoleID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_UserRoles>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_UserRoles>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Web_UserRoles>()
                .Property(e => e.FD_Version)
                .IsFixedLength();

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_SID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_WCent)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_Line)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_PO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_POBatch)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_PNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_Status)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_UDF02)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_UDF03)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_UDF04)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_UDF05)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FN_UDF51)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FN_UDF52)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FN_UDF53)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FN_UDF54)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FN_UDF55)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatch>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FN_SID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FC_Status)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FC_SID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FC_StopDeptID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FC_UDF02)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FC_UDF03)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FC_UDF04)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FC_UDF05)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FN_UDF51)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FN_UDF52)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FN_UDF53)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FN_UDF54)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FN_UDF55)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatchLog>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FN_SID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FC_Type)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FC_Item)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FC_BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FC_UDF02)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FC_UDF03)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FC_UDF04)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FC_UDF05)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FN_UDF51)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FN_UDF52)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FN_UDF53)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FN_UDF54)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_POBatchMats>()
                .Property(e => e.FN_UDF55)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_UDF01)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_UDF02)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_UDF03)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_UDF04)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_UDF05)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FN_UDF51)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FN_UDF52)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FN_UDF53)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FN_UDF54)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FN_UDF55)
                .HasPrecision(12, 2);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WIP_StopInfo>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NgStoreRW>()
                .Property(e => e.FC_NgStoreRWNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NgStoreRW>()
                .Property(e => e.FC_PONO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NgStoreRW>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NgStoreRW>()
                .Property(e => e.FC_PSID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NgStoreRW>()
                .Property(e => e.FC_ERPOrder)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NgStoreRW>()
                .Property(e => e.FC_ERPBGNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_NgStoreRW>()
                .Property(e => e.FC_ERPBGCount)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_PONo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_BatchCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_Unit)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_CurrPS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_CurrPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_ERPBCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_BFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_Factory)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_HisFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_RowFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_CUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_UUserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FD_Ver)
                .IsFixedLength();

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_BCType)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_TCID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_BackNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_PSCodeID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_CurrBPS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_CurrBPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FN_ERPBNo)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_MatFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_SplitFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_OldBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_SplitPS)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_SplitPSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_BPrtFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_POBatch_20220607>()
                .Property(e => e.FC_BatchMat)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SnNgInfo>()
                .Property(e => e.FC_SN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SnNgInfo>()
                .Property(e => e.FC_PackSN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SnNgInfo>()
                .Property(e => e.FC_PSCode)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SnNgInfo>()
                .Property(e => e.FC_UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SnNgInfo>()
                .Property(e => e.FC_NgMsg)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SnNgInfo>()
                .Property(e => e.FC_MachineNo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Prd_SnNgInfo>()
                .Property(e => e.FC_Sharp)
                .IsUnicode(false);
        }
    }
}
