namespace sophis.scenario
{
    public enum eMProcessingType
    {
        M_pScenario = 0,

        M_pManagerPreference = 1,

        M_pUserPreference = 2,
        
        M_pInstrument = 3,

        M_pCounterparty = 4,

        M_pPortfolio = 5,

        M_pBeforeEndOfDayProcedure = 6,

        M_pAfterEndOfDayProcedure = 7,

        M_pNightBatch = 8,

        M_pBeforeReporting = 9,

        M_pAfterReporting = 10,

        M_pMarketDate = 11,

        M_pData = 12,

        M_pEndOfDayConditional = 13,

        M_pAfterAllInitialisation = 14,

        M_pOther = 15,

        M_pMultiSiteEODBeforePortfolioLoading = 16,

        M_pAccounting = 17,

        M_pBalaceEngineBeforePnL = 18,

        M_pBalanceEngineAfterPnL = 19,

        M_pPNLEngine = 20,

        M_pAuxiliaryLedger = 21,

        M_pSendToGL = 22,

        M_pTradeEngineEndOfDay = 23,

        M_pTradeShootAgain = 24,

        M_pPreForecast = 25,

        M_pPostForecast = 26,

        M_pAfterForecastInit = 27
    }
}
