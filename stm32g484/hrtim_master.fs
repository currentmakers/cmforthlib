\
\ @file hrtim_master.fs
\ @brief High Resolution Timer: Master       Timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Master Timer Control Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000007 constant HRTIM_MASTER_MCR_CK_PSC                          \ HRTIM Master Clock prescaler
$00000008 constant HRTIM_MASTER_MCR_CONT                            \ Master Continuous mode
$00000010 constant HRTIM_MASTER_MCR_RETRIG                          \ Master Re-triggerable mode
$00000020 constant HRTIM_MASTER_MCR_HALF                            \ Half mode enable
$000000c0 constant HRTIM_MASTER_MCR_INTLVD                          \ Interleaved mode
$00000300 constant HRTIM_MASTER_MCR_SYNC_IN                         \ synchronization input
$00000400 constant HRTIM_MASTER_MCR_SYNCRSTM                        \ Synchronization Resets Master
$00000800 constant HRTIM_MASTER_MCR_SYNCSTRTM                       \ Synchronization Starts Master
$00003000 constant HRTIM_MASTER_MCR_SYNC_OUT                        \ Synchronization output
$0000c000 constant HRTIM_MASTER_MCR_SYNC_SRC                        \ Synchronization source
$00010000 constant HRTIM_MASTER_MCR_MCEN                            \ Master Counter enable
$00020000 constant HRTIM_MASTER_MCR_TACEN                           \ Timer A counter enable
$00040000 constant HRTIM_MASTER_MCR_TBCEN                           \ Timer B counter enable
$00080000 constant HRTIM_MASTER_MCR_TCCEN                           \ Timer C counter enable
$00100000 constant HRTIM_MASTER_MCR_TDCEN                           \ Timer D counter enable
$00200000 constant HRTIM_MASTER_MCR_TECEN                           \ Timer E counter enable
$00400000 constant HRTIM_MASTER_MCR_TFCEN                           \ Timer F counter enable
$06000000 constant HRTIM_MASTER_MCR_DACSYNC                         \ AC Synchronization
$08000000 constant HRTIM_MASTER_MCR_PREEN                           \ Preload enable
$20000000 constant HRTIM_MASTER_MCR_MREPU                           \ Master Timer Repetition update
$c0000000 constant HRTIM_MASTER_MCR_BRSTDMA                         \ Burst DMA Update


\
\ @brief Master Timer Interrupt Status Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_MASTER_MISR_MCMP1                          \ Master Compare 1 Interrupt Flag
$00000002 constant HRTIM_MASTER_MISR_MCMP2                          \ Master Compare 2 Interrupt Flag
$00000004 constant HRTIM_MASTER_MISR_MCMP3                          \ Master Compare 3 Interrupt Flag
$00000008 constant HRTIM_MASTER_MISR_MCMP4                          \ Master Compare 4 Interrupt Flag
$00000010 constant HRTIM_MASTER_MISR_MREP                           \ Master Repetition Interrupt Flag
$00000020 constant HRTIM_MASTER_MISR_SYNC                           \ Sync Input Interrupt Flag
$00000040 constant HRTIM_MASTER_MISR_MUPD                           \ Master Update Interrupt Flag


\
\ @brief Master Timer Interrupt Clear Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_MASTER_MICR_MCMP1C                         \ Master Compare 1 Interrupt flag clear
$00000002 constant HRTIM_MASTER_MICR_MCMP2C                         \ Master Compare 2 Interrupt flag clear
$00000004 constant HRTIM_MASTER_MICR_MCMP3C                         \ Master Compare 3 Interrupt flag clear
$00000008 constant HRTIM_MASTER_MICR_MCMP4C                         \ Master Compare 4 Interrupt flag clear
$00000010 constant HRTIM_MASTER_MICR_MREPC                          \ Repetition Interrupt flag clear
$00000020 constant HRTIM_MASTER_MICR_SYNCC                          \ Sync Input Interrupt flag clear
$00000040 constant HRTIM_MASTER_MICR_MUPDC                          \ Master update Interrupt flag clear


\
\ @brief HRTIM Master Timer DMA / Interrupt Enable Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_MASTER_MDIER_MCMP1IE                       \ MCMP1IE
$00000002 constant HRTIM_MASTER_MDIER_MCMP2IE                       \ MCMP2IE
$00000004 constant HRTIM_MASTER_MDIER_MCMP3IE                       \ MCMP3IE
$00000008 constant HRTIM_MASTER_MDIER_MCMP4IE                       \ MCMP4IE
$00000010 constant HRTIM_MASTER_MDIER_MREPIE                        \ MREPIE
$00000020 constant HRTIM_MASTER_MDIER_SYNCIE                        \ SYNCIE
$00000040 constant HRTIM_MASTER_MDIER_MUPDIE                        \ MUPDIE
$00010000 constant HRTIM_MASTER_MDIER_MCMP1DE                       \ MCMP1DE
$00020000 constant HRTIM_MASTER_MDIER_MCMP2DE                       \ MCMP2DE
$00040000 constant HRTIM_MASTER_MDIER_MCMP3DE                       \ MCMP3DE
$00080000 constant HRTIM_MASTER_MDIER_MCMP4DE                       \ MCMP4DE
$00100000 constant HRTIM_MASTER_MDIER_MREPDE                        \ MREPDE
$00200000 constant HRTIM_MASTER_MDIER_SYNCDE                        \ SYNCDE
$00400000 constant HRTIM_MASTER_MDIER_MUPDDE                        \ MUPDDE


\
\ @brief Master Timer Counter Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_MASTER_MCNTR_MCNT                          \ Counter value


\
\ @brief Master Timer Period Register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant HRTIM_MASTER_MPER_MPER                           \ Master Timer Period value


\
\ @brief Master Timer Repetition Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HRTIM_MASTER_MREP_MREP                           \ Master Timer Repetition counter value


\
\ @brief Master Timer Compare 1 Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_MASTER_MCMP1R_MCMP1                        \ Master Timer Compare 1 value


\
\ @brief Master Timer Compare 2 Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_MASTER_MCMP2R_MCMP2                        \ Master Timer Compare 2 value


\
\ @brief Master Timer Compare 3 Register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_MASTER_MCMP3R_MCMP3                        \ Master Timer Compare 3 value


\
\ @brief Master Timer Compare 4 Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_MASTER_MCMP4R_MCMP4                        \ Master Timer Compare 4 value


\
\ @brief High Resolution Timer: Master Timers
\
$40016800 constant HRTIM_MASTER_MCR  \ offset: 0x00 : Master Timer Control Register
$40016804 constant HRTIM_MASTER_MISR  \ offset: 0x04 : Master Timer Interrupt Status Register
$40016808 constant HRTIM_MASTER_MICR  \ offset: 0x08 : Master Timer Interrupt Clear Register
$4001680c constant HRTIM_MASTER_MDIER  \ offset: 0x0C : HRTIM Master Timer DMA / Interrupt Enable Register
$40016810 constant HRTIM_MASTER_MCNTR  \ offset: 0x10 : Master Timer Counter Register
$40016814 constant HRTIM_MASTER_MPER  \ offset: 0x14 : Master Timer Period Register
$40016818 constant HRTIM_MASTER_MREP  \ offset: 0x18 : Master Timer Repetition Register
$4001681c constant HRTIM_MASTER_MCMP1R  \ offset: 0x1C : Master Timer Compare 1 Register
$40016824 constant HRTIM_MASTER_MCMP2R  \ offset: 0x24 : Master Timer Compare 2 Register
$40016828 constant HRTIM_MASTER_MCMP3R  \ offset: 0x28 : Master Timer Compare 3 Register
$4001682c constant HRTIM_MASTER_MCMP4R  \ offset: 0x2C : Master Timer Compare 4 Register

