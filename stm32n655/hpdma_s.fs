\
\ @file hpdma_s.fs
\ @brief High-performance direct memory access controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief HPDMA secure configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_SECCFGR_SEC0                       \ secure state of channel x
$00000002 constant HPDMA_S_HPDMA_SECCFGR_SEC1                       \ secure state of channel x
$00000004 constant HPDMA_S_HPDMA_SECCFGR_SEC2                       \ secure state of channel x
$00000008 constant HPDMA_S_HPDMA_SECCFGR_SEC3                       \ secure state of channel x
$00000010 constant HPDMA_S_HPDMA_SECCFGR_SEC4                       \ secure state of channel x
$00000020 constant HPDMA_S_HPDMA_SECCFGR_SEC5                       \ secure state of channel x
$00000040 constant HPDMA_S_HPDMA_SECCFGR_SEC6                       \ secure state of channel x
$00000080 constant HPDMA_S_HPDMA_SECCFGR_SEC7                       \ secure state of channel x
$00000100 constant HPDMA_S_HPDMA_SECCFGR_SEC8                       \ secure state of channel x
$00000200 constant HPDMA_S_HPDMA_SECCFGR_SEC9                       \ secure state of channel x
$00000400 constant HPDMA_S_HPDMA_SECCFGR_SEC10                      \ secure state of channel x
$00000800 constant HPDMA_S_HPDMA_SECCFGR_SEC11                      \ secure state of channel x
$00001000 constant HPDMA_S_HPDMA_SECCFGR_SEC12                      \ secure state of channel x
$00002000 constant HPDMA_S_HPDMA_SECCFGR_SEC13                      \ secure state of channel x
$00004000 constant HPDMA_S_HPDMA_SECCFGR_SEC14                      \ secure state of channel x
$00008000 constant HPDMA_S_HPDMA_SECCFGR_SEC15                      \ secure state of channel x


\
\ @brief HPDMA privileged configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV0                     \ privileged state of channel x
$00000002 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV1                     \ privileged state of channel x
$00000004 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV2                     \ privileged state of channel x
$00000008 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV3                     \ privileged state of channel x
$00000010 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV4                     \ privileged state of channel x
$00000020 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV5                     \ privileged state of channel x
$00000040 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV6                     \ privileged state of channel x
$00000080 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV7                     \ privileged state of channel x
$00000100 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV8                     \ privileged state of channel x
$00000200 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV9                     \ privileged state of channel x
$00000400 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV10                    \ privileged state of channel x
$00000800 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV11                    \ privileged state of channel x
$00001000 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV12                    \ privileged state of channel x
$00002000 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV13                    \ privileged state of channel x
$00004000 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV14                    \ privileged state of channel x
$00008000 constant HPDMA_S_HPDMA_PRIVCFGR_PRIV15                    \ privileged state of channel x


\
\ @brief HPDMA configuration lock register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK0                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000002 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK1                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000004 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK2                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000008 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK3                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000010 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK4                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000020 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK5                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000040 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK6                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000080 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK7                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000100 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK8                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000200 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK9                    \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000400 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK10                   \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00000800 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK11                   \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00001000 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK12                   \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00002000 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK13                   \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00004000 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK14                   \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset
$00008000 constant HPDMA_S_HPDMA_RCFGLOCKR_LOCK15                   \ lock the configuration of HPDMA_SECCFGR.SECx, HPDMA_PRIVCFGR.PRIVx, and HPDMA_CxCIDCFGR until a global HPDMA reset


\
\ @brief HPDMA non-secure masked interrupt status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_MISR_MIS0                          \ masked interrupt status of channel x
$00000002 constant HPDMA_S_HPDMA_MISR_MIS1                          \ masked interrupt status of channel x
$00000004 constant HPDMA_S_HPDMA_MISR_MIS2                          \ masked interrupt status of channel x
$00000008 constant HPDMA_S_HPDMA_MISR_MIS3                          \ masked interrupt status of channel x
$00000010 constant HPDMA_S_HPDMA_MISR_MIS4                          \ masked interrupt status of channel x
$00000020 constant HPDMA_S_HPDMA_MISR_MIS5                          \ masked interrupt status of channel x
$00000040 constant HPDMA_S_HPDMA_MISR_MIS6                          \ masked interrupt status of channel x
$00000080 constant HPDMA_S_HPDMA_MISR_MIS7                          \ masked interrupt status of channel x
$00000100 constant HPDMA_S_HPDMA_MISR_MIS8                          \ masked interrupt status of channel x
$00000200 constant HPDMA_S_HPDMA_MISR_MIS9                          \ masked interrupt status of channel x
$00000400 constant HPDMA_S_HPDMA_MISR_MIS10                         \ masked interrupt status of channel x
$00000800 constant HPDMA_S_HPDMA_MISR_MIS11                         \ masked interrupt status of channel x
$00001000 constant HPDMA_S_HPDMA_MISR_MIS12                         \ masked interrupt status of channel x
$00002000 constant HPDMA_S_HPDMA_MISR_MIS13                         \ masked interrupt status of channel x
$00004000 constant HPDMA_S_HPDMA_MISR_MIS14                         \ masked interrupt status of channel x
$00008000 constant HPDMA_S_HPDMA_MISR_MIS15                         \ masked interrupt status of channel x


\
\ @brief HPDMA secure masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_SMISR_MIS0                         \ masked interrupt status of the secure channel x
$00000002 constant HPDMA_S_HPDMA_SMISR_MIS1                         \ masked interrupt status of the secure channel x
$00000004 constant HPDMA_S_HPDMA_SMISR_MIS2                         \ masked interrupt status of the secure channel x
$00000008 constant HPDMA_S_HPDMA_SMISR_MIS3                         \ masked interrupt status of the secure channel x
$00000010 constant HPDMA_S_HPDMA_SMISR_MIS4                         \ masked interrupt status of the secure channel x
$00000020 constant HPDMA_S_HPDMA_SMISR_MIS5                         \ masked interrupt status of the secure channel x
$00000040 constant HPDMA_S_HPDMA_SMISR_MIS6                         \ masked interrupt status of the secure channel x
$00000080 constant HPDMA_S_HPDMA_SMISR_MIS7                         \ masked interrupt status of the secure channel x
$00000100 constant HPDMA_S_HPDMA_SMISR_MIS8                         \ masked interrupt status of the secure channel x
$00000200 constant HPDMA_S_HPDMA_SMISR_MIS9                         \ masked interrupt status of the secure channel x
$00000400 constant HPDMA_S_HPDMA_SMISR_MIS10                        \ masked interrupt status of the secure channel x
$00000800 constant HPDMA_S_HPDMA_SMISR_MIS11                        \ masked interrupt status of the secure channel x
$00001000 constant HPDMA_S_HPDMA_SMISR_MIS12                        \ masked interrupt status of the secure channel x
$00002000 constant HPDMA_S_HPDMA_SMISR_MIS13                        \ masked interrupt status of the secure channel x
$00004000 constant HPDMA_S_HPDMA_SMISR_MIS14                        \ masked interrupt status of the secure channel x
$00008000 constant HPDMA_S_HPDMA_SMISR_MIS15                        \ masked interrupt status of the secure channel x


\
\ @brief HPDMA channel 0 linked-list base address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C0LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 0 CID register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C0CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C0CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C0CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C0CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C0CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C0CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C0CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C0CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C0CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C0CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 0 semaphore control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C0SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C0SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 0 flag clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C0FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C0FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C0FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C0FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C0FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C0FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C0FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 0 status register
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C0SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C0SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C0SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C0SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C0SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C0SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C0SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C0SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C0SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 0 control register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C0CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C0CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C0CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C0CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C0CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C0CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C0CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C0CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C0CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C0CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C0CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C0CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C0CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 0 transfer register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C0TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C0TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C0TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C0TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C0TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C0TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C0TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C0TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C0TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C0TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C0TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C0TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C0TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C0TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C0TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 0 transfer register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C0TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C0TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C0TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C0TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C0TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C0TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C0TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C0TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C0TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 0 block register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C0BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 0 source address register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C0SAR_SA                           \ source address


\
\ @brief HPDMA channel 0 destination address register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C0DAR_DA                           \ destination address


\
\ @brief HPDMA channel 0 linked-list address register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C0LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C0LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C0LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C0LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C0LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C0LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C0LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 1 linked-list base address register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C1LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 1 CID register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C1CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C1CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C1CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C1CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C1CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C1CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C1CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C1CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C1CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C1CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 1 semaphore control register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C1SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C1SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 1 flag clear register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C1FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C1FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C1FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C1FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C1FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C1FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C1FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 1 status register
\ Address offset: 0xE0
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C1SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C1SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C1SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C1SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C1SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C1SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C1SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C1SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C1SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 1 control register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C1CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C1CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C1CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C1CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C1CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C1CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C1CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C1CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C1CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C1CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C1CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C1CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C1CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 1 transfer register 1
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C1TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C1TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C1TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C1TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C1TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C1TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C1TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C1TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C1TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C1TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C1TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C1TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C1TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C1TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C1TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 1 transfer register 2
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C1TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C1TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C1TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C1TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C1TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C1TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C1TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C1TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C1TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 1 block register 1
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C1BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 1 source address register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C1SAR_SA                           \ source address


\
\ @brief HPDMA channel 1 destination address register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C1DAR_DA                           \ destination address


\
\ @brief HPDMA channel 1 linked-list address register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C1LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C1LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C1LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C1LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C1LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C1LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C1LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 2 linked-list base address register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C2LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 2 CID register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C2CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C2CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C2CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C2CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C2CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C2CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C2CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C2CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C2CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C2CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 2 semaphore control register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C2SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C2SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 2 flag clear register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C2FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C2FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C2FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C2FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C2FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C2FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C2FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 2 status register
\ Address offset: 0x160
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C2SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C2SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C2SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C2SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C2SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C2SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C2SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C2SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C2SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 2 control register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C2CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C2CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C2CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C2CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C2CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C2CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C2CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C2CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C2CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C2CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C2CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C2CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C2CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 2 transfer register 1
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C2TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C2TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C2TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C2TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C2TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C2TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C2TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C2TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C2TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C2TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C2TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C2TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C2TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C2TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C2TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 2 transfer register 2
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C2TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C2TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C2TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C2TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C2TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C2TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C2TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C2TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C2TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 2 block register 1
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C2BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 2 source address register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C2SAR_SA                           \ source address


\
\ @brief HPDMA channel 2 destination address register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C2DAR_DA                           \ destination address


\
\ @brief HPDMA channel 2 linked-list address register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C2LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C2LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C2LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C2LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C2LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C2LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C2LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 3 linked-list base address register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C3LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 3 CID register
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C3CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C3CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C3CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C3CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C3CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C3CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C3CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C3CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C3CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C3CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 3 semaphore control register
\ Address offset: 0x1D8
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C3SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C3SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 3 flag clear register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C3FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C3FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C3FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C3FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C3FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C3FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C3FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 3 status register
\ Address offset: 0x1E0
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C3SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C3SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C3SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C3SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C3SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C3SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C3SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C3SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C3SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 3 control register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C3CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C3CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C3CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C3CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C3CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C3CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C3CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C3CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C3CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C3CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C3CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C3CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C3CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 3 transfer register 1
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C3TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C3TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C3TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C3TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C3TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C3TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C3TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C3TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C3TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C3TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C3TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C3TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C3TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C3TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C3TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 3 transfer register 2
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C3TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C3TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C3TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C3TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C3TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C3TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C3TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C3TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C3TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 3 block register 1
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C3BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 3 source address register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C3SAR_SA                           \ source address


\
\ @brief HPDMA channel 3 destination address register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C3DAR_DA                           \ destination address


\
\ @brief HPDMA channel 3 linked-list address register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C3LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C3LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C3LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C3LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C3LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C3LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C3LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 4 linked-list base address register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C4LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 4 CID register
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C4CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C4CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C4CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C4CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C4CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C4CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C4CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C4CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C4CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C4CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 4 semaphore control register
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C4SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C4SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 4 flag clear register
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C4FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C4FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C4FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C4FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C4FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C4FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C4FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 4 status register
\ Address offset: 0x260
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C4SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C4SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C4SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C4SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C4SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C4SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C4SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C4SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C4SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 4 control register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C4CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C4CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C4CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C4CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C4CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C4CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C4CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C4CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C4CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C4CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C4CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C4CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C4CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 4 transfer register 1
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C4TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C4TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C4TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C4TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C4TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C4TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C4TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C4TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C4TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C4TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C4TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C4TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C4TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C4TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C4TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 4 transfer register 2
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C4TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C4TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C4TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C4TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C4TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C4TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C4TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C4TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C4TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 4 block register 1
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C4BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 4 source address register
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C4SAR_SA                           \ source address


\
\ @brief HPDMA channel 4 destination address register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C4DAR_DA                           \ destination address


\
\ @brief HPDMA channel 4 linked-list address register
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C4LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C4LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C4LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C4LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C4LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C4LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C4LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 5 linked-list base address register
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C5LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 5 CID register
\ Address offset: 0x2D4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C5CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C5CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C5CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C5CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C5CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C5CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C5CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C5CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C5CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C5CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 5 semaphore control register
\ Address offset: 0x2D8
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C5SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C5SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 5 flag clear register
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C5FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C5FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C5FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C5FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C5FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C5FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C5FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 5 status register
\ Address offset: 0x2E0
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C5SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C5SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C5SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C5SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C5SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C5SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C5SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C5SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C5SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 5 control register
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C5CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C5CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C5CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C5CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C5CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C5CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C5CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C5CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C5CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C5CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C5CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C5CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C5CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 5 transfer register 1
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C5TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C5TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C5TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C5TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C5TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C5TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C5TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C5TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C5TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C5TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C5TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C5TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C5TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C5TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C5TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 5 transfer register 2
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C5TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C5TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C5TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C5TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C5TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C5TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C5TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C5TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C5TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 5 block register 1
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C5BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 5 source address register
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C5SAR_SA                           \ source address


\
\ @brief HPDMA channel 5 destination address register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C5DAR_DA                           \ destination address


\
\ @brief HPDMA channel 5 linked-list address register
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C5LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C5LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C5LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C5LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C5LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C5LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C5LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 6 linked-list base address register
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C6LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 6 CID register
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C6CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C6CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C6CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C6CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C6CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C6CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C6CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C6CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C6CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C6CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 6 semaphore control register
\ Address offset: 0x358
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C6SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C6SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 6 flag clear register
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C6FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C6FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C6FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C6FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C6FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C6FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C6FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 6 status register
\ Address offset: 0x360
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C6SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C6SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C6SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C6SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C6SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C6SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C6SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C6SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C6SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 6 control register
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C6CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C6CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C6CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C6CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C6CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C6CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C6CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C6CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C6CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C6CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C6CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C6CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C6CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 6 transfer register 1
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C6TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C6TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C6TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C6TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C6TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C6TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C6TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C6TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C6TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C6TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C6TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C6TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C6TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C6TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C6TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 6 transfer register 2
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C6TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C6TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C6TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C6TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C6TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C6TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C6TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C6TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C6TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 6 block register 1
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C6BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 6 source address register
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C6SAR_SA                           \ source address


\
\ @brief HPDMA channel 6 destination address register
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C6DAR_DA                           \ destination address


\
\ @brief HPDMA channel 6 linked-list address register
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C6LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C6LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C6LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C6LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C6LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C6LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C6LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 7 linked-list base address register
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C7LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 7 CID register
\ Address offset: 0x3D4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C7CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C7CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C7CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C7CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C7CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C7CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C7CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C7CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C7CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C7CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 7 semaphore control register
\ Address offset: 0x3D8
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C7SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C7SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 7 flag clear register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C7FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C7FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C7FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C7FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C7FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C7FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C7FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 7 status register
\ Address offset: 0x3E0
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C7SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C7SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C7SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C7SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C7SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C7SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C7SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C7SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C7SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 7 control register
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C7CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C7CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C7CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C7CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C7CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C7CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C7CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C7CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C7CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C7CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C7CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C7CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C7CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 7 transfer register 1
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C7TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C7TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C7TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C7TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C7TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C7TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C7TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C7TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C7TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C7TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C7TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C7TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C7TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C7TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C7TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 7 transfer register 2
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C7TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C7TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C7TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C7TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C7TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C7TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C7TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C7TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C7TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 7 block register 1
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C7BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 7 source address register
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C7SAR_SA                           \ source address


\
\ @brief HPDMA channel 7 destination address register
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C7DAR_DA                           \ destination address


\
\ @brief HPDMA channel 7 linked-list address register
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C7LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C7LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C7LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C7LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C7LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C7LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C7LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 8 linked-list base address register
\ Address offset: 0x450
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C8LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 8 CID register
\ Address offset: 0x454
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C8CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C8CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C8CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C8CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C8CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C8CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C8CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C8CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C8CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C8CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 8 semaphore control register
\ Address offset: 0x458
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C8SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C8SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 8 flag clear register
\ Address offset: 0x45C
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C8FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C8FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C8FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C8FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C8FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C8FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C8FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 8 status register
\ Address offset: 0x460
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C8SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C8SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C8SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C8SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C8SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C8SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C8SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C8SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C8SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 8 control register
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C8CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C8CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C8CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C8CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C8CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C8CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C8CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C8CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C8CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C8CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C8CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C8CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C8CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 8 transfer register 1
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C8TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C8TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C8TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C8TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C8TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C8TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C8TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C8TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C8TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C8TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C8TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C8TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C8TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C8TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C8TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 8 transfer register 2
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C8TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C8TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C8TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C8TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C8TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C8TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C8TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C8TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C8TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 8 block register 1
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C8BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 8 source address register
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C8SAR_SA                           \ source address


\
\ @brief HPDMA channel 8 destination address register
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C8DAR_DA                           \ destination address


\
\ @brief HPDMA channel 8 linked-list address register
\ Address offset: 0x4CC
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C8LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C8LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C8LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C8LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C8LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C8LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C8LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 9 linked-list base address register
\ Address offset: 0x4D0
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C9LBAR_LBA                         \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 9 CID register
\ Address offset: 0x4D4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C9CIDCFGR_CFEN                     \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C9CIDCFGR_SEM_EN                   \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C9CIDCFGR_SCID                     \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C9CIDCFGR_SEM_WLIST_CID0           \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C9CIDCFGR_SEM_WLIST_CID1           \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C9CIDCFGR_SEM_WLIST_CID2           \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C9CIDCFGR_SEM_WLIST_CID3           \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C9CIDCFGR_SEM_WLIST_CID4           \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C9CIDCFGR_SEM_WLIST_CID5           \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C9CIDCFGR_SEM_WLIST_CID6           \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 9 semaphore control register
\ Address offset: 0x4D8
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C9SEMCR_SEM_MUTEX                  \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C9SEMCR_SEM_CCID                   \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 9 flag clear register
\ Address offset: 0x4DC
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C9FCR_TCF                          \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C9FCR_HTF                          \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C9FCR_DTEF                         \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C9FCR_ULEF                         \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C9FCR_USEF                         \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C9FCR_SUSPF                        \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C9FCR_TOF                          \ trigger overrun flag clear


\
\ @brief HPDMA channel 9 status register
\ Address offset: 0x4E0
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C9SR_IDLEF                         \ idle flag
$00000100 constant HPDMA_S_HPDMA_C9SR_TCF                           \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C9SR_HTF                           \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C9SR_DTEF                          \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C9SR_ULEF                          \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C9SR_USEF                          \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C9SR_SUSPF                         \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C9SR_TOF                           \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C9SR_FIFOL                         \ monitored FIFO level


\
\ @brief HPDMA channel 9 control register
\ Address offset: 0x4E4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C9CR_EN                            \ enable
$00000002 constant HPDMA_S_HPDMA_C9CR_RESET                         \ reset
$00000004 constant HPDMA_S_HPDMA_C9CR_SUSP                          \ suspend
$00000100 constant HPDMA_S_HPDMA_C9CR_TCIE                          \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C9CR_HTIE                          \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C9CR_DTEIE                         \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C9CR_ULEIE                         \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C9CR_USEIE                         \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C9CR_SUSPIE                        \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C9CR_TOIE                          \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C9CR_LSM                           \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C9CR_LAP                           \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C9CR_PRIO                          \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 9 transfer register 1
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C9TR1_SDW_LOG2                     \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C9TR1_SINC                         \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C9TR1_SBL_1                        \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C9TR1_PAM                          \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C9TR1_SBX                          \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C9TR1_SAP                          \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C9TR1_SSEC                         \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C9TR1_DDW_LOG2                     \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C9TR1_DINC                         \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C9TR1_DBL_1                        \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C9TR1_DBX                          \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C9TR1_DHX                          \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C9TR1_DWX                          \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C9TR1_DAP                          \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C9TR1_DSEC                         \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 9 transfer register 2
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C9TR2_REQSEL                       \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C9TR2_SWREQ                        \ software request
$00000400 constant HPDMA_S_HPDMA_C9TR2_DREQ                         \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C9TR2_BREQ                         \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C9TR2_PFREQ                        \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C9TR2_TRIGM                        \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C9TR2_TRIGSEL                      \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C9TR2_TRIGPOL                      \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C9TR2_TCEM                         \ transfer complete event mode


\
\ @brief HPDMA channel 9 block register 1
\ Address offset: 0x518
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C9BR1_BNDT                         \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 9 source address register
\ Address offset: 0x51C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C9SAR_SA                           \ source address


\
\ @brief HPDMA channel 9 destination address register
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C9DAR_DA                           \ destination address


\
\ @brief HPDMA channel 9 linked-list address register
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C9LLR_LA                           \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C9LLR_ULL                          \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C9LLR_UDA                          \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C9LLR_USA                          \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C9LLR_UB1                          \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C9LLR_UT2                          \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C9LLR_UT1                          \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 10 linked-list base address register
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C10LBAR_LBA                        \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 10 CID register
\ Address offset: 0x554
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C10CIDCFGR_CFEN                    \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C10CIDCFGR_SEM_EN                  \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C10CIDCFGR_SCID                    \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C10CIDCFGR_SEM_WLIST_CID0          \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C10CIDCFGR_SEM_WLIST_CID1          \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C10CIDCFGR_SEM_WLIST_CID2          \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C10CIDCFGR_SEM_WLIST_CID3          \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C10CIDCFGR_SEM_WLIST_CID4          \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C10CIDCFGR_SEM_WLIST_CID5          \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C10CIDCFGR_SEM_WLIST_CID6          \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 10 semaphore control register
\ Address offset: 0x558
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C10SEMCR_SEM_MUTEX                 \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C10SEMCR_SEM_CCID                  \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 10 flag clear register
\ Address offset: 0x55C
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C10FCR_TCF                         \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C10FCR_HTF                         \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C10FCR_DTEF                        \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C10FCR_ULEF                        \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C10FCR_USEF                        \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C10FCR_SUSPF                       \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C10FCR_TOF                         \ trigger overrun flag clear


\
\ @brief HPDMA channel 10 status register
\ Address offset: 0x560
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C10SR_IDLEF                        \ idle flag
$00000100 constant HPDMA_S_HPDMA_C10SR_TCF                          \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C10SR_HTF                          \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C10SR_DTEF                         \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C10SR_ULEF                         \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C10SR_USEF                         \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C10SR_SUSPF                        \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C10SR_TOF                          \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C10SR_FIFOL                        \ monitored FIFO level


\
\ @brief HPDMA channel 10 control register
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C10CR_EN                           \ enable
$00000002 constant HPDMA_S_HPDMA_C10CR_RESET                        \ reset
$00000004 constant HPDMA_S_HPDMA_C10CR_SUSP                         \ suspend
$00000100 constant HPDMA_S_HPDMA_C10CR_TCIE                         \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C10CR_HTIE                         \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C10CR_DTEIE                        \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C10CR_ULEIE                        \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C10CR_USEIE                        \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C10CR_SUSPIE                       \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C10CR_TOIE                         \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C10CR_LSM                          \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C10CR_LAP                          \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C10CR_PRIO                         \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 10 transfer register 1
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C10TR1_SDW_LOG2                    \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C10TR1_SINC                        \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C10TR1_SBL_1                       \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C10TR1_PAM                         \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C10TR1_SBX                         \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C10TR1_SAP                         \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C10TR1_SSEC                        \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C10TR1_DDW_LOG2                    \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C10TR1_DINC                        \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C10TR1_DBL_1                       \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C10TR1_DBX                         \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C10TR1_DHX                         \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C10TR1_DWX                         \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C10TR1_DAP                         \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C10TR1_DSEC                        \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 10 transfer register 2
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C10TR2_REQSEL                      \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C10TR2_SWREQ                       \ software request
$00000400 constant HPDMA_S_HPDMA_C10TR2_DREQ                        \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C10TR2_BREQ                        \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C10TR2_PFREQ                       \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C10TR2_TRIGM                       \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C10TR2_TRIGSEL                     \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C10TR2_TRIGPOL                     \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C10TR2_TCEM                        \ transfer complete event mode


\
\ @brief HPDMA channel 10 block register 1
\ Address offset: 0x598
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C10BR1_BNDT                        \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 10 source address register
\ Address offset: 0x59C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C10SAR_SA                          \ source address


\
\ @brief HPDMA channel 10 destination address register
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C10DAR_DA                          \ destination address


\
\ @brief HPDMA channel 10 linked-list address register
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C10LLR_LA                          \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C10LLR_ULL                         \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C10LLR_UDA                         \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C10LLR_USA                         \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C10LLR_UB1                         \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C10LLR_UT2                         \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C10LLR_UT1                         \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 11 linked-list base address register
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C11LBAR_LBA                        \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 11 CID register
\ Address offset: 0x5D4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C11CIDCFGR_CFEN                    \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C11CIDCFGR_SEM_EN                  \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C11CIDCFGR_SCID                    \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C11CIDCFGR_SEM_WLIST_CID0          \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C11CIDCFGR_SEM_WLIST_CID1          \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C11CIDCFGR_SEM_WLIST_CID2          \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C11CIDCFGR_SEM_WLIST_CID3          \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C11CIDCFGR_SEM_WLIST_CID4          \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C11CIDCFGR_SEM_WLIST_CID5          \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C11CIDCFGR_SEM_WLIST_CID6          \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 11 semaphore control register
\ Address offset: 0x5D8
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C11SEMCR_SEM_MUTEX                 \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C11SEMCR_SEM_CCID                  \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 11 flag clear register
\ Address offset: 0x5DC
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C11FCR_TCF                         \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C11FCR_HTF                         \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C11FCR_DTEF                        \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C11FCR_ULEF                        \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C11FCR_USEF                        \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C11FCR_SUSPF                       \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C11FCR_TOF                         \ trigger overrun flag clear


\
\ @brief HPDMA channel 11 status register
\ Address offset: 0x5E0
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C11SR_IDLEF                        \ idle flag
$00000100 constant HPDMA_S_HPDMA_C11SR_TCF                          \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C11SR_HTF                          \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C11SR_DTEF                         \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C11SR_ULEF                         \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C11SR_USEF                         \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C11SR_SUSPF                        \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C11SR_TOF                          \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C11SR_FIFOL                        \ monitored FIFO level


\
\ @brief HPDMA channel 11 control register
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C11CR_EN                           \ enable
$00000002 constant HPDMA_S_HPDMA_C11CR_RESET                        \ reset
$00000004 constant HPDMA_S_HPDMA_C11CR_SUSP                         \ suspend
$00000100 constant HPDMA_S_HPDMA_C11CR_TCIE                         \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C11CR_HTIE                         \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C11CR_DTEIE                        \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C11CR_ULEIE                        \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C11CR_USEIE                        \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C11CR_SUSPIE                       \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C11CR_TOIE                         \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C11CR_LSM                          \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C11CR_LAP                          \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C11CR_PRIO                         \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 11 transfer register 1
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C11TR1_SDW_LOG2                    \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C11TR1_SINC                        \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C11TR1_SBL_1                       \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C11TR1_PAM                         \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C11TR1_SBX                         \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C11TR1_SAP                         \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C11TR1_SSEC                        \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C11TR1_DDW_LOG2                    \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C11TR1_DINC                        \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C11TR1_DBL_1                       \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C11TR1_DBX                         \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C11TR1_DHX                         \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C11TR1_DWX                         \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C11TR1_DAP                         \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C11TR1_DSEC                        \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 11 transfer register 2
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C11TR2_REQSEL                      \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C11TR2_SWREQ                       \ software request
$00000400 constant HPDMA_S_HPDMA_C11TR2_DREQ                        \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C11TR2_BREQ                        \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C11TR2_PFREQ                       \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C11TR2_TRIGM                       \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C11TR2_TRIGSEL                     \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C11TR2_TRIGPOL                     \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C11TR2_TCEM                        \ transfer complete event mode


\
\ @brief HPDMA channel 11 block register 1
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C11BR1_BNDT                        \ block number of data bytes to transfer from the source


\
\ @brief HPDMA channel 11 source address register
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C11SAR_SA                          \ source address


\
\ @brief HPDMA channel 11 destination address register
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C11DAR_DA                          \ destination address


\
\ @brief HPDMA channel 11 linked-list address register
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C11LLR_LA                          \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C11LLR_ULL                         \ Update HPDMA_CxLLR register from memory
$08000000 constant HPDMA_S_HPDMA_C11LLR_UDA                         \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C11LLR_USA                         \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C11LLR_UB1                         \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C11LLR_UT2                         \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C11LLR_UT1                         \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 12 linked-list base address register
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C12LBAR_LBA                        \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 12 CID register
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C12CIDCFGR_CFEN                    \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C12CIDCFGR_SEM_EN                  \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C12CIDCFGR_SCID                    \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C12CIDCFGR_SEM_WLIST_CID0          \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C12CIDCFGR_SEM_WLIST_CID1          \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C12CIDCFGR_SEM_WLIST_CID2          \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C12CIDCFGR_SEM_WLIST_CID3          \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C12CIDCFGR_SEM_WLIST_CID4          \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C12CIDCFGR_SEM_WLIST_CID5          \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C12CIDCFGR_SEM_WLIST_CID6          \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 12 semaphore control register
\ Address offset: 0x658
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C12SEMCR_SEM_MUTEX                 \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C12SEMCR_SEM_CCID                  \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 12 flag clear register
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C12FCR_TCF                         \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C12FCR_HTF                         \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C12FCR_DTEF                        \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C12FCR_ULEF                        \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C12FCR_USEF                        \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C12FCR_SUSPF                       \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C12FCR_TOF                         \ trigger overrun flag clear


\
\ @brief HPDMA channel 12 status register
\ Address offset: 0x660
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C12SR_IDLEF                        \ idle flag
$00000100 constant HPDMA_S_HPDMA_C12SR_TCF                          \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C12SR_HTF                          \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C12SR_DTEF                         \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C12SR_ULEF                         \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C12SR_USEF                         \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C12SR_SUSPF                        \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C12SR_TOF                          \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C12SR_FIFOL                        \ monitored FIFO level


\
\ @brief HPDMA channel 12 control register
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C12CR_EN                           \ enable
$00000002 constant HPDMA_S_HPDMA_C12CR_RESET                        \ reset
$00000004 constant HPDMA_S_HPDMA_C12CR_SUSP                         \ suspend
$00000100 constant HPDMA_S_HPDMA_C12CR_TCIE                         \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C12CR_HTIE                         \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C12CR_DTEIE                        \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C12CR_ULEIE                        \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C12CR_USEIE                        \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C12CR_SUSPIE                       \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C12CR_TOIE                         \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C12CR_LSM                          \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C12CR_LAP                          \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C12CR_PRIO                         \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 12 transfer register 1
\ Address offset: 0x690
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C12TR1_SDW_LOG2                    \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C12TR1_SINC                        \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C12TR1_SBL_1                       \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C12TR1_PAM                         \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C12TR1_SBX                         \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C12TR1_SAP                         \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C12TR1_SSEC                        \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C12TR1_DDW_LOG2                    \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C12TR1_DINC                        \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C12TR1_DBL_1                       \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C12TR1_DBX                         \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C12TR1_DHX                         \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C12TR1_DWX                         \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C12TR1_DAP                         \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C12TR1_DSEC                        \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 12 transfer register 2
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C12TR2_REQSEL                      \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C12TR2_SWREQ                       \ software request
$00000400 constant HPDMA_S_HPDMA_C12TR2_DREQ                        \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C12TR2_BREQ                        \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C12TR2_PFREQ                       \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C12TR2_TRIGM                       \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C12TR2_TRIGSEL                     \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C12TR2_TRIGPOL                     \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C12TR2_TCEM                        \ transfer complete event mode


\
\ @brief HPDMA channel 12 alternate block register 1
\ Address offset: 0x698
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C12BR1_BNDT                        \ block number of data bytes to transfer from the source
$07ff0000 constant HPDMA_S_HPDMA_C12BR1_BRC                         \ Block repeat counter
$10000000 constant HPDMA_S_HPDMA_C12BR1_SDEC                        \ source address decrement
$20000000 constant HPDMA_S_HPDMA_C12BR1_DDEC                        \ destination address decrement
$40000000 constant HPDMA_S_HPDMA_C12BR1_BRSDEC                      \ Block repeat source address decrement
$80000000 constant HPDMA_S_HPDMA_C12BR1_BRDDEC                      \ Block repeat destination address decrement


\
\ @brief HPDMA channel 12 source address register
\ Address offset: 0x69C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C12SAR_SA                          \ source address


\
\ @brief HPDMA channel 12 destination address register
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C12DAR_DA                          \ destination address


\
\ @brief HPDMA channel 12 transfer register 3
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$00001fff constant HPDMA_S_HPDMA_C12TR3_SAO                         \ source address offset increment
$1fff0000 constant HPDMA_S_HPDMA_C12TR3_DAO                         \ destination address offset increment


\
\ @brief HPDMA channel 12 block register 2
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C12BR2_BRSAO                       \ Block repeated source address offset
$ffff0000 constant HPDMA_S_HPDMA_C12BR2_BRDAO                       \ Block repeated destination address offset


\
\ @brief HPDMA channel 12 alternate linked-list address register
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C12LLR_LA                          \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C12LLR_ULL                         \ Update HPDMA_CxLLR register from memory
$02000000 constant HPDMA_S_HPDMA_C12LLR_UB2                         \ Update HPDMA_CxBR2 from memory
$04000000 constant HPDMA_S_HPDMA_C12LLR_UT3                         \ Update HPDMA_CxTR3 from memory
$08000000 constant HPDMA_S_HPDMA_C12LLR_UDA                         \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C12LLR_USA                         \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C12LLR_UB1                         \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C12LLR_UT2                         \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C12LLR_UT1                         \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 13 linked-list base address register
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C13LBAR_LBA                        \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 13 CID register
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C13CIDCFGR_CFEN                    \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C13CIDCFGR_SEM_EN                  \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C13CIDCFGR_SCID                    \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C13CIDCFGR_SEM_WLIST_CID0          \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C13CIDCFGR_SEM_WLIST_CID1          \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C13CIDCFGR_SEM_WLIST_CID2          \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C13CIDCFGR_SEM_WLIST_CID3          \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C13CIDCFGR_SEM_WLIST_CID4          \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C13CIDCFGR_SEM_WLIST_CID5          \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C13CIDCFGR_SEM_WLIST_CID6          \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 13 semaphore control register
\ Address offset: 0x6D8
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C13SEMCR_SEM_MUTEX                 \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C13SEMCR_SEM_CCID                  \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 13 flag clear register
\ Address offset: 0x6DC
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C13FCR_TCF                         \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C13FCR_HTF                         \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C13FCR_DTEF                        \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C13FCR_ULEF                        \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C13FCR_USEF                        \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C13FCR_SUSPF                       \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C13FCR_TOF                         \ trigger overrun flag clear


\
\ @brief HPDMA channel 13 status register
\ Address offset: 0x6E0
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C13SR_IDLEF                        \ idle flag
$00000100 constant HPDMA_S_HPDMA_C13SR_TCF                          \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C13SR_HTF                          \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C13SR_DTEF                         \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C13SR_ULEF                         \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C13SR_USEF                         \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C13SR_SUSPF                        \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C13SR_TOF                          \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C13SR_FIFOL                        \ monitored FIFO level


\
\ @brief HPDMA channel 13 control register
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C13CR_EN                           \ enable
$00000002 constant HPDMA_S_HPDMA_C13CR_RESET                        \ reset
$00000004 constant HPDMA_S_HPDMA_C13CR_SUSP                         \ suspend
$00000100 constant HPDMA_S_HPDMA_C13CR_TCIE                         \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C13CR_HTIE                         \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C13CR_DTEIE                        \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C13CR_ULEIE                        \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C13CR_USEIE                        \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C13CR_SUSPIE                       \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C13CR_TOIE                         \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C13CR_LSM                          \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C13CR_LAP                          \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C13CR_PRIO                         \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 13 transfer register 1
\ Address offset: 0x710
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C13TR1_SDW_LOG2                    \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C13TR1_SINC                        \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C13TR1_SBL_1                       \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C13TR1_PAM                         \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C13TR1_SBX                         \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C13TR1_SAP                         \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C13TR1_SSEC                        \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C13TR1_DDW_LOG2                    \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C13TR1_DINC                        \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C13TR1_DBL_1                       \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C13TR1_DBX                         \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C13TR1_DHX                         \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C13TR1_DWX                         \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C13TR1_DAP                         \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C13TR1_DSEC                        \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 13 transfer register 2
\ Address offset: 0x714
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C13TR2_REQSEL                      \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C13TR2_SWREQ                       \ software request
$00000400 constant HPDMA_S_HPDMA_C13TR2_DREQ                        \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C13TR2_BREQ                        \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C13TR2_PFREQ                       \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C13TR2_TRIGM                       \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C13TR2_TRIGSEL                     \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C13TR2_TRIGPOL                     \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C13TR2_TCEM                        \ transfer complete event mode


\
\ @brief HPDMA channel 13 alternate block register 1
\ Address offset: 0x718
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C13BR1_BNDT                        \ block number of data bytes to transfer from the source
$07ff0000 constant HPDMA_S_HPDMA_C13BR1_BRC                         \ Block repeat counter
$10000000 constant HPDMA_S_HPDMA_C13BR1_SDEC                        \ source address decrement
$20000000 constant HPDMA_S_HPDMA_C13BR1_DDEC                        \ destination address decrement
$40000000 constant HPDMA_S_HPDMA_C13BR1_BRSDEC                      \ Block repeat source address decrement
$80000000 constant HPDMA_S_HPDMA_C13BR1_BRDDEC                      \ Block repeat destination address decrement


\
\ @brief HPDMA channel 13 source address register
\ Address offset: 0x71C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C13SAR_SA                          \ source address


\
\ @brief HPDMA channel 13 destination address register
\ Address offset: 0x720
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C13DAR_DA                          \ destination address


\
\ @brief HPDMA channel 13 transfer register 3
\ Address offset: 0x724
\ Reset value: 0x00000000
\

$00001fff constant HPDMA_S_HPDMA_C13TR3_SAO                         \ source address offset increment
$1fff0000 constant HPDMA_S_HPDMA_C13TR3_DAO                         \ destination address offset increment


\
\ @brief HPDMA channel 13 block register 2
\ Address offset: 0x728
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C13BR2_BRSAO                       \ Block repeated source address offset
$ffff0000 constant HPDMA_S_HPDMA_C13BR2_BRDAO                       \ Block repeated destination address offset


\
\ @brief HPDMA channel 13 alternate linked-list address register
\ Address offset: 0x74C
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C13LLR_LA                          \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C13LLR_ULL                         \ Update HPDMA_CxLLR register from memory
$02000000 constant HPDMA_S_HPDMA_C13LLR_UB2                         \ Update HPDMA_CxBR2 from memory
$04000000 constant HPDMA_S_HPDMA_C13LLR_UT3                         \ Update HPDMA_CxTR3 from memory
$08000000 constant HPDMA_S_HPDMA_C13LLR_UDA                         \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C13LLR_USA                         \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C13LLR_UB1                         \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C13LLR_UT2                         \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C13LLR_UT1                         \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 14 linked-list base address register
\ Address offset: 0x750
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C14LBAR_LBA                        \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 14 CID register
\ Address offset: 0x754
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C14CIDCFGR_CFEN                    \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C14CIDCFGR_SEM_EN                  \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C14CIDCFGR_SCID                    \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C14CIDCFGR_SEM_WLIST_CID0          \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C14CIDCFGR_SEM_WLIST_CID1          \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C14CIDCFGR_SEM_WLIST_CID2          \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C14CIDCFGR_SEM_WLIST_CID3          \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C14CIDCFGR_SEM_WLIST_CID4          \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C14CIDCFGR_SEM_WLIST_CID5          \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C14CIDCFGR_SEM_WLIST_CID6          \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 14 semaphore control register
\ Address offset: 0x758
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C14SEMCR_SEM_MUTEX                 \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C14SEMCR_SEM_CCID                  \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 14 flag clear register
\ Address offset: 0x75C
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C14FCR_TCF                         \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C14FCR_HTF                         \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C14FCR_DTEF                        \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C14FCR_ULEF                        \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C14FCR_USEF                        \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C14FCR_SUSPF                       \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C14FCR_TOF                         \ trigger overrun flag clear


\
\ @brief HPDMA channel 14 status register
\ Address offset: 0x760
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C14SR_IDLEF                        \ idle flag
$00000100 constant HPDMA_S_HPDMA_C14SR_TCF                          \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C14SR_HTF                          \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C14SR_DTEF                         \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C14SR_ULEF                         \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C14SR_USEF                         \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C14SR_SUSPF                        \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C14SR_TOF                          \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C14SR_FIFOL                        \ monitored FIFO level


\
\ @brief HPDMA channel 14 control register
\ Address offset: 0x764
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C14CR_EN                           \ enable
$00000002 constant HPDMA_S_HPDMA_C14CR_RESET                        \ reset
$00000004 constant HPDMA_S_HPDMA_C14CR_SUSP                         \ suspend
$00000100 constant HPDMA_S_HPDMA_C14CR_TCIE                         \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C14CR_HTIE                         \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C14CR_DTEIE                        \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C14CR_ULEIE                        \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C14CR_USEIE                        \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C14CR_SUSPIE                       \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C14CR_TOIE                         \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C14CR_LSM                          \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C14CR_LAP                          \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C14CR_PRIO                         \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 14 transfer register 1
\ Address offset: 0x790
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C14TR1_SDW_LOG2                    \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C14TR1_SINC                        \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C14TR1_SBL_1                       \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C14TR1_PAM                         \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C14TR1_SBX                         \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C14TR1_SAP                         \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C14TR1_SSEC                        \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C14TR1_DDW_LOG2                    \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C14TR1_DINC                        \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C14TR1_DBL_1                       \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C14TR1_DBX                         \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C14TR1_DHX                         \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C14TR1_DWX                         \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C14TR1_DAP                         \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C14TR1_DSEC                        \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 14 transfer register 2
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C14TR2_REQSEL                      \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C14TR2_SWREQ                       \ software request
$00000400 constant HPDMA_S_HPDMA_C14TR2_DREQ                        \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C14TR2_BREQ                        \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C14TR2_PFREQ                       \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C14TR2_TRIGM                       \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C14TR2_TRIGSEL                     \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C14TR2_TRIGPOL                     \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C14TR2_TCEM                        \ transfer complete event mode


\
\ @brief HPDMA channel 14 alternate block register 1
\ Address offset: 0x798
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C14BR1_BNDT                        \ block number of data bytes to transfer from the source
$07ff0000 constant HPDMA_S_HPDMA_C14BR1_BRC                         \ Block repeat counter
$10000000 constant HPDMA_S_HPDMA_C14BR1_SDEC                        \ source address decrement
$20000000 constant HPDMA_S_HPDMA_C14BR1_DDEC                        \ destination address decrement
$40000000 constant HPDMA_S_HPDMA_C14BR1_BRSDEC                      \ Block repeat source address decrement
$80000000 constant HPDMA_S_HPDMA_C14BR1_BRDDEC                      \ Block repeat destination address decrement


\
\ @brief HPDMA channel 14 source address register
\ Address offset: 0x79C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C14SAR_SA                          \ source address


\
\ @brief HPDMA channel 14 destination address register
\ Address offset: 0x7A0
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C14DAR_DA                          \ destination address


\
\ @brief HPDMA channel 14 transfer register 3
\ Address offset: 0x7A4
\ Reset value: 0x00000000
\

$00001fff constant HPDMA_S_HPDMA_C14TR3_SAO                         \ source address offset increment
$1fff0000 constant HPDMA_S_HPDMA_C14TR3_DAO                         \ destination address offset increment


\
\ @brief HPDMA channel 14 block register 2
\ Address offset: 0x7A8
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C14BR2_BRSAO                       \ Block repeated source address offset
$ffff0000 constant HPDMA_S_HPDMA_C14BR2_BRDAO                       \ Block repeated destination address offset


\
\ @brief HPDMA channel 14 alternate linked-list address register
\ Address offset: 0x7CC
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C14LLR_LA                          \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C14LLR_ULL                         \ Update HPDMA_CxLLR register from memory
$02000000 constant HPDMA_S_HPDMA_C14LLR_UB2                         \ Update HPDMA_CxBR2 from memory
$04000000 constant HPDMA_S_HPDMA_C14LLR_UT3                         \ Update HPDMA_CxTR3 from memory
$08000000 constant HPDMA_S_HPDMA_C14LLR_UDA                         \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C14LLR_USA                         \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C14LLR_UB1                         \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C14LLR_UT2                         \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C14LLR_UT1                         \ Update HPDMA_CxTR1 from memory


\
\ @brief HPDMA channel 15 linked-list base address register
\ Address offset: 0x7D0
\ Reset value: 0x00000000
\

$ffff0000 constant HPDMA_S_HPDMA_C15LBAR_LBA                        \ linked-list base address of HPDMA channel x


\
\ @brief HPDMA channel 15 CID register
\ Address offset: 0x7D4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C15CIDCFGR_CFEN                    \ CID filtering enable of the channel x
$00000002 constant HPDMA_S_HPDMA_C15CIDCFGR_SEM_EN                  \ semaphore mode enable (for the CID allocation policy to the channel x)
$00000070 constant HPDMA_S_HPDMA_C15CIDCFGR_SCID                    \ allocate a static/single CID to the channel x (for when the channel x CID configuration is not in semaphore mode)
$00010000 constant HPDMA_S_HPDMA_C15CIDCFGR_SEM_WLIST_CID0          \ white-listed CID0 in the CID allocation pool (for when the channel x in semaphore mode)
$00020000 constant HPDMA_S_HPDMA_C15CIDCFGR_SEM_WLIST_CID1          \ white-listed CID1 in the CID allocation pool (for when the channel x in semaphore mode)
$00040000 constant HPDMA_S_HPDMA_C15CIDCFGR_SEM_WLIST_CID2          \ white-listed CID2 in the CID allocation pool (for when the channel x in semaphore mode)
$00080000 constant HPDMA_S_HPDMA_C15CIDCFGR_SEM_WLIST_CID3          \ white-listed CID3 in the CID allocation pool (for when the channel x in semaphore mode)
$00100000 constant HPDMA_S_HPDMA_C15CIDCFGR_SEM_WLIST_CID4          \ white-listed CID4 in the CID allocation pool (for when the channel x in semaphore mode)
$00200000 constant HPDMA_S_HPDMA_C15CIDCFGR_SEM_WLIST_CID5          \ white-listed CID5 in the CID allocation pool (for when the channel x in semaphore mode)
$00400000 constant HPDMA_S_HPDMA_C15CIDCFGR_SEM_WLIST_CID6          \ white-listed CID6 in the CID allocation pool (for when the channel x in semaphore mode)


\
\ @brief HPDMA channel 15 semaphore control register
\ Address offset: 0x7D8
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C15SEMCR_SEM_MUTEX                 \ mutual exclusion semaphore for the CID allocation of the channel x (in semaphore mode)
$00000070 constant HPDMA_S_HPDMA_C15SEMCR_SEM_CCID                  \ current CID allocated to the channel x (in semaphore mode)


\
\ @brief HPDMA channel 15 flag clear register
\ Address offset: 0x7DC
\ Reset value: 0x00000000
\

$00000100 constant HPDMA_S_HPDMA_C15FCR_TCF                         \ transfer complete flag clear
$00000200 constant HPDMA_S_HPDMA_C15FCR_HTF                         \ half transfer flag clear
$00000400 constant HPDMA_S_HPDMA_C15FCR_DTEF                        \ data transfer error flag clear
$00000800 constant HPDMA_S_HPDMA_C15FCR_ULEF                        \ update link transfer error flag clear
$00001000 constant HPDMA_S_HPDMA_C15FCR_USEF                        \ user setting error flag clear
$00002000 constant HPDMA_S_HPDMA_C15FCR_SUSPF                       \ completed suspension flag clear
$00004000 constant HPDMA_S_HPDMA_C15FCR_TOF                         \ trigger overrun flag clear


\
\ @brief HPDMA channel 15 status register
\ Address offset: 0x7E0
\ Reset value: 0x00000001
\

$00000001 constant HPDMA_S_HPDMA_C15SR_IDLEF                        \ idle flag
$00000100 constant HPDMA_S_HPDMA_C15SR_TCF                          \ transfer complete flag
$00000200 constant HPDMA_S_HPDMA_C15SR_HTF                          \ half transfer flag
$00000400 constant HPDMA_S_HPDMA_C15SR_DTEF                         \ data transfer error flag
$00000800 constant HPDMA_S_HPDMA_C15SR_ULEF                         \ update link transfer error flag
$00001000 constant HPDMA_S_HPDMA_C15SR_USEF                         \ user setting error flag
$00002000 constant HPDMA_S_HPDMA_C15SR_SUSPF                        \ completed suspension flag
$00004000 constant HPDMA_S_HPDMA_C15SR_TOF                          \ trigger overrun flag
$01ff0000 constant HPDMA_S_HPDMA_C15SR_FIFOL                        \ monitored FIFO level


\
\ @brief HPDMA channel 15 control register
\ Address offset: 0x7E4
\ Reset value: 0x00000000
\

$00000001 constant HPDMA_S_HPDMA_C15CR_EN                           \ enable
$00000002 constant HPDMA_S_HPDMA_C15CR_RESET                        \ reset
$00000004 constant HPDMA_S_HPDMA_C15CR_SUSP                         \ suspend
$00000100 constant HPDMA_S_HPDMA_C15CR_TCIE                         \ transfer complete interrupt enable
$00000200 constant HPDMA_S_HPDMA_C15CR_HTIE                         \ half transfer complete interrupt enable
$00000400 constant HPDMA_S_HPDMA_C15CR_DTEIE                        \ data transfer error interrupt enable
$00000800 constant HPDMA_S_HPDMA_C15CR_ULEIE                        \ update link transfer error interrupt enable
$00001000 constant HPDMA_S_HPDMA_C15CR_USEIE                        \ user setting error interrupt enable
$00002000 constant HPDMA_S_HPDMA_C15CR_SUSPIE                       \ completed suspension interrupt enable
$00004000 constant HPDMA_S_HPDMA_C15CR_TOIE                         \ trigger overrun interrupt enable
$00010000 constant HPDMA_S_HPDMA_C15CR_LSM                          \ Link step mode
$00020000 constant HPDMA_S_HPDMA_C15CR_LAP                          \ linked-list allocated port
$00c00000 constant HPDMA_S_HPDMA_C15CR_PRIO                         \ priority level of the channel x HPDMA transfer versus others


\
\ @brief HPDMA channel 15 transfer register 1
\ Address offset: 0x810
\ Reset value: 0x00000000
\

$00000003 constant HPDMA_S_HPDMA_C15TR1_SDW_LOG2                    \ binary logarithm of the source data width of a burst in bytes
$00000008 constant HPDMA_S_HPDMA_C15TR1_SINC                        \ source incrementing burst
$000003f0 constant HPDMA_S_HPDMA_C15TR1_SBL_1                       \ source burst length minus 1, between 0 and 63
$00001800 constant HPDMA_S_HPDMA_C15TR1_PAM                         \ padding/alignment mode
$00002000 constant HPDMA_S_HPDMA_C15TR1_SBX                         \ source byte exchange within the unaligned half-word of each source word
$00004000 constant HPDMA_S_HPDMA_C15TR1_SAP                         \ source allocated port
$00008000 constant HPDMA_S_HPDMA_C15TR1_SSEC                        \ security attribute of the HPDMA transfer from the source
$00030000 constant HPDMA_S_HPDMA_C15TR1_DDW_LOG2                    \ binary logarithm of the destination data width of a burst, in bytes
$00080000 constant HPDMA_S_HPDMA_C15TR1_DINC                        \ destination incrementing burst
$03f00000 constant HPDMA_S_HPDMA_C15TR1_DBL_1                       \ destination burst length minus 1, between 0 and 63
$04000000 constant HPDMA_S_HPDMA_C15TR1_DBX                         \ destination byte exchange
$08000000 constant HPDMA_S_HPDMA_C15TR1_DHX                         \ destination half-word exchange
$10000000 constant HPDMA_S_HPDMA_C15TR1_DWX                         \ destination word exchange
$40000000 constant HPDMA_S_HPDMA_C15TR1_DAP                         \ destination allocated port
$80000000 constant HPDMA_S_HPDMA_C15TR1_DSEC                        \ security attribute of the HPDMA transfer to the destination


\
\ @brief HPDMA channel 15 transfer register 2
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$000000ff constant HPDMA_S_HPDMA_C15TR2_REQSEL                      \ hardware request selection
$00000200 constant HPDMA_S_HPDMA_C15TR2_SWREQ                       \ software request
$00000400 constant HPDMA_S_HPDMA_C15TR2_DREQ                        \ destination hardware request
$00000800 constant HPDMA_S_HPDMA_C15TR2_BREQ                        \ Block hardware request
$00001000 constant HPDMA_S_HPDMA_C15TR2_PFREQ                       \ Hardware request in peripheral flow control mode
$0000c000 constant HPDMA_S_HPDMA_C15TR2_TRIGM                       \ trigger mode
$007f0000 constant HPDMA_S_HPDMA_C15TR2_TRIGSEL                     \ trigger event input selection
$03000000 constant HPDMA_S_HPDMA_C15TR2_TRIGPOL                     \ trigger event polarity
$c0000000 constant HPDMA_S_HPDMA_C15TR2_TCEM                        \ transfer complete event mode


\
\ @brief HPDMA channel 15 alternate block register 1
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C15BR1_BNDT                        \ block number of data bytes to transfer from the source
$07ff0000 constant HPDMA_S_HPDMA_C15BR1_BRC                         \ Block repeat counter
$10000000 constant HPDMA_S_HPDMA_C15BR1_SDEC                        \ source address decrement
$20000000 constant HPDMA_S_HPDMA_C15BR1_DDEC                        \ destination address decrement
$40000000 constant HPDMA_S_HPDMA_C15BR1_BRSDEC                      \ Block repeat source address decrement
$80000000 constant HPDMA_S_HPDMA_C15BR1_BRDDEC                      \ Block repeat destination address decrement


\
\ @brief HPDMA channel 15 source address register
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C15SAR_SA                          \ source address


\
\ @brief HPDMA channel 15 destination address register
\ Address offset: 0x820
\ Reset value: 0x00000000
\

$00000000 constant HPDMA_S_HPDMA_C15DAR_DA                          \ destination address


\
\ @brief HPDMA channel 15 transfer register 3
\ Address offset: 0x824
\ Reset value: 0x00000000
\

$00001fff constant HPDMA_S_HPDMA_C15TR3_SAO                         \ source address offset increment
$1fff0000 constant HPDMA_S_HPDMA_C15TR3_DAO                         \ destination address offset increment


\
\ @brief HPDMA channel 15 block register 2
\ Address offset: 0x828
\ Reset value: 0x00000000
\

$0000ffff constant HPDMA_S_HPDMA_C15BR2_BRSAO                       \ Block repeated source address offset
$ffff0000 constant HPDMA_S_HPDMA_C15BR2_BRDAO                       \ Block repeated destination address offset


\
\ @brief HPDMA channel 15 alternate linked-list address register
\ Address offset: 0x84C
\ Reset value: 0x00000000
\

$0000fffc constant HPDMA_S_HPDMA_C15LLR_LA                          \ pointer (16-bit low-significant address) to the next linked-list data structure
$00010000 constant HPDMA_S_HPDMA_C15LLR_ULL                         \ Update HPDMA_CxLLR register from memory
$02000000 constant HPDMA_S_HPDMA_C15LLR_UB2                         \ Update HPDMA_CxBR2 from memory
$04000000 constant HPDMA_S_HPDMA_C15LLR_UT3                         \ Update HPDMA_CxTR3 from memory
$08000000 constant HPDMA_S_HPDMA_C15LLR_UDA                         \ Update HPDMA_CxDAR register from memory
$10000000 constant HPDMA_S_HPDMA_C15LLR_USA                         \ update HPDMA_CxSAR from memory
$20000000 constant HPDMA_S_HPDMA_C15LLR_UB1                         \ Update HPDMA_CxBR1 from memory
$40000000 constant HPDMA_S_HPDMA_C15LLR_UT2                         \ Update HPDMA_CxTR2 from memory
$80000000 constant HPDMA_S_HPDMA_C15LLR_UT1                         \ Update HPDMA_CxTR1 from memory


\
\ @brief High-performance direct memory access controller
\
$58020000 constant HPDMA_S_HPDMA_SECCFGR  \ offset: 0x00 : HPDMA secure configuration register
$58020004 constant HPDMA_S_HPDMA_PRIVCFGR  \ offset: 0x04 : HPDMA privileged configuration register
$58020008 constant HPDMA_S_HPDMA_RCFGLOCKR  \ offset: 0x08 : HPDMA configuration lock register
$5802000c constant HPDMA_S_HPDMA_MISR  \ offset: 0x0C : HPDMA non-secure masked interrupt status register
$58020010 constant HPDMA_S_HPDMA_SMISR  \ offset: 0x10 : HPDMA secure masked interrupt status register
$58020050 constant HPDMA_S_HPDMA_C0LBAR  \ offset: 0x50 : HPDMA channel 0 linked-list base address register
$58020054 constant HPDMA_S_HPDMA_C0CIDCFGR  \ offset: 0x54 : HPDMA channel 0 CID register
$58020058 constant HPDMA_S_HPDMA_C0SEMCR  \ offset: 0x58 : HPDMA channel 0 semaphore control register
$5802005c constant HPDMA_S_HPDMA_C0FCR  \ offset: 0x5C : HPDMA channel 0 flag clear register
$58020060 constant HPDMA_S_HPDMA_C0SR  \ offset: 0x60 : HPDMA channel 0 status register
$58020064 constant HPDMA_S_HPDMA_C0CR  \ offset: 0x64 : HPDMA channel 0 control register
$58020090 constant HPDMA_S_HPDMA_C0TR1  \ offset: 0x90 : HPDMA channel 0 transfer register 1
$58020094 constant HPDMA_S_HPDMA_C0TR2  \ offset: 0x94 : HPDMA channel 0 transfer register 2
$58020098 constant HPDMA_S_HPDMA_C0BR1  \ offset: 0x98 : HPDMA channel 0 block register 1
$5802009c constant HPDMA_S_HPDMA_C0SAR  \ offset: 0x9C : HPDMA channel 0 source address register
$580200a0 constant HPDMA_S_HPDMA_C0DAR  \ offset: 0xA0 : HPDMA channel 0 destination address register
$580200cc constant HPDMA_S_HPDMA_C0LLR  \ offset: 0xCC : HPDMA channel 0 linked-list address register
$580200d0 constant HPDMA_S_HPDMA_C1LBAR  \ offset: 0xD0 : HPDMA channel 1 linked-list base address register
$580200d4 constant HPDMA_S_HPDMA_C1CIDCFGR  \ offset: 0xD4 : HPDMA channel 1 CID register
$580200d8 constant HPDMA_S_HPDMA_C1SEMCR  \ offset: 0xD8 : HPDMA channel 1 semaphore control register
$580200dc constant HPDMA_S_HPDMA_C1FCR  \ offset: 0xDC : HPDMA channel 1 flag clear register
$580200e0 constant HPDMA_S_HPDMA_C1SR  \ offset: 0xE0 : HPDMA channel 1 status register
$580200e4 constant HPDMA_S_HPDMA_C1CR  \ offset: 0xE4 : HPDMA channel 1 control register
$58020110 constant HPDMA_S_HPDMA_C1TR1  \ offset: 0x110 : HPDMA channel 1 transfer register 1
$58020114 constant HPDMA_S_HPDMA_C1TR2  \ offset: 0x114 : HPDMA channel 1 transfer register 2
$58020118 constant HPDMA_S_HPDMA_C1BR1  \ offset: 0x118 : HPDMA channel 1 block register 1
$5802011c constant HPDMA_S_HPDMA_C1SAR  \ offset: 0x11C : HPDMA channel 1 source address register
$58020120 constant HPDMA_S_HPDMA_C1DAR  \ offset: 0x120 : HPDMA channel 1 destination address register
$5802014c constant HPDMA_S_HPDMA_C1LLR  \ offset: 0x14C : HPDMA channel 1 linked-list address register
$58020150 constant HPDMA_S_HPDMA_C2LBAR  \ offset: 0x150 : HPDMA channel 2 linked-list base address register
$58020154 constant HPDMA_S_HPDMA_C2CIDCFGR  \ offset: 0x154 : HPDMA channel 2 CID register
$58020158 constant HPDMA_S_HPDMA_C2SEMCR  \ offset: 0x158 : HPDMA channel 2 semaphore control register
$5802015c constant HPDMA_S_HPDMA_C2FCR  \ offset: 0x15C : HPDMA channel 2 flag clear register
$58020160 constant HPDMA_S_HPDMA_C2SR  \ offset: 0x160 : HPDMA channel 2 status register
$58020164 constant HPDMA_S_HPDMA_C2CR  \ offset: 0x164 : HPDMA channel 2 control register
$58020190 constant HPDMA_S_HPDMA_C2TR1  \ offset: 0x190 : HPDMA channel 2 transfer register 1
$58020194 constant HPDMA_S_HPDMA_C2TR2  \ offset: 0x194 : HPDMA channel 2 transfer register 2
$58020198 constant HPDMA_S_HPDMA_C2BR1  \ offset: 0x198 : HPDMA channel 2 block register 1
$5802019c constant HPDMA_S_HPDMA_C2SAR  \ offset: 0x19C : HPDMA channel 2 source address register
$580201a0 constant HPDMA_S_HPDMA_C2DAR  \ offset: 0x1A0 : HPDMA channel 2 destination address register
$580201cc constant HPDMA_S_HPDMA_C2LLR  \ offset: 0x1CC : HPDMA channel 2 linked-list address register
$580201d0 constant HPDMA_S_HPDMA_C3LBAR  \ offset: 0x1D0 : HPDMA channel 3 linked-list base address register
$580201d4 constant HPDMA_S_HPDMA_C3CIDCFGR  \ offset: 0x1D4 : HPDMA channel 3 CID register
$580201d8 constant HPDMA_S_HPDMA_C3SEMCR  \ offset: 0x1D8 : HPDMA channel 3 semaphore control register
$580201dc constant HPDMA_S_HPDMA_C3FCR  \ offset: 0x1DC : HPDMA channel 3 flag clear register
$580201e0 constant HPDMA_S_HPDMA_C3SR  \ offset: 0x1E0 : HPDMA channel 3 status register
$580201e4 constant HPDMA_S_HPDMA_C3CR  \ offset: 0x1E4 : HPDMA channel 3 control register
$58020210 constant HPDMA_S_HPDMA_C3TR1  \ offset: 0x210 : HPDMA channel 3 transfer register 1
$58020214 constant HPDMA_S_HPDMA_C3TR2  \ offset: 0x214 : HPDMA channel 3 transfer register 2
$58020218 constant HPDMA_S_HPDMA_C3BR1  \ offset: 0x218 : HPDMA channel 3 block register 1
$5802021c constant HPDMA_S_HPDMA_C3SAR  \ offset: 0x21C : HPDMA channel 3 source address register
$58020220 constant HPDMA_S_HPDMA_C3DAR  \ offset: 0x220 : HPDMA channel 3 destination address register
$5802024c constant HPDMA_S_HPDMA_C3LLR  \ offset: 0x24C : HPDMA channel 3 linked-list address register
$58020250 constant HPDMA_S_HPDMA_C4LBAR  \ offset: 0x250 : HPDMA channel 4 linked-list base address register
$58020254 constant HPDMA_S_HPDMA_C4CIDCFGR  \ offset: 0x254 : HPDMA channel 4 CID register
$58020258 constant HPDMA_S_HPDMA_C4SEMCR  \ offset: 0x258 : HPDMA channel 4 semaphore control register
$5802025c constant HPDMA_S_HPDMA_C4FCR  \ offset: 0x25C : HPDMA channel 4 flag clear register
$58020260 constant HPDMA_S_HPDMA_C4SR  \ offset: 0x260 : HPDMA channel 4 status register
$58020264 constant HPDMA_S_HPDMA_C4CR  \ offset: 0x264 : HPDMA channel 4 control register
$58020290 constant HPDMA_S_HPDMA_C4TR1  \ offset: 0x290 : HPDMA channel 4 transfer register 1
$58020294 constant HPDMA_S_HPDMA_C4TR2  \ offset: 0x294 : HPDMA channel 4 transfer register 2
$58020298 constant HPDMA_S_HPDMA_C4BR1  \ offset: 0x298 : HPDMA channel 4 block register 1
$5802029c constant HPDMA_S_HPDMA_C4SAR  \ offset: 0x29C : HPDMA channel 4 source address register
$580202a0 constant HPDMA_S_HPDMA_C4DAR  \ offset: 0x2A0 : HPDMA channel 4 destination address register
$580202cc constant HPDMA_S_HPDMA_C4LLR  \ offset: 0x2CC : HPDMA channel 4 linked-list address register
$580202d0 constant HPDMA_S_HPDMA_C5LBAR  \ offset: 0x2D0 : HPDMA channel 5 linked-list base address register
$580202d4 constant HPDMA_S_HPDMA_C5CIDCFGR  \ offset: 0x2D4 : HPDMA channel 5 CID register
$580202d8 constant HPDMA_S_HPDMA_C5SEMCR  \ offset: 0x2D8 : HPDMA channel 5 semaphore control register
$580202dc constant HPDMA_S_HPDMA_C5FCR  \ offset: 0x2DC : HPDMA channel 5 flag clear register
$580202e0 constant HPDMA_S_HPDMA_C5SR  \ offset: 0x2E0 : HPDMA channel 5 status register
$580202e4 constant HPDMA_S_HPDMA_C5CR  \ offset: 0x2E4 : HPDMA channel 5 control register
$58020310 constant HPDMA_S_HPDMA_C5TR1  \ offset: 0x310 : HPDMA channel 5 transfer register 1
$58020314 constant HPDMA_S_HPDMA_C5TR2  \ offset: 0x314 : HPDMA channel 5 transfer register 2
$58020318 constant HPDMA_S_HPDMA_C5BR1  \ offset: 0x318 : HPDMA channel 5 block register 1
$5802031c constant HPDMA_S_HPDMA_C5SAR  \ offset: 0x31C : HPDMA channel 5 source address register
$58020320 constant HPDMA_S_HPDMA_C5DAR  \ offset: 0x320 : HPDMA channel 5 destination address register
$5802034c constant HPDMA_S_HPDMA_C5LLR  \ offset: 0x34C : HPDMA channel 5 linked-list address register
$58020350 constant HPDMA_S_HPDMA_C6LBAR  \ offset: 0x350 : HPDMA channel 6 linked-list base address register
$58020354 constant HPDMA_S_HPDMA_C6CIDCFGR  \ offset: 0x354 : HPDMA channel 6 CID register
$58020358 constant HPDMA_S_HPDMA_C6SEMCR  \ offset: 0x358 : HPDMA channel 6 semaphore control register
$5802035c constant HPDMA_S_HPDMA_C6FCR  \ offset: 0x35C : HPDMA channel 6 flag clear register
$58020360 constant HPDMA_S_HPDMA_C6SR  \ offset: 0x360 : HPDMA channel 6 status register
$58020364 constant HPDMA_S_HPDMA_C6CR  \ offset: 0x364 : HPDMA channel 6 control register
$58020390 constant HPDMA_S_HPDMA_C6TR1  \ offset: 0x390 : HPDMA channel 6 transfer register 1
$58020394 constant HPDMA_S_HPDMA_C6TR2  \ offset: 0x394 : HPDMA channel 6 transfer register 2
$58020398 constant HPDMA_S_HPDMA_C6BR1  \ offset: 0x398 : HPDMA channel 6 block register 1
$5802039c constant HPDMA_S_HPDMA_C6SAR  \ offset: 0x39C : HPDMA channel 6 source address register
$580203a0 constant HPDMA_S_HPDMA_C6DAR  \ offset: 0x3A0 : HPDMA channel 6 destination address register
$580203cc constant HPDMA_S_HPDMA_C6LLR  \ offset: 0x3CC : HPDMA channel 6 linked-list address register
$580203d0 constant HPDMA_S_HPDMA_C7LBAR  \ offset: 0x3D0 : HPDMA channel 7 linked-list base address register
$580203d4 constant HPDMA_S_HPDMA_C7CIDCFGR  \ offset: 0x3D4 : HPDMA channel 7 CID register
$580203d8 constant HPDMA_S_HPDMA_C7SEMCR  \ offset: 0x3D8 : HPDMA channel 7 semaphore control register
$580203dc constant HPDMA_S_HPDMA_C7FCR  \ offset: 0x3DC : HPDMA channel 7 flag clear register
$580203e0 constant HPDMA_S_HPDMA_C7SR  \ offset: 0x3E0 : HPDMA channel 7 status register
$580203e4 constant HPDMA_S_HPDMA_C7CR  \ offset: 0x3E4 : HPDMA channel 7 control register
$58020410 constant HPDMA_S_HPDMA_C7TR1  \ offset: 0x410 : HPDMA channel 7 transfer register 1
$58020414 constant HPDMA_S_HPDMA_C7TR2  \ offset: 0x414 : HPDMA channel 7 transfer register 2
$58020418 constant HPDMA_S_HPDMA_C7BR1  \ offset: 0x418 : HPDMA channel 7 block register 1
$5802041c constant HPDMA_S_HPDMA_C7SAR  \ offset: 0x41C : HPDMA channel 7 source address register
$58020420 constant HPDMA_S_HPDMA_C7DAR  \ offset: 0x420 : HPDMA channel 7 destination address register
$5802044c constant HPDMA_S_HPDMA_C7LLR  \ offset: 0x44C : HPDMA channel 7 linked-list address register
$58020450 constant HPDMA_S_HPDMA_C8LBAR  \ offset: 0x450 : HPDMA channel 8 linked-list base address register
$58020454 constant HPDMA_S_HPDMA_C8CIDCFGR  \ offset: 0x454 : HPDMA channel 8 CID register
$58020458 constant HPDMA_S_HPDMA_C8SEMCR  \ offset: 0x458 : HPDMA channel 8 semaphore control register
$5802045c constant HPDMA_S_HPDMA_C8FCR  \ offset: 0x45C : HPDMA channel 8 flag clear register
$58020460 constant HPDMA_S_HPDMA_C8SR  \ offset: 0x460 : HPDMA channel 8 status register
$58020464 constant HPDMA_S_HPDMA_C8CR  \ offset: 0x464 : HPDMA channel 8 control register
$58020490 constant HPDMA_S_HPDMA_C8TR1  \ offset: 0x490 : HPDMA channel 8 transfer register 1
$58020494 constant HPDMA_S_HPDMA_C8TR2  \ offset: 0x494 : HPDMA channel 8 transfer register 2
$58020498 constant HPDMA_S_HPDMA_C8BR1  \ offset: 0x498 : HPDMA channel 8 block register 1
$5802049c constant HPDMA_S_HPDMA_C8SAR  \ offset: 0x49C : HPDMA channel 8 source address register
$580204a0 constant HPDMA_S_HPDMA_C8DAR  \ offset: 0x4A0 : HPDMA channel 8 destination address register
$580204cc constant HPDMA_S_HPDMA_C8LLR  \ offset: 0x4CC : HPDMA channel 8 linked-list address register
$580204d0 constant HPDMA_S_HPDMA_C9LBAR  \ offset: 0x4D0 : HPDMA channel 9 linked-list base address register
$580204d4 constant HPDMA_S_HPDMA_C9CIDCFGR  \ offset: 0x4D4 : HPDMA channel 9 CID register
$580204d8 constant HPDMA_S_HPDMA_C9SEMCR  \ offset: 0x4D8 : HPDMA channel 9 semaphore control register
$580204dc constant HPDMA_S_HPDMA_C9FCR  \ offset: 0x4DC : HPDMA channel 9 flag clear register
$580204e0 constant HPDMA_S_HPDMA_C9SR  \ offset: 0x4E0 : HPDMA channel 9 status register
$580204e4 constant HPDMA_S_HPDMA_C9CR  \ offset: 0x4E4 : HPDMA channel 9 control register
$58020510 constant HPDMA_S_HPDMA_C9TR1  \ offset: 0x510 : HPDMA channel 9 transfer register 1
$58020514 constant HPDMA_S_HPDMA_C9TR2  \ offset: 0x514 : HPDMA channel 9 transfer register 2
$58020518 constant HPDMA_S_HPDMA_C9BR1  \ offset: 0x518 : HPDMA channel 9 block register 1
$5802051c constant HPDMA_S_HPDMA_C9SAR  \ offset: 0x51C : HPDMA channel 9 source address register
$58020520 constant HPDMA_S_HPDMA_C9DAR  \ offset: 0x520 : HPDMA channel 9 destination address register
$5802054c constant HPDMA_S_HPDMA_C9LLR  \ offset: 0x54C : HPDMA channel 9 linked-list address register
$58020550 constant HPDMA_S_HPDMA_C10LBAR  \ offset: 0x550 : HPDMA channel 10 linked-list base address register
$58020554 constant HPDMA_S_HPDMA_C10CIDCFGR  \ offset: 0x554 : HPDMA channel 10 CID register
$58020558 constant HPDMA_S_HPDMA_C10SEMCR  \ offset: 0x558 : HPDMA channel 10 semaphore control register
$5802055c constant HPDMA_S_HPDMA_C10FCR  \ offset: 0x55C : HPDMA channel 10 flag clear register
$58020560 constant HPDMA_S_HPDMA_C10SR  \ offset: 0x560 : HPDMA channel 10 status register
$58020564 constant HPDMA_S_HPDMA_C10CR  \ offset: 0x564 : HPDMA channel 10 control register
$58020590 constant HPDMA_S_HPDMA_C10TR1  \ offset: 0x590 : HPDMA channel 10 transfer register 1
$58020594 constant HPDMA_S_HPDMA_C10TR2  \ offset: 0x594 : HPDMA channel 10 transfer register 2
$58020598 constant HPDMA_S_HPDMA_C10BR1  \ offset: 0x598 : HPDMA channel 10 block register 1
$5802059c constant HPDMA_S_HPDMA_C10SAR  \ offset: 0x59C : HPDMA channel 10 source address register
$580205a0 constant HPDMA_S_HPDMA_C10DAR  \ offset: 0x5A0 : HPDMA channel 10 destination address register
$580205cc constant HPDMA_S_HPDMA_C10LLR  \ offset: 0x5CC : HPDMA channel 10 linked-list address register
$580205d0 constant HPDMA_S_HPDMA_C11LBAR  \ offset: 0x5D0 : HPDMA channel 11 linked-list base address register
$580205d4 constant HPDMA_S_HPDMA_C11CIDCFGR  \ offset: 0x5D4 : HPDMA channel 11 CID register
$580205d8 constant HPDMA_S_HPDMA_C11SEMCR  \ offset: 0x5D8 : HPDMA channel 11 semaphore control register
$580205dc constant HPDMA_S_HPDMA_C11FCR  \ offset: 0x5DC : HPDMA channel 11 flag clear register
$580205e0 constant HPDMA_S_HPDMA_C11SR  \ offset: 0x5E0 : HPDMA channel 11 status register
$580205e4 constant HPDMA_S_HPDMA_C11CR  \ offset: 0x5E4 : HPDMA channel 11 control register
$58020610 constant HPDMA_S_HPDMA_C11TR1  \ offset: 0x610 : HPDMA channel 11 transfer register 1
$58020614 constant HPDMA_S_HPDMA_C11TR2  \ offset: 0x614 : HPDMA channel 11 transfer register 2
$58020618 constant HPDMA_S_HPDMA_C11BR1  \ offset: 0x618 : HPDMA channel 11 block register 1
$5802061c constant HPDMA_S_HPDMA_C11SAR  \ offset: 0x61C : HPDMA channel 11 source address register
$58020620 constant HPDMA_S_HPDMA_C11DAR  \ offset: 0x620 : HPDMA channel 11 destination address register
$5802064c constant HPDMA_S_HPDMA_C11LLR  \ offset: 0x64C : HPDMA channel 11 linked-list address register
$58020650 constant HPDMA_S_HPDMA_C12LBAR  \ offset: 0x650 : HPDMA channel 12 linked-list base address register
$58020654 constant HPDMA_S_HPDMA_C12CIDCFGR  \ offset: 0x654 : HPDMA channel 12 CID register
$58020658 constant HPDMA_S_HPDMA_C12SEMCR  \ offset: 0x658 : HPDMA channel 12 semaphore control register
$5802065c constant HPDMA_S_HPDMA_C12FCR  \ offset: 0x65C : HPDMA channel 12 flag clear register
$58020660 constant HPDMA_S_HPDMA_C12SR  \ offset: 0x660 : HPDMA channel 12 status register
$58020664 constant HPDMA_S_HPDMA_C12CR  \ offset: 0x664 : HPDMA channel 12 control register
$58020690 constant HPDMA_S_HPDMA_C12TR1  \ offset: 0x690 : HPDMA channel 12 transfer register 1
$58020694 constant HPDMA_S_HPDMA_C12TR2  \ offset: 0x694 : HPDMA channel 12 transfer register 2
$58020698 constant HPDMA_S_HPDMA_C12BR1  \ offset: 0x698 : HPDMA channel 12 alternate block register 1
$5802069c constant HPDMA_S_HPDMA_C12SAR  \ offset: 0x69C : HPDMA channel 12 source address register
$580206a0 constant HPDMA_S_HPDMA_C12DAR  \ offset: 0x6A0 : HPDMA channel 12 destination address register
$580206a4 constant HPDMA_S_HPDMA_C12TR3  \ offset: 0x6A4 : HPDMA channel 12 transfer register 3
$580206a8 constant HPDMA_S_HPDMA_C12BR2  \ offset: 0x6A8 : HPDMA channel 12 block register 2
$580206cc constant HPDMA_S_HPDMA_C12LLR  \ offset: 0x6CC : HPDMA channel 12 alternate linked-list address register
$580206d0 constant HPDMA_S_HPDMA_C13LBAR  \ offset: 0x6D0 : HPDMA channel 13 linked-list base address register
$580206d4 constant HPDMA_S_HPDMA_C13CIDCFGR  \ offset: 0x6D4 : HPDMA channel 13 CID register
$580206d8 constant HPDMA_S_HPDMA_C13SEMCR  \ offset: 0x6D8 : HPDMA channel 13 semaphore control register
$580206dc constant HPDMA_S_HPDMA_C13FCR  \ offset: 0x6DC : HPDMA channel 13 flag clear register
$580206e0 constant HPDMA_S_HPDMA_C13SR  \ offset: 0x6E0 : HPDMA channel 13 status register
$580206e4 constant HPDMA_S_HPDMA_C13CR  \ offset: 0x6E4 : HPDMA channel 13 control register
$58020710 constant HPDMA_S_HPDMA_C13TR1  \ offset: 0x710 : HPDMA channel 13 transfer register 1
$58020714 constant HPDMA_S_HPDMA_C13TR2  \ offset: 0x714 : HPDMA channel 13 transfer register 2
$58020718 constant HPDMA_S_HPDMA_C13BR1  \ offset: 0x718 : HPDMA channel 13 alternate block register 1
$5802071c constant HPDMA_S_HPDMA_C13SAR  \ offset: 0x71C : HPDMA channel 13 source address register
$58020720 constant HPDMA_S_HPDMA_C13DAR  \ offset: 0x720 : HPDMA channel 13 destination address register
$58020724 constant HPDMA_S_HPDMA_C13TR3  \ offset: 0x724 : HPDMA channel 13 transfer register 3
$58020728 constant HPDMA_S_HPDMA_C13BR2  \ offset: 0x728 : HPDMA channel 13 block register 2
$5802074c constant HPDMA_S_HPDMA_C13LLR  \ offset: 0x74C : HPDMA channel 13 alternate linked-list address register
$58020750 constant HPDMA_S_HPDMA_C14LBAR  \ offset: 0x750 : HPDMA channel 14 linked-list base address register
$58020754 constant HPDMA_S_HPDMA_C14CIDCFGR  \ offset: 0x754 : HPDMA channel 14 CID register
$58020758 constant HPDMA_S_HPDMA_C14SEMCR  \ offset: 0x758 : HPDMA channel 14 semaphore control register
$5802075c constant HPDMA_S_HPDMA_C14FCR  \ offset: 0x75C : HPDMA channel 14 flag clear register
$58020760 constant HPDMA_S_HPDMA_C14SR  \ offset: 0x760 : HPDMA channel 14 status register
$58020764 constant HPDMA_S_HPDMA_C14CR  \ offset: 0x764 : HPDMA channel 14 control register
$58020790 constant HPDMA_S_HPDMA_C14TR1  \ offset: 0x790 : HPDMA channel 14 transfer register 1
$58020794 constant HPDMA_S_HPDMA_C14TR2  \ offset: 0x794 : HPDMA channel 14 transfer register 2
$58020798 constant HPDMA_S_HPDMA_C14BR1  \ offset: 0x798 : HPDMA channel 14 alternate block register 1
$5802079c constant HPDMA_S_HPDMA_C14SAR  \ offset: 0x79C : HPDMA channel 14 source address register
$580207a0 constant HPDMA_S_HPDMA_C14DAR  \ offset: 0x7A0 : HPDMA channel 14 destination address register
$580207a4 constant HPDMA_S_HPDMA_C14TR3  \ offset: 0x7A4 : HPDMA channel 14 transfer register 3
$580207a8 constant HPDMA_S_HPDMA_C14BR2  \ offset: 0x7A8 : HPDMA channel 14 block register 2
$580207cc constant HPDMA_S_HPDMA_C14LLR  \ offset: 0x7CC : HPDMA channel 14 alternate linked-list address register
$580207d0 constant HPDMA_S_HPDMA_C15LBAR  \ offset: 0x7D0 : HPDMA channel 15 linked-list base address register
$580207d4 constant HPDMA_S_HPDMA_C15CIDCFGR  \ offset: 0x7D4 : HPDMA channel 15 CID register
$580207d8 constant HPDMA_S_HPDMA_C15SEMCR  \ offset: 0x7D8 : HPDMA channel 15 semaphore control register
$580207dc constant HPDMA_S_HPDMA_C15FCR  \ offset: 0x7DC : HPDMA channel 15 flag clear register
$580207e0 constant HPDMA_S_HPDMA_C15SR  \ offset: 0x7E0 : HPDMA channel 15 status register
$580207e4 constant HPDMA_S_HPDMA_C15CR  \ offset: 0x7E4 : HPDMA channel 15 control register
$58020810 constant HPDMA_S_HPDMA_C15TR1  \ offset: 0x810 : HPDMA channel 15 transfer register 1
$58020814 constant HPDMA_S_HPDMA_C15TR2  \ offset: 0x814 : HPDMA channel 15 transfer register 2
$58020818 constant HPDMA_S_HPDMA_C15BR1  \ offset: 0x818 : HPDMA channel 15 alternate block register 1
$5802081c constant HPDMA_S_HPDMA_C15SAR  \ offset: 0x81C : HPDMA channel 15 source address register
$58020820 constant HPDMA_S_HPDMA_C15DAR  \ offset: 0x820 : HPDMA channel 15 destination address register
$58020824 constant HPDMA_S_HPDMA_C15TR3  \ offset: 0x824 : HPDMA channel 15 transfer register 3
$58020828 constant HPDMA_S_HPDMA_C15BR2  \ offset: 0x828 : HPDMA channel 15 block register 2
$5802084c constant HPDMA_S_HPDMA_C15LLR  \ offset: 0x84C : HPDMA channel 15 alternate linked-list address register

