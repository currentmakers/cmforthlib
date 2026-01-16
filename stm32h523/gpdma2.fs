\
\ @file gpdma2.fs
\ @brief GPDMA2 channel7 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPDMA secure configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_SECCFGR_SEC0                        \ secure state of channel x
$00000002 constant GPDMA2_GPDMA_SECCFGR_SEC1                        \ secure state of channel x
$00000004 constant GPDMA2_GPDMA_SECCFGR_SEC2                        \ secure state of channel x
$00000008 constant GPDMA2_GPDMA_SECCFGR_SEC3                        \ secure state of channel x
$00000010 constant GPDMA2_GPDMA_SECCFGR_SEC4                        \ secure state of channel x
$00000020 constant GPDMA2_GPDMA_SECCFGR_SEC5                        \ secure state of channel x
$00000040 constant GPDMA2_GPDMA_SECCFGR_SEC6                        \ secure state of channel x
$00000080 constant GPDMA2_GPDMA_SECCFGR_SEC7                        \ secure state of channel x


\
\ @brief GPDMA privileged configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_PRIVCFGR_PRIV0                      \ privileged state of channel x
$00000002 constant GPDMA2_GPDMA_PRIVCFGR_PRIV1                      \ privileged state of channel x
$00000004 constant GPDMA2_GPDMA_PRIVCFGR_PRIV2                      \ privileged state of channel x
$00000008 constant GPDMA2_GPDMA_PRIVCFGR_PRIV3                      \ privileged state of channel x
$00000010 constant GPDMA2_GPDMA_PRIVCFGR_PRIV4                      \ privileged state of channel x
$00000020 constant GPDMA2_GPDMA_PRIVCFGR_PRIV5                      \ privileged state of channel x
$00000040 constant GPDMA2_GPDMA_PRIVCFGR_PRIV6                      \ privileged state of channel x
$00000080 constant GPDMA2_GPDMA_PRIVCFGR_PRIV7                      \ privileged state of channel x


\
\ @brief GPDMA configuration lock register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_RCFGLOCKR_LOCK0                     \ lock the configuration of GPDMA_SECCFGR.
$00000002 constant GPDMA2_GPDMA_RCFGLOCKR_LOCK1                     \ lock the configuration of GPDMA_SECCFGR.
$00000004 constant GPDMA2_GPDMA_RCFGLOCKR_LOCK2                     \ lock the configuration of GPDMA_SECCFGR.
$00000008 constant GPDMA2_GPDMA_RCFGLOCKR_LOCK3                     \ lock the configuration of GPDMA_SECCFGR.
$00000010 constant GPDMA2_GPDMA_RCFGLOCKR_LOCK4                     \ lock the configuration of GPDMA_SECCFGR.
$00000020 constant GPDMA2_GPDMA_RCFGLOCKR_LOCK5                     \ lock the configuration of GPDMA_SECCFGR.
$00000040 constant GPDMA2_GPDMA_RCFGLOCKR_LOCK6                     \ lock the configuration of GPDMA_SECCFGR.
$00000080 constant GPDMA2_GPDMA_RCFGLOCKR_LOCK7                     \ lock the configuration of GPDMA_SECCFGR.


\
\ @brief GPDMA nonsecure masked interrupt status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_MISR_MIS0                           \ masked interrupt status of channel x
$00000002 constant GPDMA2_GPDMA_MISR_MIS1                           \ masked interrupt status of channel x
$00000004 constant GPDMA2_GPDMA_MISR_MIS2                           \ masked interrupt status of channel x
$00000008 constant GPDMA2_GPDMA_MISR_MIS3                           \ masked interrupt status of channel x
$00000010 constant GPDMA2_GPDMA_MISR_MIS4                           \ masked interrupt status of channel x
$00000020 constant GPDMA2_GPDMA_MISR_MIS5                           \ masked interrupt status of channel x
$00000040 constant GPDMA2_GPDMA_MISR_MIS6                           \ masked interrupt status of channel x
$00000080 constant GPDMA2_GPDMA_MISR_MIS7                           \ masked interrupt status of channel x


\
\ @brief GPDMA secure masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_SMISR_MIS0                          \ masked interrupt status of the secure channel x
$00000002 constant GPDMA2_GPDMA_SMISR_MIS1                          \ masked interrupt status of the secure channel x
$00000004 constant GPDMA2_GPDMA_SMISR_MIS2                          \ masked interrupt status of the secure channel x
$00000008 constant GPDMA2_GPDMA_SMISR_MIS3                          \ masked interrupt status of the secure channel x
$00000010 constant GPDMA2_GPDMA_SMISR_MIS4                          \ masked interrupt status of the secure channel x
$00000020 constant GPDMA2_GPDMA_SMISR_MIS5                          \ masked interrupt status of the secure channel x
$00000040 constant GPDMA2_GPDMA_SMISR_MIS6                          \ masked interrupt status of the secure channel x
$00000080 constant GPDMA2_GPDMA_SMISR_MIS7                          \ masked interrupt status of the secure channel x


\
\ @brief GPDMA channel 0 linked-list base address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA2_GPDMA_C0LBAR_LBA                          \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 0 flag clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA2_GPDMA_C0FCR_TCF                           \ transfer complete flag clear
$00000200 constant GPDMA2_GPDMA_C0FCR_HTF                           \ half transfer flag clear
$00000400 constant GPDMA2_GPDMA_C0FCR_DTEF                          \ data transfer error flag clear
$00000800 constant GPDMA2_GPDMA_C0FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant GPDMA2_GPDMA_C0FCR_USEF                          \ user setting error flag clear
$00002000 constant GPDMA2_GPDMA_C0FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant GPDMA2_GPDMA_C0FCR_TOF                           \ trigger overrun flag clear


\
\ @brief GPDMA channel 0 status register
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant GPDMA2_GPDMA_C0SR_IDLEF                          \ idle flag
$00000100 constant GPDMA2_GPDMA_C0SR_TCF                            \ transfer complete flag
$00000200 constant GPDMA2_GPDMA_C0SR_HTF                            \ half transfer flag
$00000400 constant GPDMA2_GPDMA_C0SR_DTEF                           \ data transfer error flag
$00000800 constant GPDMA2_GPDMA_C0SR_ULEF                           \ update link transfer error flag
$00001000 constant GPDMA2_GPDMA_C0SR_USEF                           \ user setting error flag
$00002000 constant GPDMA2_GPDMA_C0SR_SUSPF                          \ completed suspension flag
$00004000 constant GPDMA2_GPDMA_C0SR_TOF                            \ trigger overrun flag
$00ff0000 constant GPDMA2_GPDMA_C0SR_FIFOL                          \ monitored FIFO level


\
\ @brief GPDMA channel 0 control register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_C0CR_EN                             \ enable
$00000002 constant GPDMA2_GPDMA_C0CR_RESET                          \ reset
$00000004 constant GPDMA2_GPDMA_C0CR_SUSP                           \ suspend
$00000100 constant GPDMA2_GPDMA_C0CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant GPDMA2_GPDMA_C0CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant GPDMA2_GPDMA_C0CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant GPDMA2_GPDMA_C0CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant GPDMA2_GPDMA_C0CR_USEIE                          \ user setting error interrupt enable
$00002000 constant GPDMA2_GPDMA_C0CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant GPDMA2_GPDMA_C0CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant GPDMA2_GPDMA_C0CR_LSM                            \ Link step mode
$00020000 constant GPDMA2_GPDMA_C0CR_LAP                            \ linked-list allocated port
$00c00000 constant GPDMA2_GPDMA_C0CR_PRIO                           \ priority level of the channel x GPDMA transfer versus others


\
\ @brief GPDMA channel 0 transfer register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000003 constant GPDMA2_GPDMA_C0TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst in bytes
$00000008 constant GPDMA2_GPDMA_C0TR1_SINC                          \ source incrementing burst
$000003f0 constant GPDMA2_GPDMA_C0TR1_SBL_1                         \ source burst length minus 1, between 0 and 63
$00001800 constant GPDMA2_GPDMA_C0TR1_PAM                           \ padding/alignment mode
$00002000 constant GPDMA2_GPDMA_C0TR1_SBX                           \ source byte exchange within the unaligned half-word of each source word
$00004000 constant GPDMA2_GPDMA_C0TR1_SAP                           \ source allocated port
$00008000 constant GPDMA2_GPDMA_C0TR1_SSEC                          \ security attribute of the GPDMA transfer from the source
$00030000 constant GPDMA2_GPDMA_C0TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant GPDMA2_GPDMA_C0TR1_DINC                          \ destination incrementing burst
$03f00000 constant GPDMA2_GPDMA_C0TR1_DBL_1                         \ destination burst length minus 1, between 0 and 63
$04000000 constant GPDMA2_GPDMA_C0TR1_DBX                           \ destination byte exchange
$08000000 constant GPDMA2_GPDMA_C0TR1_DHX                           \ destination half-word exchange
$40000000 constant GPDMA2_GPDMA_C0TR1_DAP                           \ destination allocated port
$80000000 constant GPDMA2_GPDMA_C0TR1_DSEC                          \ security attribute of the GPDMA transfer to the destination


\
\ @brief GPDMA channel 0 transfer register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$000000ff constant GPDMA2_GPDMA_C0TR2_REQSEL                        \ GPDMA hardware request selection
$00000200 constant GPDMA2_GPDMA_C0TR2_SWREQ                         \ software request
$00000400 constant GPDMA2_GPDMA_C0TR2_DREQ                          \ destination hardware request
$00000800 constant GPDMA2_GPDMA_C0TR2_BREQ                          \ Block hardware request
$00001000 constant GPDMA2_GPDMA_C0TR2_PFREQ                         \ Hardware request in peripheral flow control mode
$0000c000 constant GPDMA2_GPDMA_C0TR2_TRIGM                         \ trigger mode
$003f0000 constant GPDMA2_GPDMA_C0TR2_TRIGSEL                       \ trigger event input selection
$03000000 constant GPDMA2_GPDMA_C0TR2_TRIGPOL                       \ trigger event polarity
$c0000000 constant GPDMA2_GPDMA_C0TR2_TCEM                          \ transfer complete event mode


\
\ @brief GPDMA channel 0 block register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C0BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel 0 source address register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C0SAR_SA                            \ source address


\
\ @brief GPDMA channel 0 destination address register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C0DAR_DA                            \ destination address


\
\ @brief GPDMA channel 0 linked-list address register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA2_GPDMA_C0LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant GPDMA2_GPDMA_C0LLR_ULL                           \ Update GPDMA_CxLLR register from memory
$08000000 constant GPDMA2_GPDMA_C0LLR_UDA                           \ Update GPDMA_CxDAR register from memory
$10000000 constant GPDMA2_GPDMA_C0LLR_USA                           \ update GPDMA_CxSAR from memory
$20000000 constant GPDMA2_GPDMA_C0LLR_UB1                           \ Update GPDMA_CxBR1 from memory
$40000000 constant GPDMA2_GPDMA_C0LLR_UT2                           \ Update GPDMA_CxTR2 from memory
$80000000 constant GPDMA2_GPDMA_C0LLR_UT1                           \ Update GPDMA_CxTR1 from memory


\
\ @brief GPDMA channel 1 linked-list base address register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA2_GPDMA_C1LBAR_LBA                          \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 1 flag clear register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA2_GPDMA_C1FCR_TCF                           \ transfer complete flag clear
$00000200 constant GPDMA2_GPDMA_C1FCR_HTF                           \ half transfer flag clear
$00000400 constant GPDMA2_GPDMA_C1FCR_DTEF                          \ data transfer error flag clear
$00000800 constant GPDMA2_GPDMA_C1FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant GPDMA2_GPDMA_C1FCR_USEF                          \ user setting error flag clear
$00002000 constant GPDMA2_GPDMA_C1FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant GPDMA2_GPDMA_C1FCR_TOF                           \ trigger overrun flag clear


\
\ @brief GPDMA channel 1 status register
\ Address offset: 0xE0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA2_GPDMA_C1SR_IDLEF                          \ idle flag
$00000100 constant GPDMA2_GPDMA_C1SR_TCF                            \ transfer complete flag
$00000200 constant GPDMA2_GPDMA_C1SR_HTF                            \ half transfer flag
$00000400 constant GPDMA2_GPDMA_C1SR_DTEF                           \ data transfer error flag
$00000800 constant GPDMA2_GPDMA_C1SR_ULEF                           \ update link transfer error flag
$00001000 constant GPDMA2_GPDMA_C1SR_USEF                           \ user setting error flag
$00002000 constant GPDMA2_GPDMA_C1SR_SUSPF                          \ completed suspension flag
$00004000 constant GPDMA2_GPDMA_C1SR_TOF                            \ trigger overrun flag
$00ff0000 constant GPDMA2_GPDMA_C1SR_FIFOL                          \ monitored FIFO level


\
\ @brief GPDMA channel 1 control register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_C1CR_EN                             \ enable
$00000002 constant GPDMA2_GPDMA_C1CR_RESET                          \ reset
$00000004 constant GPDMA2_GPDMA_C1CR_SUSP                           \ suspend
$00000100 constant GPDMA2_GPDMA_C1CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant GPDMA2_GPDMA_C1CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant GPDMA2_GPDMA_C1CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant GPDMA2_GPDMA_C1CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant GPDMA2_GPDMA_C1CR_USEIE                          \ user setting error interrupt enable
$00002000 constant GPDMA2_GPDMA_C1CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant GPDMA2_GPDMA_C1CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant GPDMA2_GPDMA_C1CR_LSM                            \ Link step mode
$00020000 constant GPDMA2_GPDMA_C1CR_LAP                            \ linked-list allocated port
$00c00000 constant GPDMA2_GPDMA_C1CR_PRIO                           \ priority level of the channel x GPDMA transfer versus others


\
\ @brief GPDMA channel 1 transfer register 1
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000003 constant GPDMA2_GPDMA_C1TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst in bytes
$00000008 constant GPDMA2_GPDMA_C1TR1_SINC                          \ source incrementing burst
$000003f0 constant GPDMA2_GPDMA_C1TR1_SBL_1                         \ source burst length minus 1, between 0 and 63
$00001800 constant GPDMA2_GPDMA_C1TR1_PAM                           \ padding/alignment mode
$00002000 constant GPDMA2_GPDMA_C1TR1_SBX                           \ source byte exchange within the unaligned half-word of each source word
$00004000 constant GPDMA2_GPDMA_C1TR1_SAP                           \ source allocated port
$00008000 constant GPDMA2_GPDMA_C1TR1_SSEC                          \ security attribute of the GPDMA transfer from the source
$00030000 constant GPDMA2_GPDMA_C1TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant GPDMA2_GPDMA_C1TR1_DINC                          \ destination incrementing burst
$03f00000 constant GPDMA2_GPDMA_C1TR1_DBL_1                         \ destination burst length minus 1, between 0 and 63
$04000000 constant GPDMA2_GPDMA_C1TR1_DBX                           \ destination byte exchange
$08000000 constant GPDMA2_GPDMA_C1TR1_DHX                           \ destination half-word exchange
$40000000 constant GPDMA2_GPDMA_C1TR1_DAP                           \ destination allocated port
$80000000 constant GPDMA2_GPDMA_C1TR1_DSEC                          \ security attribute of the GPDMA transfer to the destination


\
\ @brief GPDMA channel 1 transfer register 2
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant GPDMA2_GPDMA_C1TR2_REQSEL                        \ GPDMA hardware request selection
$00000200 constant GPDMA2_GPDMA_C1TR2_SWREQ                         \ software request
$00000400 constant GPDMA2_GPDMA_C1TR2_DREQ                          \ destination hardware request
$00000800 constant GPDMA2_GPDMA_C1TR2_BREQ                          \ Block hardware request
$00001000 constant GPDMA2_GPDMA_C1TR2_PFREQ                         \ Hardware request in peripheral flow control mode
$0000c000 constant GPDMA2_GPDMA_C1TR2_TRIGM                         \ trigger mode
$003f0000 constant GPDMA2_GPDMA_C1TR2_TRIGSEL                       \ trigger event input selection
$03000000 constant GPDMA2_GPDMA_C1TR2_TRIGPOL                       \ trigger event polarity
$c0000000 constant GPDMA2_GPDMA_C1TR2_TCEM                          \ transfer complete event mode


\
\ @brief GPDMA channel 1 block register 1
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C1BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel 1 source address register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C1SAR_SA                            \ source address


\
\ @brief GPDMA channel 1 destination address register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C1DAR_DA                            \ destination address


\
\ @brief GPDMA channel 1 linked-list address register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA2_GPDMA_C1LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant GPDMA2_GPDMA_C1LLR_ULL                           \ Update GPDMA_CxLLR register from memory
$08000000 constant GPDMA2_GPDMA_C1LLR_UDA                           \ Update GPDMA_CxDAR register from memory
$10000000 constant GPDMA2_GPDMA_C1LLR_USA                           \ update GPDMA_CxSAR from memory
$20000000 constant GPDMA2_GPDMA_C1LLR_UB1                           \ Update GPDMA_CxBR1 from memory
$40000000 constant GPDMA2_GPDMA_C1LLR_UT2                           \ Update GPDMA_CxTR2 from memory
$80000000 constant GPDMA2_GPDMA_C1LLR_UT1                           \ Update GPDMA_CxTR1 from memory


\
\ @brief GPDMA channel 2 linked-list base address register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA2_GPDMA_C2LBAR_LBA                          \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 2 flag clear register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA2_GPDMA_C2FCR_TCF                           \ transfer complete flag clear
$00000200 constant GPDMA2_GPDMA_C2FCR_HTF                           \ half transfer flag clear
$00000400 constant GPDMA2_GPDMA_C2FCR_DTEF                          \ data transfer error flag clear
$00000800 constant GPDMA2_GPDMA_C2FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant GPDMA2_GPDMA_C2FCR_USEF                          \ user setting error flag clear
$00002000 constant GPDMA2_GPDMA_C2FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant GPDMA2_GPDMA_C2FCR_TOF                           \ trigger overrun flag clear


\
\ @brief GPDMA channel 2 status register
\ Address offset: 0x160
\ Reset value: 0x00000001
\

$00000001 constant GPDMA2_GPDMA_C2SR_IDLEF                          \ idle flag
$00000100 constant GPDMA2_GPDMA_C2SR_TCF                            \ transfer complete flag
$00000200 constant GPDMA2_GPDMA_C2SR_HTF                            \ half transfer flag
$00000400 constant GPDMA2_GPDMA_C2SR_DTEF                           \ data transfer error flag
$00000800 constant GPDMA2_GPDMA_C2SR_ULEF                           \ update link transfer error flag
$00001000 constant GPDMA2_GPDMA_C2SR_USEF                           \ user setting error flag
$00002000 constant GPDMA2_GPDMA_C2SR_SUSPF                          \ completed suspension flag
$00004000 constant GPDMA2_GPDMA_C2SR_TOF                            \ trigger overrun flag
$00ff0000 constant GPDMA2_GPDMA_C2SR_FIFOL                          \ monitored FIFO level


\
\ @brief GPDMA channel 2 control register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_C2CR_EN                             \ enable
$00000002 constant GPDMA2_GPDMA_C2CR_RESET                          \ reset
$00000004 constant GPDMA2_GPDMA_C2CR_SUSP                           \ suspend
$00000100 constant GPDMA2_GPDMA_C2CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant GPDMA2_GPDMA_C2CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant GPDMA2_GPDMA_C2CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant GPDMA2_GPDMA_C2CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant GPDMA2_GPDMA_C2CR_USEIE                          \ user setting error interrupt enable
$00002000 constant GPDMA2_GPDMA_C2CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant GPDMA2_GPDMA_C2CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant GPDMA2_GPDMA_C2CR_LSM                            \ Link step mode
$00020000 constant GPDMA2_GPDMA_C2CR_LAP                            \ linked-list allocated port
$00c00000 constant GPDMA2_GPDMA_C2CR_PRIO                           \ priority level of the channel x GPDMA transfer versus others


\
\ @brief GPDMA channel 2 transfer register 1
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000003 constant GPDMA2_GPDMA_C2TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst in bytes
$00000008 constant GPDMA2_GPDMA_C2TR1_SINC                          \ source incrementing burst
$000003f0 constant GPDMA2_GPDMA_C2TR1_SBL_1                         \ source burst length minus 1, between 0 and 63
$00001800 constant GPDMA2_GPDMA_C2TR1_PAM                           \ padding/alignment mode
$00002000 constant GPDMA2_GPDMA_C2TR1_SBX                           \ source byte exchange within the unaligned half-word of each source word
$00004000 constant GPDMA2_GPDMA_C2TR1_SAP                           \ source allocated port
$00008000 constant GPDMA2_GPDMA_C2TR1_SSEC                          \ security attribute of the GPDMA transfer from the source
$00030000 constant GPDMA2_GPDMA_C2TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant GPDMA2_GPDMA_C2TR1_DINC                          \ destination incrementing burst
$03f00000 constant GPDMA2_GPDMA_C2TR1_DBL_1                         \ destination burst length minus 1, between 0 and 63
$04000000 constant GPDMA2_GPDMA_C2TR1_DBX                           \ destination byte exchange
$08000000 constant GPDMA2_GPDMA_C2TR1_DHX                           \ destination half-word exchange
$40000000 constant GPDMA2_GPDMA_C2TR1_DAP                           \ destination allocated port
$80000000 constant GPDMA2_GPDMA_C2TR1_DSEC                          \ security attribute of the GPDMA transfer to the destination


\
\ @brief GPDMA channel 2 transfer register 2
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000000ff constant GPDMA2_GPDMA_C2TR2_REQSEL                        \ GPDMA hardware request selection
$00000200 constant GPDMA2_GPDMA_C2TR2_SWREQ                         \ software request
$00000400 constant GPDMA2_GPDMA_C2TR2_DREQ                          \ destination hardware request
$00000800 constant GPDMA2_GPDMA_C2TR2_BREQ                          \ Block hardware request
$00001000 constant GPDMA2_GPDMA_C2TR2_PFREQ                         \ Hardware request in peripheral flow control mode
$0000c000 constant GPDMA2_GPDMA_C2TR2_TRIGM                         \ trigger mode
$003f0000 constant GPDMA2_GPDMA_C2TR2_TRIGSEL                       \ trigger event input selection
$03000000 constant GPDMA2_GPDMA_C2TR2_TRIGPOL                       \ trigger event polarity
$c0000000 constant GPDMA2_GPDMA_C2TR2_TCEM                          \ transfer complete event mode


\
\ @brief GPDMA channel 2 block register 1
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C2BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel 2 source address register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C2SAR_SA                            \ source address


\
\ @brief GPDMA channel 2 destination address register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C2DAR_DA                            \ destination address


\
\ @brief GPDMA channel 2 linked-list address register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA2_GPDMA_C2LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant GPDMA2_GPDMA_C2LLR_ULL                           \ Update GPDMA_CxLLR register from memory
$08000000 constant GPDMA2_GPDMA_C2LLR_UDA                           \ Update GPDMA_CxDAR register from memory
$10000000 constant GPDMA2_GPDMA_C2LLR_USA                           \ update GPDMA_CxSAR from memory
$20000000 constant GPDMA2_GPDMA_C2LLR_UB1                           \ Update GPDMA_CxBR1 from memory
$40000000 constant GPDMA2_GPDMA_C2LLR_UT2                           \ Update GPDMA_CxTR2 from memory
$80000000 constant GPDMA2_GPDMA_C2LLR_UT1                           \ Update GPDMA_CxTR1 from memory


\
\ @brief GPDMA channel 3 linked-list base address register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA2_GPDMA_C3LBAR_LBA                          \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 3 flag clear register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA2_GPDMA_C3FCR_TCF                           \ transfer complete flag clear
$00000200 constant GPDMA2_GPDMA_C3FCR_HTF                           \ half transfer flag clear
$00000400 constant GPDMA2_GPDMA_C3FCR_DTEF                          \ data transfer error flag clear
$00000800 constant GPDMA2_GPDMA_C3FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant GPDMA2_GPDMA_C3FCR_USEF                          \ user setting error flag clear
$00002000 constant GPDMA2_GPDMA_C3FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant GPDMA2_GPDMA_C3FCR_TOF                           \ trigger overrun flag clear


\
\ @brief GPDMA channel 3 status register
\ Address offset: 0x1E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA2_GPDMA_C3SR_IDLEF                          \ idle flag
$00000100 constant GPDMA2_GPDMA_C3SR_TCF                            \ transfer complete flag
$00000200 constant GPDMA2_GPDMA_C3SR_HTF                            \ half transfer flag
$00000400 constant GPDMA2_GPDMA_C3SR_DTEF                           \ data transfer error flag
$00000800 constant GPDMA2_GPDMA_C3SR_ULEF                           \ update link transfer error flag
$00001000 constant GPDMA2_GPDMA_C3SR_USEF                           \ user setting error flag
$00002000 constant GPDMA2_GPDMA_C3SR_SUSPF                          \ completed suspension flag
$00004000 constant GPDMA2_GPDMA_C3SR_TOF                            \ trigger overrun flag
$00ff0000 constant GPDMA2_GPDMA_C3SR_FIFOL                          \ monitored FIFO level


\
\ @brief GPDMA channel 3 control register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_C3CR_EN                             \ enable
$00000002 constant GPDMA2_GPDMA_C3CR_RESET                          \ reset
$00000004 constant GPDMA2_GPDMA_C3CR_SUSP                           \ suspend
$00000100 constant GPDMA2_GPDMA_C3CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant GPDMA2_GPDMA_C3CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant GPDMA2_GPDMA_C3CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant GPDMA2_GPDMA_C3CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant GPDMA2_GPDMA_C3CR_USEIE                          \ user setting error interrupt enable
$00002000 constant GPDMA2_GPDMA_C3CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant GPDMA2_GPDMA_C3CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant GPDMA2_GPDMA_C3CR_LSM                            \ Link step mode
$00020000 constant GPDMA2_GPDMA_C3CR_LAP                            \ linked-list allocated port
$00c00000 constant GPDMA2_GPDMA_C3CR_PRIO                           \ priority level of the channel x GPDMA transfer versus others


\
\ @brief GPDMA channel 3 transfer register 1
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000003 constant GPDMA2_GPDMA_C3TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst in bytes
$00000008 constant GPDMA2_GPDMA_C3TR1_SINC                          \ source incrementing burst
$000003f0 constant GPDMA2_GPDMA_C3TR1_SBL_1                         \ source burst length minus 1, between 0 and 63
$00001800 constant GPDMA2_GPDMA_C3TR1_PAM                           \ padding/alignment mode
$00002000 constant GPDMA2_GPDMA_C3TR1_SBX                           \ source byte exchange within the unaligned half-word of each source word
$00004000 constant GPDMA2_GPDMA_C3TR1_SAP                           \ source allocated port
$00008000 constant GPDMA2_GPDMA_C3TR1_SSEC                          \ security attribute of the GPDMA transfer from the source
$00030000 constant GPDMA2_GPDMA_C3TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant GPDMA2_GPDMA_C3TR1_DINC                          \ destination incrementing burst
$03f00000 constant GPDMA2_GPDMA_C3TR1_DBL_1                         \ destination burst length minus 1, between 0 and 63
$04000000 constant GPDMA2_GPDMA_C3TR1_DBX                           \ destination byte exchange
$08000000 constant GPDMA2_GPDMA_C3TR1_DHX                           \ destination half-word exchange
$40000000 constant GPDMA2_GPDMA_C3TR1_DAP                           \ destination allocated port
$80000000 constant GPDMA2_GPDMA_C3TR1_DSEC                          \ security attribute of the GPDMA transfer to the destination


\
\ @brief GPDMA channel 3 transfer register 2
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant GPDMA2_GPDMA_C3TR2_REQSEL                        \ GPDMA hardware request selection
$00000200 constant GPDMA2_GPDMA_C3TR2_SWREQ                         \ software request
$00000400 constant GPDMA2_GPDMA_C3TR2_DREQ                          \ destination hardware request
$00000800 constant GPDMA2_GPDMA_C3TR2_BREQ                          \ Block hardware request
$00001000 constant GPDMA2_GPDMA_C3TR2_PFREQ                         \ Hardware request in peripheral flow control mode
$0000c000 constant GPDMA2_GPDMA_C3TR2_TRIGM                         \ trigger mode
$003f0000 constant GPDMA2_GPDMA_C3TR2_TRIGSEL                       \ trigger event input selection
$03000000 constant GPDMA2_GPDMA_C3TR2_TRIGPOL                       \ trigger event polarity
$c0000000 constant GPDMA2_GPDMA_C3TR2_TCEM                          \ transfer complete event mode


\
\ @brief GPDMA channel 3 block register 1
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C3BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel 3 source address register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C3SAR_SA                            \ source address


\
\ @brief GPDMA channel 3 destination address register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C3DAR_DA                            \ destination address


\
\ @brief GPDMA channel 3 linked-list address register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA2_GPDMA_C3LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant GPDMA2_GPDMA_C3LLR_ULL                           \ Update GPDMA_CxLLR register from memory
$08000000 constant GPDMA2_GPDMA_C3LLR_UDA                           \ Update GPDMA_CxDAR register from memory
$10000000 constant GPDMA2_GPDMA_C3LLR_USA                           \ update GPDMA_CxSAR from memory
$20000000 constant GPDMA2_GPDMA_C3LLR_UB1                           \ Update GPDMA_CxBR1 from memory
$40000000 constant GPDMA2_GPDMA_C3LLR_UT2                           \ Update GPDMA_CxTR2 from memory
$80000000 constant GPDMA2_GPDMA_C3LLR_UT1                           \ Update GPDMA_CxTR1 from memory


\
\ @brief GPDMA channel 4 linked-list base address register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA2_GPDMA_C4LBAR_LBA                          \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 4 flag clear register
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA2_GPDMA_C4FCR_TCF                           \ transfer complete flag clear
$00000200 constant GPDMA2_GPDMA_C4FCR_HTF                           \ half transfer flag clear
$00000400 constant GPDMA2_GPDMA_C4FCR_DTEF                          \ data transfer error flag clear
$00000800 constant GPDMA2_GPDMA_C4FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant GPDMA2_GPDMA_C4FCR_USEF                          \ user setting error flag clear
$00002000 constant GPDMA2_GPDMA_C4FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant GPDMA2_GPDMA_C4FCR_TOF                           \ trigger overrun flag clear


\
\ @brief GPDMA channel 4 status register
\ Address offset: 0x260
\ Reset value: 0x00000001
\

$00000001 constant GPDMA2_GPDMA_C4SR_IDLEF                          \ idle flag
$00000100 constant GPDMA2_GPDMA_C4SR_TCF                            \ transfer complete flag
$00000200 constant GPDMA2_GPDMA_C4SR_HTF                            \ half transfer flag
$00000400 constant GPDMA2_GPDMA_C4SR_DTEF                           \ data transfer error flag
$00000800 constant GPDMA2_GPDMA_C4SR_ULEF                           \ update link transfer error flag
$00001000 constant GPDMA2_GPDMA_C4SR_USEF                           \ user setting error flag
$00002000 constant GPDMA2_GPDMA_C4SR_SUSPF                          \ completed suspension flag
$00004000 constant GPDMA2_GPDMA_C4SR_TOF                            \ trigger overrun flag
$00ff0000 constant GPDMA2_GPDMA_C4SR_FIFOL                          \ monitored FIFO level


\
\ @brief GPDMA channel 4 control register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_C4CR_EN                             \ enable
$00000002 constant GPDMA2_GPDMA_C4CR_RESET                          \ reset
$00000004 constant GPDMA2_GPDMA_C4CR_SUSP                           \ suspend
$00000100 constant GPDMA2_GPDMA_C4CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant GPDMA2_GPDMA_C4CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant GPDMA2_GPDMA_C4CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant GPDMA2_GPDMA_C4CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant GPDMA2_GPDMA_C4CR_USEIE                          \ user setting error interrupt enable
$00002000 constant GPDMA2_GPDMA_C4CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant GPDMA2_GPDMA_C4CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant GPDMA2_GPDMA_C4CR_LSM                            \ Link step mode
$00020000 constant GPDMA2_GPDMA_C4CR_LAP                            \ linked-list allocated port
$00c00000 constant GPDMA2_GPDMA_C4CR_PRIO                           \ priority level of the channel x GPDMA transfer versus others


\
\ @brief GPDMA channel 4 transfer register 1
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000003 constant GPDMA2_GPDMA_C4TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst in bytes
$00000008 constant GPDMA2_GPDMA_C4TR1_SINC                          \ source incrementing burst
$000003f0 constant GPDMA2_GPDMA_C4TR1_SBL_1                         \ source burst length minus 1, between 0 and 63
$00001800 constant GPDMA2_GPDMA_C4TR1_PAM                           \ padding/alignment mode
$00002000 constant GPDMA2_GPDMA_C4TR1_SBX                           \ source byte exchange within the unaligned half-word of each source word
$00004000 constant GPDMA2_GPDMA_C4TR1_SAP                           \ source allocated port
$00008000 constant GPDMA2_GPDMA_C4TR1_SSEC                          \ security attribute of the GPDMA transfer from the source
$00030000 constant GPDMA2_GPDMA_C4TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant GPDMA2_GPDMA_C4TR1_DINC                          \ destination incrementing burst
$03f00000 constant GPDMA2_GPDMA_C4TR1_DBL_1                         \ destination burst length minus 1, between 0 and 63
$04000000 constant GPDMA2_GPDMA_C4TR1_DBX                           \ destination byte exchange
$08000000 constant GPDMA2_GPDMA_C4TR1_DHX                           \ destination half-word exchange
$40000000 constant GPDMA2_GPDMA_C4TR1_DAP                           \ destination allocated port
$80000000 constant GPDMA2_GPDMA_C4TR1_DSEC                          \ security attribute of the GPDMA transfer to the destination


\
\ @brief GPDMA channel 4 transfer register 2
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$000000ff constant GPDMA2_GPDMA_C4TR2_REQSEL                        \ GPDMA hardware request selection
$00000200 constant GPDMA2_GPDMA_C4TR2_SWREQ                         \ software request
$00000400 constant GPDMA2_GPDMA_C4TR2_DREQ                          \ destination hardware request
$00000800 constant GPDMA2_GPDMA_C4TR2_BREQ                          \ Block hardware request
$00001000 constant GPDMA2_GPDMA_C4TR2_PFREQ                         \ Hardware request in peripheral flow control mode
$0000c000 constant GPDMA2_GPDMA_C4TR2_TRIGM                         \ trigger mode
$003f0000 constant GPDMA2_GPDMA_C4TR2_TRIGSEL                       \ trigger event input selection
$03000000 constant GPDMA2_GPDMA_C4TR2_TRIGPOL                       \ trigger event polarity
$c0000000 constant GPDMA2_GPDMA_C4TR2_TCEM                          \ transfer complete event mode


\
\ @brief GPDMA channel 4 block register 1
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C4BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel 4 source address register
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C4SAR_SA                            \ source address


\
\ @brief GPDMA channel 4 destination address register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C4DAR_DA                            \ destination address


\
\ @brief GPDMA channel 4 linked-list address register
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA2_GPDMA_C4LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant GPDMA2_GPDMA_C4LLR_ULL                           \ Update GPDMA_CxLLR register from memory
$08000000 constant GPDMA2_GPDMA_C4LLR_UDA                           \ Update GPDMA_CxDAR register from memory
$10000000 constant GPDMA2_GPDMA_C4LLR_USA                           \ update GPDMA_CxSAR from memory
$20000000 constant GPDMA2_GPDMA_C4LLR_UB1                           \ Update GPDMA_CxBR1 from memory
$40000000 constant GPDMA2_GPDMA_C4LLR_UT2                           \ Update GPDMA_CxTR2 from memory
$80000000 constant GPDMA2_GPDMA_C4LLR_UT1                           \ Update GPDMA_CxTR1 from memory


\
\ @brief GPDMA channel 5 linked-list base address register
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA2_GPDMA_C5LBAR_LBA                          \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 5 flag clear register
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA2_GPDMA_C5FCR_TCF                           \ transfer complete flag clear
$00000200 constant GPDMA2_GPDMA_C5FCR_HTF                           \ half transfer flag clear
$00000400 constant GPDMA2_GPDMA_C5FCR_DTEF                          \ data transfer error flag clear
$00000800 constant GPDMA2_GPDMA_C5FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant GPDMA2_GPDMA_C5FCR_USEF                          \ user setting error flag clear
$00002000 constant GPDMA2_GPDMA_C5FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant GPDMA2_GPDMA_C5FCR_TOF                           \ trigger overrun flag clear


\
\ @brief GPDMA channel 5 status register
\ Address offset: 0x2E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA2_GPDMA_C5SR_IDLEF                          \ idle flag
$00000100 constant GPDMA2_GPDMA_C5SR_TCF                            \ transfer complete flag
$00000200 constant GPDMA2_GPDMA_C5SR_HTF                            \ half transfer flag
$00000400 constant GPDMA2_GPDMA_C5SR_DTEF                           \ data transfer error flag
$00000800 constant GPDMA2_GPDMA_C5SR_ULEF                           \ update link transfer error flag
$00001000 constant GPDMA2_GPDMA_C5SR_USEF                           \ user setting error flag
$00002000 constant GPDMA2_GPDMA_C5SR_SUSPF                          \ completed suspension flag
$00004000 constant GPDMA2_GPDMA_C5SR_TOF                            \ trigger overrun flag
$00ff0000 constant GPDMA2_GPDMA_C5SR_FIFOL                          \ monitored FIFO level


\
\ @brief GPDMA channel 5 control register
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_C5CR_EN                             \ enable
$00000002 constant GPDMA2_GPDMA_C5CR_RESET                          \ reset
$00000004 constant GPDMA2_GPDMA_C5CR_SUSP                           \ suspend
$00000100 constant GPDMA2_GPDMA_C5CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant GPDMA2_GPDMA_C5CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant GPDMA2_GPDMA_C5CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant GPDMA2_GPDMA_C5CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant GPDMA2_GPDMA_C5CR_USEIE                          \ user setting error interrupt enable
$00002000 constant GPDMA2_GPDMA_C5CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant GPDMA2_GPDMA_C5CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant GPDMA2_GPDMA_C5CR_LSM                            \ Link step mode
$00020000 constant GPDMA2_GPDMA_C5CR_LAP                            \ linked-list allocated port
$00c00000 constant GPDMA2_GPDMA_C5CR_PRIO                           \ priority level of the channel x GPDMA transfer versus others


\
\ @brief GPDMA channel 5 transfer register 1
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000003 constant GPDMA2_GPDMA_C5TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst in bytes
$00000008 constant GPDMA2_GPDMA_C5TR1_SINC                          \ source incrementing burst
$000003f0 constant GPDMA2_GPDMA_C5TR1_SBL_1                         \ source burst length minus 1, between 0 and 63
$00001800 constant GPDMA2_GPDMA_C5TR1_PAM                           \ padding/alignment mode
$00002000 constant GPDMA2_GPDMA_C5TR1_SBX                           \ source byte exchange within the unaligned half-word of each source word
$00004000 constant GPDMA2_GPDMA_C5TR1_SAP                           \ source allocated port
$00008000 constant GPDMA2_GPDMA_C5TR1_SSEC                          \ security attribute of the GPDMA transfer from the source
$00030000 constant GPDMA2_GPDMA_C5TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant GPDMA2_GPDMA_C5TR1_DINC                          \ destination incrementing burst
$03f00000 constant GPDMA2_GPDMA_C5TR1_DBL_1                         \ destination burst length minus 1, between 0 and 63
$04000000 constant GPDMA2_GPDMA_C5TR1_DBX                           \ destination byte exchange
$08000000 constant GPDMA2_GPDMA_C5TR1_DHX                           \ destination half-word exchange
$40000000 constant GPDMA2_GPDMA_C5TR1_DAP                           \ destination allocated port
$80000000 constant GPDMA2_GPDMA_C5TR1_DSEC                          \ security attribute of the GPDMA transfer to the destination


\
\ @brief GPDMA channel 5 transfer register 2
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000ff constant GPDMA2_GPDMA_C5TR2_REQSEL                        \ GPDMA hardware request selection
$00000200 constant GPDMA2_GPDMA_C5TR2_SWREQ                         \ software request
$00000400 constant GPDMA2_GPDMA_C5TR2_DREQ                          \ destination hardware request
$00000800 constant GPDMA2_GPDMA_C5TR2_BREQ                          \ Block hardware request
$00001000 constant GPDMA2_GPDMA_C5TR2_PFREQ                         \ Hardware request in peripheral flow control mode
$0000c000 constant GPDMA2_GPDMA_C5TR2_TRIGM                         \ trigger mode
$003f0000 constant GPDMA2_GPDMA_C5TR2_TRIGSEL                       \ trigger event input selection
$03000000 constant GPDMA2_GPDMA_C5TR2_TRIGPOL                       \ trigger event polarity
$c0000000 constant GPDMA2_GPDMA_C5TR2_TCEM                          \ transfer complete event mode


\
\ @brief GPDMA channel 5 block register 1
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C5BR1_BNDT                          \ block number of data bytes to transfer from the source


\
\ @brief GPDMA channel 5 source address register
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C5SAR_SA                            \ source address


\
\ @brief GPDMA channel 5 destination address register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C5DAR_DA                            \ destination address


\
\ @brief GPDMA channel 5 linked-list address register
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA2_GPDMA_C5LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant GPDMA2_GPDMA_C5LLR_ULL                           \ Update GPDMA_CxLLR register from memory
$08000000 constant GPDMA2_GPDMA_C5LLR_UDA                           \ Update GPDMA_CxDAR register from memory
$10000000 constant GPDMA2_GPDMA_C5LLR_USA                           \ update GPDMA_CxSAR from memory
$20000000 constant GPDMA2_GPDMA_C5LLR_UB1                           \ Update GPDMA_CxBR1 from memory
$40000000 constant GPDMA2_GPDMA_C5LLR_UT2                           \ Update GPDMA_CxTR2 from memory
$80000000 constant GPDMA2_GPDMA_C5LLR_UT1                           \ Update GPDMA_CxTR1 from memory


\
\ @brief GPDMA channel 6 linked-list base address register
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA2_GPDMA_C6LBAR_LBA                          \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 6 flag clear register
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000100 constant GPDMA2_GPDMA_C6FCR_TCF                           \ transfer complete flag clear
$00000200 constant GPDMA2_GPDMA_C6FCR_HTF                           \ half transfer flag clear
$00000400 constant GPDMA2_GPDMA_C6FCR_DTEF                          \ data transfer error flag clear
$00000800 constant GPDMA2_GPDMA_C6FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant GPDMA2_GPDMA_C6FCR_USEF                          \ user setting error flag clear
$00002000 constant GPDMA2_GPDMA_C6FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant GPDMA2_GPDMA_C6FCR_TOF                           \ trigger overrun flag clear


\
\ @brief GPDMA channel 6 status register
\ Address offset: 0x360
\ Reset value: 0x00000001
\

$00000001 constant GPDMA2_GPDMA_C6SR_IDLEF                          \ idle flag
$00000100 constant GPDMA2_GPDMA_C6SR_TCF                            \ transfer complete flag
$00000200 constant GPDMA2_GPDMA_C6SR_HTF                            \ half transfer flag
$00000400 constant GPDMA2_GPDMA_C6SR_DTEF                           \ data transfer error flag
$00000800 constant GPDMA2_GPDMA_C6SR_ULEF                           \ update link transfer error flag
$00001000 constant GPDMA2_GPDMA_C6SR_USEF                           \ user setting error flag
$00002000 constant GPDMA2_GPDMA_C6SR_SUSPF                          \ completed suspension flag
$00004000 constant GPDMA2_GPDMA_C6SR_TOF                            \ trigger overrun flag
$00ff0000 constant GPDMA2_GPDMA_C6SR_FIFOL                          \ monitored FIFO level


\
\ @brief GPDMA channel 6 control register
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_C6CR_EN                             \ enable
$00000002 constant GPDMA2_GPDMA_C6CR_RESET                          \ reset
$00000004 constant GPDMA2_GPDMA_C6CR_SUSP                           \ suspend
$00000100 constant GPDMA2_GPDMA_C6CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant GPDMA2_GPDMA_C6CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant GPDMA2_GPDMA_C6CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant GPDMA2_GPDMA_C6CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant GPDMA2_GPDMA_C6CR_USEIE                          \ user setting error interrupt enable
$00002000 constant GPDMA2_GPDMA_C6CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant GPDMA2_GPDMA_C6CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant GPDMA2_GPDMA_C6CR_LSM                            \ Link step mode
$00020000 constant GPDMA2_GPDMA_C6CR_LAP                            \ linked-list allocated port
$00c00000 constant GPDMA2_GPDMA_C6CR_PRIO                           \ priority level of the channel x GPDMA transfer versus others


\
\ @brief GPDMA channel 6 transfer register 1
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000003 constant GPDMA2_GPDMA_C6TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst in bytes
$00000008 constant GPDMA2_GPDMA_C6TR1_SINC                          \ source incrementing burst
$000003f0 constant GPDMA2_GPDMA_C6TR1_SBL_1                         \ source burst length minus 1, between 0 and 63
$00001800 constant GPDMA2_GPDMA_C6TR1_PAM                           \ padding/alignment mode
$00002000 constant GPDMA2_GPDMA_C6TR1_SBX                           \ source byte exchange within the unaligned half-word of each source word
$00004000 constant GPDMA2_GPDMA_C6TR1_SAP                           \ source allocated port
$00008000 constant GPDMA2_GPDMA_C6TR1_SSEC                          \ security attribute of the GPDMA transfer from the source
$00030000 constant GPDMA2_GPDMA_C6TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant GPDMA2_GPDMA_C6TR1_DINC                          \ destination incrementing burst
$03f00000 constant GPDMA2_GPDMA_C6TR1_DBL_1                         \ destination burst length minus 1, between 0 and 63
$04000000 constant GPDMA2_GPDMA_C6TR1_DBX                           \ destination byte exchange
$08000000 constant GPDMA2_GPDMA_C6TR1_DHX                           \ destination half-word exchange
$40000000 constant GPDMA2_GPDMA_C6TR1_DAP                           \ destination allocated port
$80000000 constant GPDMA2_GPDMA_C6TR1_DSEC                          \ security attribute of the GPDMA transfer to the destination


\
\ @brief GPDMA channel 6 transfer register 2
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$000000ff constant GPDMA2_GPDMA_C6TR2_REQSEL                        \ GPDMA hardware request selection
$00000200 constant GPDMA2_GPDMA_C6TR2_SWREQ                         \ software request
$00000400 constant GPDMA2_GPDMA_C6TR2_DREQ                          \ destination hardware request
$00000800 constant GPDMA2_GPDMA_C6TR2_BREQ                          \ Block hardware request
$00001000 constant GPDMA2_GPDMA_C6TR2_PFREQ                         \ Hardware request in peripheral flow control mode
$0000c000 constant GPDMA2_GPDMA_C6TR2_TRIGM                         \ trigger mode
$003f0000 constant GPDMA2_GPDMA_C6TR2_TRIGSEL                       \ trigger event input selection
$03000000 constant GPDMA2_GPDMA_C6TR2_TRIGPOL                       \ trigger event polarity
$c0000000 constant GPDMA2_GPDMA_C6TR2_TCEM                          \ transfer complete event mode


\
\ @brief GPDMA channel 6 alternate block register 1
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C6BR1_BNDT                          \ block number of data bytes to transfer from the source
$07ff0000 constant GPDMA2_GPDMA_C6BR1_BRC                           \ Block repeat counter
$10000000 constant GPDMA2_GPDMA_C6BR1_SDEC                          \ source address decrement
$20000000 constant GPDMA2_GPDMA_C6BR1_DDEC                          \ destination address decrement
$40000000 constant GPDMA2_GPDMA_C6BR1_BRSDEC                        \ Block repeat source address decrement
$80000000 constant GPDMA2_GPDMA_C6BR1_BRDDEC                        \ Block repeat destination address decrement


\
\ @brief GPDMA channel 6 source address register
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C6SAR_SA                            \ source address


\
\ @brief GPDMA channel 6 destination address register
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C6DAR_DA                            \ destination address


\
\ @brief GPDMA channel 6 transfer register 3
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$00001fff constant GPDMA2_GPDMA_C6TR3_SAO                           \ source address offset increment
$1fff0000 constant GPDMA2_GPDMA_C6TR3_DAO                           \ destination address offset increment


\
\ @brief GPDMA channel 6 block register 2
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C6BR2_BRSAO                         \ Block repeated source address offset
$ffff0000 constant GPDMA2_GPDMA_C6BR2_BRDAO                         \ Block repeated destination address offset


\
\ @brief GPDMA channel 6 alternate linked-list address register
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA2_GPDMA_C6LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant GPDMA2_GPDMA_C6LLR_ULL                           \ Update GPDMA_CxLLR register from memory
$02000000 constant GPDMA2_GPDMA_C6LLR_UB2                           \ Update GPDMA_CxBR2 from memory
$04000000 constant GPDMA2_GPDMA_C6LLR_UT3                           \ Update GPDMA_CxTR3 from memory
$08000000 constant GPDMA2_GPDMA_C6LLR_UDA                           \ Update GPDMA_CxDAR register from memory
$10000000 constant GPDMA2_GPDMA_C6LLR_USA                           \ update GPDMA_CxSAR from memory
$20000000 constant GPDMA2_GPDMA_C6LLR_UB1                           \ Update GPDMA_CxBR1 from memory
$40000000 constant GPDMA2_GPDMA_C6LLR_UT2                           \ Update GPDMA_CxTR2 from memory
$80000000 constant GPDMA2_GPDMA_C6LLR_UT1                           \ Update GPDMA_CxTR1 from memory


\
\ @brief GPDMA channel 7 linked-list base address register
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$ffff0000 constant GPDMA2_GPDMA_C7LBAR_LBA                          \ linked-list base address of GPDMA channel x


\
\ @brief GPDMA channel 7 flag clear register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000100 constant GPDMA2_GPDMA_C7FCR_TCF                           \ transfer complete flag clear
$00000200 constant GPDMA2_GPDMA_C7FCR_HTF                           \ half transfer flag clear
$00000400 constant GPDMA2_GPDMA_C7FCR_DTEF                          \ data transfer error flag clear
$00000800 constant GPDMA2_GPDMA_C7FCR_ULEF                          \ update link transfer error flag clear
$00001000 constant GPDMA2_GPDMA_C7FCR_USEF                          \ user setting error flag clear
$00002000 constant GPDMA2_GPDMA_C7FCR_SUSPF                         \ completed suspension flag clear
$00004000 constant GPDMA2_GPDMA_C7FCR_TOF                           \ trigger overrun flag clear


\
\ @brief GPDMA channel 7 status register
\ Address offset: 0x3E0
\ Reset value: 0x00000001
\

$00000001 constant GPDMA2_GPDMA_C7SR_IDLEF                          \ idle flag
$00000100 constant GPDMA2_GPDMA_C7SR_TCF                            \ transfer complete flag
$00000200 constant GPDMA2_GPDMA_C7SR_HTF                            \ half transfer flag
$00000400 constant GPDMA2_GPDMA_C7SR_DTEF                           \ data transfer error flag
$00000800 constant GPDMA2_GPDMA_C7SR_ULEF                           \ update link transfer error flag
$00001000 constant GPDMA2_GPDMA_C7SR_USEF                           \ user setting error flag
$00002000 constant GPDMA2_GPDMA_C7SR_SUSPF                          \ completed suspension flag
$00004000 constant GPDMA2_GPDMA_C7SR_TOF                            \ trigger overrun flag
$00ff0000 constant GPDMA2_GPDMA_C7SR_FIFOL                          \ monitored FIFO level


\
\ @brief GPDMA channel 7 control register
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$00000001 constant GPDMA2_GPDMA_C7CR_EN                             \ enable
$00000002 constant GPDMA2_GPDMA_C7CR_RESET                          \ reset
$00000004 constant GPDMA2_GPDMA_C7CR_SUSP                           \ suspend
$00000100 constant GPDMA2_GPDMA_C7CR_TCIE                           \ transfer complete interrupt enable
$00000200 constant GPDMA2_GPDMA_C7CR_HTIE                           \ half transfer complete interrupt enable
$00000400 constant GPDMA2_GPDMA_C7CR_DTEIE                          \ data transfer error interrupt enable
$00000800 constant GPDMA2_GPDMA_C7CR_ULEIE                          \ update link transfer error interrupt enable
$00001000 constant GPDMA2_GPDMA_C7CR_USEIE                          \ user setting error interrupt enable
$00002000 constant GPDMA2_GPDMA_C7CR_SUSPIE                         \ completed suspension interrupt enable
$00004000 constant GPDMA2_GPDMA_C7CR_TOIE                           \ trigger overrun interrupt enable
$00010000 constant GPDMA2_GPDMA_C7CR_LSM                            \ Link step mode
$00020000 constant GPDMA2_GPDMA_C7CR_LAP                            \ linked-list allocated port
$00c00000 constant GPDMA2_GPDMA_C7CR_PRIO                           \ priority level of the channel x GPDMA transfer versus others


\
\ @brief GPDMA channel 7 transfer register 1
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000003 constant GPDMA2_GPDMA_C7TR1_SDW_LOG2                      \ binary logarithm of the source data width of a burst in bytes
$00000008 constant GPDMA2_GPDMA_C7TR1_SINC                          \ source incrementing burst
$000003f0 constant GPDMA2_GPDMA_C7TR1_SBL_1                         \ source burst length minus 1, between 0 and 63
$00001800 constant GPDMA2_GPDMA_C7TR1_PAM                           \ padding/alignment mode
$00002000 constant GPDMA2_GPDMA_C7TR1_SBX                           \ source byte exchange within the unaligned half-word of each source word
$00004000 constant GPDMA2_GPDMA_C7TR1_SAP                           \ source allocated port
$00008000 constant GPDMA2_GPDMA_C7TR1_SSEC                          \ security attribute of the GPDMA transfer from the source
$00030000 constant GPDMA2_GPDMA_C7TR1_DDW_LOG2                      \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant GPDMA2_GPDMA_C7TR1_DINC                          \ destination incrementing burst
$03f00000 constant GPDMA2_GPDMA_C7TR1_DBL_1                         \ destination burst length minus 1, between 0 and 63
$04000000 constant GPDMA2_GPDMA_C7TR1_DBX                           \ destination byte exchange
$08000000 constant GPDMA2_GPDMA_C7TR1_DHX                           \ destination half-word exchange
$40000000 constant GPDMA2_GPDMA_C7TR1_DAP                           \ destination allocated port
$80000000 constant GPDMA2_GPDMA_C7TR1_DSEC                          \ security attribute of the GPDMA transfer to the destination


\
\ @brief GPDMA channel 7 transfer register 2
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$000000ff constant GPDMA2_GPDMA_C7TR2_REQSEL                        \ GPDMA hardware request selection
$00000200 constant GPDMA2_GPDMA_C7TR2_SWREQ                         \ software request
$00000400 constant GPDMA2_GPDMA_C7TR2_DREQ                          \ destination hardware request
$00000800 constant GPDMA2_GPDMA_C7TR2_BREQ                          \ Block hardware request
$00001000 constant GPDMA2_GPDMA_C7TR2_PFREQ                         \ Hardware request in peripheral flow control mode
$0000c000 constant GPDMA2_GPDMA_C7TR2_TRIGM                         \ trigger mode
$003f0000 constant GPDMA2_GPDMA_C7TR2_TRIGSEL                       \ trigger event input selection
$03000000 constant GPDMA2_GPDMA_C7TR2_TRIGPOL                       \ trigger event polarity
$c0000000 constant GPDMA2_GPDMA_C7TR2_TCEM                          \ transfer complete event mode


\
\ @brief GPDMA channel 7 alternate block register 1
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C7BR1_BNDT                          \ block number of data bytes to transfer from the source
$07ff0000 constant GPDMA2_GPDMA_C7BR1_BRC                           \ Block repeat counter
$10000000 constant GPDMA2_GPDMA_C7BR1_SDEC                          \ source address decrement
$20000000 constant GPDMA2_GPDMA_C7BR1_DDEC                          \ destination address decrement
$40000000 constant GPDMA2_GPDMA_C7BR1_BRSDEC                        \ Block repeat source address decrement
$80000000 constant GPDMA2_GPDMA_C7BR1_BRDDEC                        \ Block repeat destination address decrement


\
\ @brief GPDMA channel 7 source address register
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C7SAR_SA                            \ source address


\
\ @brief GPDMA channel 7 destination address register
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$00000000 constant GPDMA2_GPDMA_C7DAR_DA                            \ destination address


\
\ @brief GPDMA channel 7 transfer register 3
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$00001fff constant GPDMA2_GPDMA_C7TR3_SAO                           \ source address offset increment
$1fff0000 constant GPDMA2_GPDMA_C7TR3_DAO                           \ destination address offset increment


\
\ @brief GPDMA channel 7 block register 2
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$0000ffff constant GPDMA2_GPDMA_C7BR2_BRSAO                         \ Block repeated source address offset
$ffff0000 constant GPDMA2_GPDMA_C7BR2_BRDAO                         \ Block repeated destination address offset


\
\ @brief GPDMA channel 7 alternate linked-list address register
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$0000fffc constant GPDMA2_GPDMA_C7LLR_LA                            \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant GPDMA2_GPDMA_C7LLR_ULL                           \ Update GPDMA_CxLLR register from memory
$02000000 constant GPDMA2_GPDMA_C7LLR_UB2                           \ Update GPDMA_CxBR2 from memory
$04000000 constant GPDMA2_GPDMA_C7LLR_UT3                           \ Update GPDMA_CxTR3 from memory
$08000000 constant GPDMA2_GPDMA_C7LLR_UDA                           \ Update GPDMA_CxDAR register from memory
$10000000 constant GPDMA2_GPDMA_C7LLR_USA                           \ update GPDMA_CxSAR from memory
$20000000 constant GPDMA2_GPDMA_C7LLR_UB1                           \ Update GPDMA_CxBR1 from memory
$40000000 constant GPDMA2_GPDMA_C7LLR_UT2                           \ Update GPDMA_CxTR2 from memory
$80000000 constant GPDMA2_GPDMA_C7LLR_UT1                           \ Update GPDMA_CxTR1 from memory


\
\ @brief GPDMA2 channel7 global interrupt
\
$40021000 constant GPDMA2_GPDMA_SECCFGR  \ offset: 0x00 : GPDMA secure configuration register
$40021004 constant GPDMA2_GPDMA_PRIVCFGR  \ offset: 0x04 : GPDMA privileged configuration register
$40021008 constant GPDMA2_GPDMA_RCFGLOCKR  \ offset: 0x08 : GPDMA configuration lock register
$4002100c constant GPDMA2_GPDMA_MISR  \ offset: 0x0C : GPDMA nonsecure masked interrupt status register
$40021010 constant GPDMA2_GPDMA_SMISR  \ offset: 0x10 : GPDMA secure masked interrupt status register
$40021050 constant GPDMA2_GPDMA_C0LBAR  \ offset: 0x50 : GPDMA channel 0 linked-list base address register
$4002105c constant GPDMA2_GPDMA_C0FCR  \ offset: 0x5C : GPDMA channel 0 flag clear register
$40021060 constant GPDMA2_GPDMA_C0SR  \ offset: 0x60 : GPDMA channel 0 status register
$40021064 constant GPDMA2_GPDMA_C0CR  \ offset: 0x64 : GPDMA channel 0 control register
$40021090 constant GPDMA2_GPDMA_C0TR1  \ offset: 0x90 : GPDMA channel 0 transfer register 1
$40021094 constant GPDMA2_GPDMA_C0TR2  \ offset: 0x94 : GPDMA channel 0 transfer register 2
$40021098 constant GPDMA2_GPDMA_C0BR1  \ offset: 0x98 : GPDMA channel 0 block register 1
$4002109c constant GPDMA2_GPDMA_C0SAR  \ offset: 0x9C : GPDMA channel 0 source address register
$400210a0 constant GPDMA2_GPDMA_C0DAR  \ offset: 0xA0 : GPDMA channel 0 destination address register
$400210cc constant GPDMA2_GPDMA_C0LLR  \ offset: 0xCC : GPDMA channel 0 linked-list address register
$400210d0 constant GPDMA2_GPDMA_C1LBAR  \ offset: 0xD0 : GPDMA channel 1 linked-list base address register
$400210dc constant GPDMA2_GPDMA_C1FCR  \ offset: 0xDC : GPDMA channel 1 flag clear register
$400210e0 constant GPDMA2_GPDMA_C1SR  \ offset: 0xE0 : GPDMA channel 1 status register
$400210e4 constant GPDMA2_GPDMA_C1CR  \ offset: 0xE4 : GPDMA channel 1 control register
$40021110 constant GPDMA2_GPDMA_C1TR1  \ offset: 0x110 : GPDMA channel 1 transfer register 1
$40021114 constant GPDMA2_GPDMA_C1TR2  \ offset: 0x114 : GPDMA channel 1 transfer register 2
$40021118 constant GPDMA2_GPDMA_C1BR1  \ offset: 0x118 : GPDMA channel 1 block register 1
$4002111c constant GPDMA2_GPDMA_C1SAR  \ offset: 0x11C : GPDMA channel 1 source address register
$40021120 constant GPDMA2_GPDMA_C1DAR  \ offset: 0x120 : GPDMA channel 1 destination address register
$4002114c constant GPDMA2_GPDMA_C1LLR  \ offset: 0x14C : GPDMA channel 1 linked-list address register
$40021150 constant GPDMA2_GPDMA_C2LBAR  \ offset: 0x150 : GPDMA channel 2 linked-list base address register
$4002115c constant GPDMA2_GPDMA_C2FCR  \ offset: 0x15C : GPDMA channel 2 flag clear register
$40021160 constant GPDMA2_GPDMA_C2SR  \ offset: 0x160 : GPDMA channel 2 status register
$40021164 constant GPDMA2_GPDMA_C2CR  \ offset: 0x164 : GPDMA channel 2 control register
$40021190 constant GPDMA2_GPDMA_C2TR1  \ offset: 0x190 : GPDMA channel 2 transfer register 1
$40021194 constant GPDMA2_GPDMA_C2TR2  \ offset: 0x194 : GPDMA channel 2 transfer register 2
$40021198 constant GPDMA2_GPDMA_C2BR1  \ offset: 0x198 : GPDMA channel 2 block register 1
$4002119c constant GPDMA2_GPDMA_C2SAR  \ offset: 0x19C : GPDMA channel 2 source address register
$400211a0 constant GPDMA2_GPDMA_C2DAR  \ offset: 0x1A0 : GPDMA channel 2 destination address register
$400211cc constant GPDMA2_GPDMA_C2LLR  \ offset: 0x1CC : GPDMA channel 2 linked-list address register
$400211d0 constant GPDMA2_GPDMA_C3LBAR  \ offset: 0x1D0 : GPDMA channel 3 linked-list base address register
$400211dc constant GPDMA2_GPDMA_C3FCR  \ offset: 0x1DC : GPDMA channel 3 flag clear register
$400211e0 constant GPDMA2_GPDMA_C3SR  \ offset: 0x1E0 : GPDMA channel 3 status register
$400211e4 constant GPDMA2_GPDMA_C3CR  \ offset: 0x1E4 : GPDMA channel 3 control register
$40021210 constant GPDMA2_GPDMA_C3TR1  \ offset: 0x210 : GPDMA channel 3 transfer register 1
$40021214 constant GPDMA2_GPDMA_C3TR2  \ offset: 0x214 : GPDMA channel 3 transfer register 2
$40021218 constant GPDMA2_GPDMA_C3BR1  \ offset: 0x218 : GPDMA channel 3 block register 1
$4002121c constant GPDMA2_GPDMA_C3SAR  \ offset: 0x21C : GPDMA channel 3 source address register
$40021220 constant GPDMA2_GPDMA_C3DAR  \ offset: 0x220 : GPDMA channel 3 destination address register
$4002124c constant GPDMA2_GPDMA_C3LLR  \ offset: 0x24C : GPDMA channel 3 linked-list address register
$40021250 constant GPDMA2_GPDMA_C4LBAR  \ offset: 0x250 : GPDMA channel 4 linked-list base address register
$4002125c constant GPDMA2_GPDMA_C4FCR  \ offset: 0x25C : GPDMA channel 4 flag clear register
$40021260 constant GPDMA2_GPDMA_C4SR  \ offset: 0x260 : GPDMA channel 4 status register
$40021264 constant GPDMA2_GPDMA_C4CR  \ offset: 0x264 : GPDMA channel 4 control register
$40021290 constant GPDMA2_GPDMA_C4TR1  \ offset: 0x290 : GPDMA channel 4 transfer register 1
$40021294 constant GPDMA2_GPDMA_C4TR2  \ offset: 0x294 : GPDMA channel 4 transfer register 2
$40021298 constant GPDMA2_GPDMA_C4BR1  \ offset: 0x298 : GPDMA channel 4 block register 1
$4002129c constant GPDMA2_GPDMA_C4SAR  \ offset: 0x29C : GPDMA channel 4 source address register
$400212a0 constant GPDMA2_GPDMA_C4DAR  \ offset: 0x2A0 : GPDMA channel 4 destination address register
$400212cc constant GPDMA2_GPDMA_C4LLR  \ offset: 0x2CC : GPDMA channel 4 linked-list address register
$400212d0 constant GPDMA2_GPDMA_C5LBAR  \ offset: 0x2D0 : GPDMA channel 5 linked-list base address register
$400212dc constant GPDMA2_GPDMA_C5FCR  \ offset: 0x2DC : GPDMA channel 5 flag clear register
$400212e0 constant GPDMA2_GPDMA_C5SR  \ offset: 0x2E0 : GPDMA channel 5 status register
$400212e4 constant GPDMA2_GPDMA_C5CR  \ offset: 0x2E4 : GPDMA channel 5 control register
$40021310 constant GPDMA2_GPDMA_C5TR1  \ offset: 0x310 : GPDMA channel 5 transfer register 1
$40021314 constant GPDMA2_GPDMA_C5TR2  \ offset: 0x314 : GPDMA channel 5 transfer register 2
$40021318 constant GPDMA2_GPDMA_C5BR1  \ offset: 0x318 : GPDMA channel 5 block register 1
$4002131c constant GPDMA2_GPDMA_C5SAR  \ offset: 0x31C : GPDMA channel 5 source address register
$40021320 constant GPDMA2_GPDMA_C5DAR  \ offset: 0x320 : GPDMA channel 5 destination address register
$4002134c constant GPDMA2_GPDMA_C5LLR  \ offset: 0x34C : GPDMA channel 5 linked-list address register
$40021350 constant GPDMA2_GPDMA_C6LBAR  \ offset: 0x350 : GPDMA channel 6 linked-list base address register
$4002135c constant GPDMA2_GPDMA_C6FCR  \ offset: 0x35C : GPDMA channel 6 flag clear register
$40021360 constant GPDMA2_GPDMA_C6SR  \ offset: 0x360 : GPDMA channel 6 status register
$40021364 constant GPDMA2_GPDMA_C6CR  \ offset: 0x364 : GPDMA channel 6 control register
$40021390 constant GPDMA2_GPDMA_C6TR1  \ offset: 0x390 : GPDMA channel 6 transfer register 1
$40021394 constant GPDMA2_GPDMA_C6TR2  \ offset: 0x394 : GPDMA channel 6 transfer register 2
$40021398 constant GPDMA2_GPDMA_C6BR1  \ offset: 0x398 : GPDMA channel 6 alternate block register 1
$4002139c constant GPDMA2_GPDMA_C6SAR  \ offset: 0x39C : GPDMA channel 6 source address register
$400213a0 constant GPDMA2_GPDMA_C6DAR  \ offset: 0x3A0 : GPDMA channel 6 destination address register
$400213a4 constant GPDMA2_GPDMA_C6TR3  \ offset: 0x3A4 : GPDMA channel 6 transfer register 3
$400213a8 constant GPDMA2_GPDMA_C6BR2  \ offset: 0x3A8 : GPDMA channel 6 block register 2
$400213cc constant GPDMA2_GPDMA_C6LLR  \ offset: 0x3CC : GPDMA channel 6 alternate linked-list address register
$400213d0 constant GPDMA2_GPDMA_C7LBAR  \ offset: 0x3D0 : GPDMA channel 7 linked-list base address register
$400213dc constant GPDMA2_GPDMA_C7FCR  \ offset: 0x3DC : GPDMA channel 7 flag clear register
$400213e0 constant GPDMA2_GPDMA_C7SR  \ offset: 0x3E0 : GPDMA channel 7 status register
$400213e4 constant GPDMA2_GPDMA_C7CR  \ offset: 0x3E4 : GPDMA channel 7 control register
$40021410 constant GPDMA2_GPDMA_C7TR1  \ offset: 0x410 : GPDMA channel 7 transfer register 1
$40021414 constant GPDMA2_GPDMA_C7TR2  \ offset: 0x414 : GPDMA channel 7 transfer register 2
$40021418 constant GPDMA2_GPDMA_C7BR1  \ offset: 0x418 : GPDMA channel 7 alternate block register 1
$4002141c constant GPDMA2_GPDMA_C7SAR  \ offset: 0x41C : GPDMA channel 7 source address register
$40021420 constant GPDMA2_GPDMA_C7DAR  \ offset: 0x420 : GPDMA channel 7 destination address register
$40021424 constant GPDMA2_GPDMA_C7TR3  \ offset: 0x424 : GPDMA channel 7 transfer register 3
$40021428 constant GPDMA2_GPDMA_C7BR2  \ offset: 0x428 : GPDMA channel 7 block register 2
$4002144c constant GPDMA2_GPDMA_C7LLR  \ offset: 0x44C : GPDMA channel 7 alternate linked-list address register

