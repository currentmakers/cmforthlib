\
\ @file etzpc.fs
\ @brief ETZPC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETZPC_DEF

  [ifdef] ETZPC_ETZPC_TZMA0_SIZE_DEF
    \
    \ @brief ETZPC ROM secure size definition
    \ Address offset: 0x00
    \ Reset value: 0x000003FF
    \
    $00 constant ETZPC_R0SIZE                   \ [0x00 : 10] R0SIZE
    $1f constant ETZPC_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] ETZPC_ETZPC_TZMA1_SIZE_DEF
    \
    \ @brief ETZPC RAM secure size definition
    \ Address offset: 0x04
    \ Reset value: 0x000003FF
    \
    $00 constant ETZPC_R0SIZE                   \ [0x00 : 10] R0SIZE
    $1f constant ETZPC_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] ETZPC_ETZPC_DECPROT0_DEF
    \
    \ @brief Register reset values
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ETZPC_DECPROT0                 \ [0x00 : 2] DECPROT0
    $02 constant ETZPC_DECPROT1                 \ [0x02 : 2] DECPROT1
    $04 constant ETZPC_DECPROT2                 \ [0x04 : 2] DECPROT2
    $06 constant ETZPC_DECPROT3                 \ [0x06 : 2] DECPROT3
    $08 constant ETZPC_DECPROT4                 \ [0x08 : 2] DECPROT4
    $0a constant ETZPC_DECPROT5                 \ [0x0a : 2] DECPROT5
    $0c constant ETZPC_DECPROT6                 \ [0x0c : 2] DECPROT6
    $0e constant ETZPC_DECPROT7                 \ [0x0e : 2] DECPROT7
    $10 constant ETZPC_DECPROT8                 \ [0x10 : 2] DECPROT8
    $12 constant ETZPC_DECPROT9                 \ [0x12 : 2] DECPROT9
    $14 constant ETZPC_DECPROT10                \ [0x14 : 2] DECPROT10
    $16 constant ETZPC_DECPROT11                \ [0x16 : 2] DECPROT11
    $18 constant ETZPC_DECPROT12                \ [0x18 : 2] DECPROT12
    $1a constant ETZPC_DECPROT13                \ [0x1a : 2] DECPROT13
    $1c constant ETZPC_DECPROT14                \ [0x1c : 2] DECPROT14
    $1e constant ETZPC_DECPROT15                \ [0x1e : 2] DECPROT15
  [then]


  [ifdef] ETZPC_ETZPC_DECPROT1_DEF
    \
    \ @brief Register reset values
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ETZPC_DECPROT0                 \ [0x00 : 2] DECPROT0
    $02 constant ETZPC_DECPROT1                 \ [0x02 : 2] DECPROT1
    $04 constant ETZPC_DECPROT2                 \ [0x04 : 2] DECPROT2
    $06 constant ETZPC_DECPROT3                 \ [0x06 : 2] DECPROT3
    $08 constant ETZPC_DECPROT4                 \ [0x08 : 2] DECPROT4
    $0a constant ETZPC_DECPROT5                 \ [0x0a : 2] DECPROT5
    $0c constant ETZPC_DECPROT6                 \ [0x0c : 2] DECPROT6
    $0e constant ETZPC_DECPROT7                 \ [0x0e : 2] DECPROT7
    $10 constant ETZPC_DECPROT8                 \ [0x10 : 2] DECPROT8
    $12 constant ETZPC_DECPROT9                 \ [0x12 : 2] DECPROT9
    $14 constant ETZPC_DECPROT10                \ [0x14 : 2] DECPROT10
    $16 constant ETZPC_DECPROT11                \ [0x16 : 2] DECPROT11
    $18 constant ETZPC_DECPROT12                \ [0x18 : 2] DECPROT12
    $1a constant ETZPC_DECPROT13                \ [0x1a : 2] DECPROT13
    $1c constant ETZPC_DECPROT14                \ [0x1c : 2] DECPROT14
    $1e constant ETZPC_DECPROT15                \ [0x1e : 2] DECPROT15
  [then]


  [ifdef] ETZPC_ETZPC_DECPROT2_DEF
    \
    \ @brief Register reset values
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ETZPC_DECPROT0                 \ [0x00 : 2] DECPROT0
    $02 constant ETZPC_DECPROT1                 \ [0x02 : 2] DECPROT1
    $04 constant ETZPC_DECPROT2                 \ [0x04 : 2] DECPROT2
    $06 constant ETZPC_DECPROT3                 \ [0x06 : 2] DECPROT3
    $08 constant ETZPC_DECPROT4                 \ [0x08 : 2] DECPROT4
    $0a constant ETZPC_DECPROT5                 \ [0x0a : 2] DECPROT5
    $0c constant ETZPC_DECPROT6                 \ [0x0c : 2] DECPROT6
    $0e constant ETZPC_DECPROT7                 \ [0x0e : 2] DECPROT7
    $10 constant ETZPC_DECPROT8                 \ [0x10 : 2] DECPROT8
    $12 constant ETZPC_DECPROT9                 \ [0x12 : 2] DECPROT9
    $14 constant ETZPC_DECPROT10                \ [0x14 : 2] DECPROT10
    $16 constant ETZPC_DECPROT11                \ [0x16 : 2] DECPROT11
    $18 constant ETZPC_DECPROT12                \ [0x18 : 2] DECPROT12
    $1a constant ETZPC_DECPROT13                \ [0x1a : 2] DECPROT13
    $1c constant ETZPC_DECPROT14                \ [0x1c : 2] DECPROT14
    $1e constant ETZPC_DECPROT15                \ [0x1e : 2] DECPROT15
  [then]


  [ifdef] ETZPC_ETZPC_DECPROT3_DEF
    \
    \ @brief Register reset values
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ETZPC_DECPROT0                 \ [0x00 : 2] DECPROT0
    $02 constant ETZPC_DECPROT1                 \ [0x02 : 2] DECPROT1
    $04 constant ETZPC_DECPROT2                 \ [0x04 : 2] DECPROT2
    $06 constant ETZPC_DECPROT3                 \ [0x06 : 2] DECPROT3
    $08 constant ETZPC_DECPROT4                 \ [0x08 : 2] DECPROT4
    $0a constant ETZPC_DECPROT5                 \ [0x0a : 2] DECPROT5
    $0c constant ETZPC_DECPROT6                 \ [0x0c : 2] DECPROT6
    $0e constant ETZPC_DECPROT7                 \ [0x0e : 2] DECPROT7
    $10 constant ETZPC_DECPROT8                 \ [0x10 : 2] DECPROT8
    $12 constant ETZPC_DECPROT9                 \ [0x12 : 2] DECPROT9
    $14 constant ETZPC_DECPROT10                \ [0x14 : 2] DECPROT10
    $16 constant ETZPC_DECPROT11                \ [0x16 : 2] DECPROT11
    $18 constant ETZPC_DECPROT12                \ [0x18 : 2] DECPROT12
    $1a constant ETZPC_DECPROT13                \ [0x1a : 2] DECPROT13
    $1c constant ETZPC_DECPROT14                \ [0x1c : 2] DECPROT14
    $1e constant ETZPC_DECPROT15                \ [0x1e : 2] DECPROT15
  [then]


  [ifdef] ETZPC_ETZPC_DECPROT4_DEF
    \
    \ @brief Register reset values
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ETZPC_DECPROT0                 \ [0x00 : 2] DECPROT0
    $02 constant ETZPC_DECPROT1                 \ [0x02 : 2] DECPROT1
    $04 constant ETZPC_DECPROT2                 \ [0x04 : 2] DECPROT2
    $06 constant ETZPC_DECPROT3                 \ [0x06 : 2] DECPROT3
    $08 constant ETZPC_DECPROT4                 \ [0x08 : 2] DECPROT4
    $0a constant ETZPC_DECPROT5                 \ [0x0a : 2] DECPROT5
    $0c constant ETZPC_DECPROT6                 \ [0x0c : 2] DECPROT6
    $0e constant ETZPC_DECPROT7                 \ [0x0e : 2] DECPROT7
    $10 constant ETZPC_DECPROT8                 \ [0x10 : 2] DECPROT8
    $12 constant ETZPC_DECPROT9                 \ [0x12 : 2] DECPROT9
    $14 constant ETZPC_DECPROT10                \ [0x14 : 2] DECPROT10
    $16 constant ETZPC_DECPROT11                \ [0x16 : 2] DECPROT11
    $18 constant ETZPC_DECPROT12                \ [0x18 : 2] DECPROT12
    $1a constant ETZPC_DECPROT13                \ [0x1a : 2] DECPROT13
    $1c constant ETZPC_DECPROT14                \ [0x1c : 2] DECPROT14
    $1e constant ETZPC_DECPROT15                \ [0x1e : 2] DECPROT15
  [then]


  [ifdef] ETZPC_ETZPC_DECPROT5_DEF
    \
    \ @brief Register reset values
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant ETZPC_DECPROT0                 \ [0x00 : 2] DECPROT0
    $02 constant ETZPC_DECPROT1                 \ [0x02 : 2] DECPROT1
    $04 constant ETZPC_DECPROT2                 \ [0x04 : 2] DECPROT2
    $06 constant ETZPC_DECPROT3                 \ [0x06 : 2] DECPROT3
    $08 constant ETZPC_DECPROT4                 \ [0x08 : 2] DECPROT4
    $0a constant ETZPC_DECPROT5                 \ [0x0a : 2] DECPROT5
    $0c constant ETZPC_DECPROT6                 \ [0x0c : 2] DECPROT6
    $0e constant ETZPC_DECPROT7                 \ [0x0e : 2] DECPROT7
    $10 constant ETZPC_DECPROT8                 \ [0x10 : 2] DECPROT8
    $12 constant ETZPC_DECPROT9                 \ [0x12 : 2] DECPROT9
    $14 constant ETZPC_DECPROT10                \ [0x14 : 2] DECPROT10
    $16 constant ETZPC_DECPROT11                \ [0x16 : 2] DECPROT11
    $18 constant ETZPC_DECPROT12                \ [0x18 : 2] DECPROT12
    $1a constant ETZPC_DECPROT13                \ [0x1a : 2] DECPROT13
    $1c constant ETZPC_DECPROT14                \ [0x1c : 2] DECPROT14
    $1e constant ETZPC_DECPROT15                \ [0x1e : 2] DECPROT15
  [then]


  [ifdef] ETZPC_ETZPC_DECPROT_LOCK0_DEF
    \
    \ @brief ETZPC decprot lock 0 register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ETZPC_LOCK0                    \ [0x00] LOCK0
    $01 constant ETZPC_LOCK1                    \ [0x01] LOCK1
    $02 constant ETZPC_LOCK2                    \ [0x02] LOCK2
    $03 constant ETZPC_LOCK3                    \ [0x03] LOCK3
    $04 constant ETZPC_LOCK4                    \ [0x04] LOCK4
    $05 constant ETZPC_LOCK5                    \ [0x05] LOCK5
    $06 constant ETZPC_LOCK6                    \ [0x06] LOCK6
    $07 constant ETZPC_LOCK7                    \ [0x07] LOCK7
    $08 constant ETZPC_LOCK8                    \ [0x08] LOCK8
    $09 constant ETZPC_LOCK9                    \ [0x09] LOCK9
    $0a constant ETZPC_LOCK10                   \ [0x0a] LOCK10
    $0b constant ETZPC_LOCK11                   \ [0x0b] LOCK11
    $0c constant ETZPC_LOCK12                   \ [0x0c] LOCK12
    $0d constant ETZPC_LOCK13                   \ [0x0d] LOCK13
    $0e constant ETZPC_LOCK14                   \ [0x0e] LOCK14
    $0f constant ETZPC_LOCK15                   \ [0x0f] LOCK15
    $10 constant ETZPC_LOCK16                   \ [0x10] LOCK16
    $11 constant ETZPC_LOCK17                   \ [0x11] LOCK17
    $12 constant ETZPC_LOCK18                   \ [0x12] LOCK18
    $13 constant ETZPC_LOCK19                   \ [0x13] LOCK19
    $14 constant ETZPC_LOCK20                   \ [0x14] LOCK20
    $15 constant ETZPC_LOCK21                   \ [0x15] LOCK21
    $16 constant ETZPC_LOCK22                   \ [0x16] LOCK22
    $17 constant ETZPC_LOCK23                   \ [0x17] LOCK23
    $18 constant ETZPC_LOCK24                   \ [0x18] LOCK24
    $19 constant ETZPC_LOCK25                   \ [0x19] LOCK25
    $1a constant ETZPC_LOCK26                   \ [0x1a] LOCK26
    $1b constant ETZPC_LOCK27                   \ [0x1b] LOCK27
    $1c constant ETZPC_LOCK28                   \ [0x1c] LOCK28
    $1d constant ETZPC_LOCK29                   \ [0x1d] LOCK29
    $1e constant ETZPC_LOCK30                   \ [0x1e] LOCK30
    $1f constant ETZPC_LOCK31                   \ [0x1f] LOCK31
  [then]


  [ifdef] ETZPC_ETZPC_DECPROT_LOCK1_DEF
    \
    \ @brief ETZPC decprot lock 1 register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ETZPC_LOCK0                    \ [0x00] LOCK0
    $01 constant ETZPC_LOCK1                    \ [0x01] LOCK1
    $02 constant ETZPC_LOCK2                    \ [0x02] LOCK2
    $03 constant ETZPC_LOCK3                    \ [0x03] LOCK3
    $04 constant ETZPC_LOCK4                    \ [0x04] LOCK4
    $05 constant ETZPC_LOCK5                    \ [0x05] LOCK5
    $06 constant ETZPC_LOCK6                    \ [0x06] LOCK6
    $07 constant ETZPC_LOCK7                    \ [0x07] LOCK7
    $08 constant ETZPC_LOCK8                    \ [0x08] LOCK8
    $09 constant ETZPC_LOCK9                    \ [0x09] LOCK9
    $0a constant ETZPC_LOCK10                   \ [0x0a] LOCK10
    $0b constant ETZPC_LOCK11                   \ [0x0b] LOCK11
    $0c constant ETZPC_LOCK12                   \ [0x0c] LOCK12
    $0d constant ETZPC_LOCK13                   \ [0x0d] LOCK13
    $0e constant ETZPC_LOCK14                   \ [0x0e] LOCK14
    $0f constant ETZPC_LOCK15                   \ [0x0f] LOCK15
    $10 constant ETZPC_LOCK16                   \ [0x10] LOCK16
    $11 constant ETZPC_LOCK17                   \ [0x11] LOCK17
    $12 constant ETZPC_LOCK18                   \ [0x12] LOCK18
    $13 constant ETZPC_LOCK19                   \ [0x13] LOCK19
    $14 constant ETZPC_LOCK20                   \ [0x14] LOCK20
    $15 constant ETZPC_LOCK21                   \ [0x15] LOCK21
    $16 constant ETZPC_LOCK22                   \ [0x16] LOCK22
    $17 constant ETZPC_LOCK23                   \ [0x17] LOCK23
    $18 constant ETZPC_LOCK24                   \ [0x18] LOCK24
    $19 constant ETZPC_LOCK25                   \ [0x19] LOCK25
    $1a constant ETZPC_LOCK26                   \ [0x1a] LOCK26
    $1b constant ETZPC_LOCK27                   \ [0x1b] LOCK27
    $1c constant ETZPC_LOCK28                   \ [0x1c] LOCK28
    $1d constant ETZPC_LOCK29                   \ [0x1d] LOCK29
    $1e constant ETZPC_LOCK30                   \ [0x1e] LOCK30
    $1f constant ETZPC_LOCK31                   \ [0x1f] LOCK31
  [then]


  [ifdef] ETZPC_ETZPC_DECPROT_LOCK2_DEF
    \
    \ @brief ETZPC decprot lock 2 register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ETZPC_LOCK0                    \ [0x00] LOCK0
    $01 constant ETZPC_LOCK1                    \ [0x01] LOCK1
    $02 constant ETZPC_LOCK2                    \ [0x02] LOCK2
    $03 constant ETZPC_LOCK3                    \ [0x03] LOCK3
    $04 constant ETZPC_LOCK4                    \ [0x04] LOCK4
    $05 constant ETZPC_LOCK5                    \ [0x05] LOCK5
    $06 constant ETZPC_LOCK6                    \ [0x06] LOCK6
    $07 constant ETZPC_LOCK7                    \ [0x07] LOCK7
    $08 constant ETZPC_LOCK8                    \ [0x08] LOCK8
    $09 constant ETZPC_LOCK9                    \ [0x09] LOCK9
    $0a constant ETZPC_LOCK10                   \ [0x0a] LOCK10
    $0b constant ETZPC_LOCK11                   \ [0x0b] LOCK11
    $0c constant ETZPC_LOCK12                   \ [0x0c] LOCK12
    $0d constant ETZPC_LOCK13                   \ [0x0d] LOCK13
    $0e constant ETZPC_LOCK14                   \ [0x0e] LOCK14
    $0f constant ETZPC_LOCK15                   \ [0x0f] LOCK15
    $10 constant ETZPC_LOCK16                   \ [0x10] LOCK16
    $11 constant ETZPC_LOCK17                   \ [0x11] LOCK17
    $12 constant ETZPC_LOCK18                   \ [0x12] LOCK18
    $13 constant ETZPC_LOCK19                   \ [0x13] LOCK19
    $14 constant ETZPC_LOCK20                   \ [0x14] LOCK20
    $15 constant ETZPC_LOCK21                   \ [0x15] LOCK21
    $16 constant ETZPC_LOCK22                   \ [0x16] LOCK22
    $17 constant ETZPC_LOCK23                   \ [0x17] LOCK23
    $18 constant ETZPC_LOCK24                   \ [0x18] LOCK24
    $19 constant ETZPC_LOCK25                   \ [0x19] LOCK25
    $1a constant ETZPC_LOCK26                   \ [0x1a] LOCK26
    $1b constant ETZPC_LOCK27                   \ [0x1b] LOCK27
    $1c constant ETZPC_LOCK28                   \ [0x1c] LOCK28
    $1d constant ETZPC_LOCK29                   \ [0x1d] LOCK29
    $1e constant ETZPC_LOCK30                   \ [0x1e] LOCK30
    $1f constant ETZPC_LOCK31                   \ [0x1f] LOCK31
  [then]


  [ifdef] ETZPC_ETZPC_HWCFGR_DEF
    \
    \ @brief ETZPC IP HW configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00006002
    \
    $00 constant ETZPC_NUM_TZMA                 \ [0x00 : 8] NUM_TZMA
    $08 constant ETZPC_NUM_PER_SEC              \ [0x08 : 8] NUM_PER_SEC
    $10 constant ETZPC_NUM_AHB_SEC              \ [0x10 : 8] NUM_AHB_SEC
    $18 constant ETZPC_CHUNKS1N4                \ [0x18 : 8] CHUNKS1N4
  [then]


  [ifdef] ETZPC_ETZPC_VERR_DEF
    \
    \ @brief ETZPC IP version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000020
    \
    $00 constant ETZPC_MINREV                   \ [0x00 : 4] MINREV
    $04 constant ETZPC_MAJREV                   \ [0x04 : 4] MAJREV
  [then]


  [ifdef] ETZPC_ETZPC_IDR_DEF
    \
    \ @brief ETZPC IP version register
    \ Address offset: 0x3F8
    \ Reset value: 0x00100061
    \
    $00 constant ETZPC_ID                       \ [0x00 : 32] ID
  [then]


  [ifdef] ETZPC_ETZPC_SIDR_DEF
    \
    \ @brief ETZPC IP version register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant ETZPC_SID                      \ [0x00 : 32] SID
  [then]

  \
  \ @brief ETZPC
  \
  $00 constant ETZPC_ETZPC_TZMA0_SIZE   \ ETZPC ROM secure size definition
  $04 constant ETZPC_ETZPC_TZMA1_SIZE   \ ETZPC RAM secure size definition
  $10 constant ETZPC_ETZPC_DECPROT0     \ Register reset values
  $14 constant ETZPC_ETZPC_DECPROT1     \ Register reset values
  $18 constant ETZPC_ETZPC_DECPROT2     \ Register reset values
  $1C constant ETZPC_ETZPC_DECPROT3     \ Register reset values
  $20 constant ETZPC_ETZPC_DECPROT4     \ Register reset values
  $24 constant ETZPC_ETZPC_DECPROT5     \ Register reset values
  $30 constant ETZPC_ETZPC_DECPROT_LOCK0    \ ETZPC decprot lock 0 register
  $34 constant ETZPC_ETZPC_DECPROT_LOCK1    \ ETZPC decprot lock 1 register
  $38 constant ETZPC_ETZPC_DECPROT_LOCK2    \ ETZPC decprot lock 2 register
  $3F0 constant ETZPC_ETZPC_HWCFGR      \ ETZPC IP HW configuration register
  $3F4 constant ETZPC_ETZPC_VERR        \ ETZPC IP version register
  $3F8 constant ETZPC_ETZPC_IDR         \ ETZPC IP version register
  $3FC constant ETZPC_ETZPC_SIDR        \ ETZPC IP version register

: ETZPC_DEF ; [then]
