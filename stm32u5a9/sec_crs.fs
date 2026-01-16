\
\ @file sec_crs.fs
\ @brief Clock recovery system
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00004000
\

$00000001 constant SEC_CRS_CR_SYNCOKIE                              \ SYNC event OK interrupt enable
$00000002 constant SEC_CRS_CR_SYNCWARNIE                            \ SYNC warning interrupt enable
$00000004 constant SEC_CRS_CR_ERRIE                                 \ Synchronization or trimming error interrupt enable
$00000008 constant SEC_CRS_CR_ESYNCIE                               \ Expected SYNC interrupt enable
$00000020 constant SEC_CRS_CR_CEN                                   \ Frequency error counter enable
$00000040 constant SEC_CRS_CR_AUTOTRIMEN                            \ Automatic trimming enable
$00000080 constant SEC_CRS_CR_SWSYNC                                \ Generate software SYNC event
$00007f00 constant SEC_CRS_CR_TRIM                                  \ HSI48 oscillator smooth trimming


\
\ @brief configuration register
\ Address offset: 0x04
\ Reset value: 0x2022BB7F
\

$0000ffff constant SEC_CRS_CFGR_RELOAD                              \ Counter reload value
$00ff0000 constant SEC_CRS_CFGR_FELIM                               \ Frequency error limit
$07000000 constant SEC_CRS_CFGR_SYNCDIV                             \ SYNC divider
$30000000 constant SEC_CRS_CFGR_SYNCSRC                             \ SYNC signal source selection
$80000000 constant SEC_CRS_CFGR_SYNCPOL                             \ SYNC polarity selection


\
\ @brief interrupt and status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_CRS_ISR_SYNCOKF                              \ SYNC event OK flag
$00000002 constant SEC_CRS_ISR_SYNCWARNF                            \ SYNC warning flag
$00000004 constant SEC_CRS_ISR_ERRF                                 \ Error flag
$00000008 constant SEC_CRS_ISR_ESYNCF                               \ Expected SYNC flag
$00000100 constant SEC_CRS_ISR_SYNCERR                              \ SYNC error
$00000200 constant SEC_CRS_ISR_SYNCMISS                             \ SYNC missed
$00000400 constant SEC_CRS_ISR_TRIMOVF                              \ Trimming overflow or underflow
$00008000 constant SEC_CRS_ISR_FEDIR                                \ Frequency error direction
$ffff0000 constant SEC_CRS_ISR_FECAP                                \ Frequency error capture


\
\ @brief interrupt flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_CRS_ICR_SYNCOKC                              \ SYNC event OK clear flag
$00000002 constant SEC_CRS_ICR_SYNCWARNC                            \ SYNC warning clear flag
$00000004 constant SEC_CRS_ICR_ERRC                                 \ Error clear flag
$00000008 constant SEC_CRS_ICR_ESYNCC                               \ Expected SYNC clear flag


\
\ @brief Clock recovery system
\
$50006000 constant SEC_CRS_CR     \ offset: 0x00 : control register
$50006004 constant SEC_CRS_CFGR   \ offset: 0x04 : configuration register
$50006008 constant SEC_CRS_ISR    \ offset: 0x08 : interrupt and status register
$5000600c constant SEC_CRS_ICR    \ offset: 0x0C : interrupt flag clear register

