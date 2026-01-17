\
\ @file hrtim_master.fs
\ @brief High Resolution Timer: Master Timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HRTIM_MASTER_DEF

  [ifdef] HRTIM_MASTER_MCR_DEF
    \
    \ @brief Master Timer Control Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_CK_PSC            \ [0x00 : 3] HRTIM Master Clock prescaler
    $03 constant HRTIM_MASTER_CONT              \ [0x03] Master Continuous mode
    $04 constant HRTIM_MASTER_RETRIG            \ [0x04] Master Re-triggerable mode
    $05 constant HRTIM_MASTER_HALF              \ [0x05] Half mode enable
    $08 constant HRTIM_MASTER_SYNC_IN           \ [0x08 : 2] ynchronization input
    $0a constant HRTIM_MASTER_SYNCRSTM          \ [0x0a] Synchronization Resets Master
    $0b constant HRTIM_MASTER_SYNCSTRTM         \ [0x0b] Synchronization Starts Master
    $0c constant HRTIM_MASTER_SYNC_OUT          \ [0x0c : 2] Synchronization output
    $0e constant HRTIM_MASTER_SYNC_SRC          \ [0x0e : 2] Synchronization source
    $10 constant HRTIM_MASTER_MCEN              \ [0x10] Master Counter enable
    $11 constant HRTIM_MASTER_TACEN             \ [0x11] Timer A counter enable
    $12 constant HRTIM_MASTER_TBCEN             \ [0x12] Timer B counter enable
    $13 constant HRTIM_MASTER_TCCEN             \ [0x13] Timer C counter enable
    $14 constant HRTIM_MASTER_TDCEN             \ [0x14] Timer D counter enable
    $15 constant HRTIM_MASTER_TECEN             \ [0x15] Timer E counter enable
    $19 constant HRTIM_MASTER_DACSYNC           \ [0x19 : 2] AC Synchronization
    $1b constant HRTIM_MASTER_PREEN             \ [0x1b] Preload enable
    $1d constant HRTIM_MASTER_MREPU             \ [0x1d] Master Timer Repetition update
    $1e constant HRTIM_MASTER_BRSTDMA           \ [0x1e : 2] Burst DMA Update
  [then]


  [ifdef] HRTIM_MASTER_MISR_DEF
    \
    \ @brief Master Timer Interrupt Status Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_MCMP1             \ [0x00] Master Compare 1 Interrupt Flag
    $01 constant HRTIM_MASTER_MCMP2             \ [0x01] Master Compare 2 Interrupt Flag
    $02 constant HRTIM_MASTER_MCMP3             \ [0x02] Master Compare 3 Interrupt Flag
    $03 constant HRTIM_MASTER_MCMP4             \ [0x03] Master Compare 4 Interrupt Flag
    $04 constant HRTIM_MASTER_MREP              \ [0x04] Master Repetition Interrupt Flag
    $05 constant HRTIM_MASTER_SYNC              \ [0x05] Sync Input Interrupt Flag
    $06 constant HRTIM_MASTER_MUPD              \ [0x06] Master Update Interrupt Flag
  [then]


  [ifdef] HRTIM_MASTER_MICR_DEF
    \
    \ @brief Master Timer Interrupt Clear Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_MCMP1C            \ [0x00] Master Compare 1 Interrupt flag clear
    $01 constant HRTIM_MASTER_MCMP2C            \ [0x01] Master Compare 2 Interrupt flag clear
    $02 constant HRTIM_MASTER_MCMP3C            \ [0x02] Master Compare 3 Interrupt flag clear
    $03 constant HRTIM_MASTER_MCMP4C            \ [0x03] Master Compare 4 Interrupt flag clear
    $04 constant HRTIM_MASTER_MREPC             \ [0x04] Repetition Interrupt flag clear
    $05 constant HRTIM_MASTER_SYNCC             \ [0x05] Sync Input Interrupt flag clear
    $06 constant HRTIM_MASTER_MUPDC             \ [0x06] Master update Interrupt flag clear
  [then]


  [ifdef] HRTIM_MASTER_MDIER4_DEF
    \
    \ @brief MDIER4
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_MCMP1IE           \ [0x00] MCMP1IE
    $01 constant HRTIM_MASTER_MCMP2IE           \ [0x01] MCMP2IE
    $02 constant HRTIM_MASTER_MCMP3IE           \ [0x02] MCMP3IE
    $03 constant HRTIM_MASTER_MCMP4IE           \ [0x03] MCMP4IE
    $04 constant HRTIM_MASTER_MREPIE            \ [0x04] MREPIE
    $05 constant HRTIM_MASTER_SYNCIE            \ [0x05] SYNCIE
    $06 constant HRTIM_MASTER_MUPDIE            \ [0x06] MUPDIE
    $10 constant HRTIM_MASTER_MCMP1DE           \ [0x10] MCMP1DE
    $11 constant HRTIM_MASTER_MCMP2DE           \ [0x11] MCMP2DE
    $12 constant HRTIM_MASTER_MCMP3DE           \ [0x12] MCMP3DE
    $13 constant HRTIM_MASTER_MCMP4DE           \ [0x13] MCMP4DE
    $14 constant HRTIM_MASTER_MREPDE            \ [0x14] MREPDE
    $15 constant HRTIM_MASTER_SYNCDE            \ [0x15] SYNCDE
    $16 constant HRTIM_MASTER_MUPDDE            \ [0x16] MUPDDE
  [then]


  [ifdef] HRTIM_MASTER_MCNTR_DEF
    \
    \ @brief Master Timer Counter Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_MCNT              \ [0x00 : 16] Counter value
  [then]


  [ifdef] HRTIM_MASTER_MPER_DEF
    \
    \ @brief Master Timer Period Register
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant HRTIM_MASTER_MPER              \ [0x00 : 16] Master Timer Period value
  [then]


  [ifdef] HRTIM_MASTER_MREP_DEF
    \
    \ @brief Master Timer Repetition Register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_MREP              \ [0x00 : 8] Master Timer Repetition counter value
  [then]


  [ifdef] HRTIM_MASTER_MCMP1R_DEF
    \
    \ @brief Master Timer Compare 1 Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_MCMP1             \ [0x00 : 16] Master Timer Compare 1 value
  [then]


  [ifdef] HRTIM_MASTER_MCMP2R_DEF
    \
    \ @brief Master Timer Compare 2 Register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_MCMP2             \ [0x00 : 16] Master Timer Compare 2 value
  [then]


  [ifdef] HRTIM_MASTER_MCMP3R_DEF
    \
    \ @brief Master Timer Compare 3 Register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_MCMP3             \ [0x00 : 16] Master Timer Compare 3 value
  [then]


  [ifdef] HRTIM_MASTER_MCMP4R_DEF
    \
    \ @brief Master Timer Compare 4 Register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_MASTER_MCMP4             \ [0x00 : 16] Master Timer Compare 4 value
  [then]

  \
  \ @brief High Resolution Timer: Master Timers
  \
  $00 constant HRTIM_MASTER_MCR         \ Master Timer Control Register
  $04 constant HRTIM_MASTER_MISR        \ Master Timer Interrupt Status Register
  $08 constant HRTIM_MASTER_MICR        \ Master Timer Interrupt Clear Register
  $0C constant HRTIM_MASTER_MDIER4      \ MDIER4
  $10 constant HRTIM_MASTER_MCNTR       \ Master Timer Counter Register
  $14 constant HRTIM_MASTER_MPER        \ Master Timer Period Register
  $18 constant HRTIM_MASTER_MREP        \ Master Timer Repetition Register
  $1C constant HRTIM_MASTER_MCMP1R      \ Master Timer Compare 1 Register
  $24 constant HRTIM_MASTER_MCMP2R      \ Master Timer Compare 2 Register
  $28 constant HRTIM_MASTER_MCMP3R      \ Master Timer Compare 3 Register
  $2C constant HRTIM_MASTER_MCMP4R      \ Master Timer Compare 4 Register

: HRTIM_MASTER_DEF ; [then]
