\
\ @file ramcfg.fs
\ @brief RAMCFG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RAMCFG_DEF

  [ifdef] RAMCFG_M1CR_DEF
    \
    \ @brief RAMCFG SRAM x control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECCE
    $04 constant RAMCFG_ALE                     \ [0x04] ALE
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAMER
    $10 constant RAMCFG_WSC                     \ [0x10 : 3] WSC
  [then]


  [ifdef] RAMCFG_M1ISR_DEF
    \
    \ @brief RAMCFG RAMx interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] SEDC
    $01 constant RAMCFG_DED                     \ [0x01] DED
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAMBUSY
  [then]


  [ifdef] RAMCFG_RAM1ERKEYR_DEF
    \
    \ @brief RAMCFG SRAM x erase key register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] ERASEKEY
  [then]


  [ifdef] RAMCFG_M2CR_DEF
    \
    \ @brief RAMCFG SRAM x control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECCE
    $04 constant RAMCFG_ALE                     \ [0x04] ALE
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAMER
    $10 constant RAMCFG_WSC                     \ [0x10 : 3] WSC
  [then]


  [ifdef] RAMCFG_M2IER_DEF
    \
    \ @brief RAMCFG SRAM x interrupt enable register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] SEIE
    $01 constant RAMCFG_DEIE                    \ [0x01] DEIE
    $03 constant RAMCFG_ECCNMI                  \ [0x03] ECCNMI
  [then]


  [ifdef] RAMCFG_M2ISR_DEF
    \
    \ @brief RAMCFG RAMx interrupt status register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] SEDC
    $01 constant RAMCFG_DED                     \ [0x01] DED
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAMBUSY
  [then]


  [ifdef] RAMCFG_M2SEAR_DEF
    \
    \ @brief RAMCFG RAM x ECC single error address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 32] ESEA
  [then]


  [ifdef] RAMCFG_M2DEAR_DEF
    \
    \ @brief RAMCFG RAM x ECC double error address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 32] EDEA
  [then]


  [ifdef] RAMCFG_M2ICR_DEF
    \
    \ @brief RAMCFG RAM x interrupt clear register x
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSEDC                   \ [0x00] CSEDC
    $01 constant RAMCFG_CDED                    \ [0x01] CDED
  [then]


  [ifdef] RAMCFG_M2WPR1_DEF
    \
    \ @brief RAMCFG SRAM2 write protection register 1
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_P0WP                    \ [0x00] P0WP
    $01 constant RAMCFG_P1WP                    \ [0x01] P1WP
    $02 constant RAMCFG_P2WP                    \ [0x02] P2WP
    $03 constant RAMCFG_P3WP                    \ [0x03] P3WP
    $04 constant RAMCFG_P4WP                    \ [0x04] P4WP
    $05 constant RAMCFG_P5WP                    \ [0x05] P5WP
    $06 constant RAMCFG_P6WP                    \ [0x06] P6WP
    $07 constant RAMCFG_P7WP                    \ [0x07] P7WP
    $08 constant RAMCFG_P8WP                    \ [0x08] P8WP
    $09 constant RAMCFG_P9WP                    \ [0x09] P9WP
    $0a constant RAMCFG_P10WP                   \ [0x0a] P10WP
    $0b constant RAMCFG_P11WP                   \ [0x0b] P11WP
    $0c constant RAMCFG_P12WP                   \ [0x0c] P12WP
    $0d constant RAMCFG_P13WP                   \ [0x0d] P13WP
    $0e constant RAMCFG_P14WP                   \ [0x0e] P14WP
    $0f constant RAMCFG_P15WP                   \ [0x0f] P15WP
    $10 constant RAMCFG_P16WP                   \ [0x10] P16WP
    $11 constant RAMCFG_P17WP                   \ [0x11] P17WP
    $12 constant RAMCFG_P18WP                   \ [0x12] P18WP
    $13 constant RAMCFG_P19WP                   \ [0x13] P19WP
    $14 constant RAMCFG_P20WP                   \ [0x14] P20WP
    $15 constant RAMCFG_P21WP                   \ [0x15] P21WP
    $16 constant RAMCFG_P22WP                   \ [0x16] P22WP
    $17 constant RAMCFG_P23WP                   \ [0x17] P23WP
    $18 constant RAMCFG_P24WP                   \ [0x18] P24WP
    $19 constant RAMCFG_P25WP                   \ [0x19] P25WP
    $1a constant RAMCFG_P26WP                   \ [0x1a] P26WP
    $1b constant RAMCFG_P27WP                   \ [0x1b] P27WP
    $1c constant RAMCFG_P28WP                   \ [0x1c] P28WP
    $1d constant RAMCFG_P29WP                   \ [0x1d] P29WP
    $1e constant RAMCFG_P30WP                   \ [0x1e] P30WP
    $1f constant RAMCFG_P31WP                   \ [0x1f] P31WP
  [then]


  [ifdef] RAMCFG_M2WPR2_DEF
    \
    \ @brief RAMCFG SRAM2 write protection register 2
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_P32WP                   \ [0x00] P32WP
    $01 constant RAMCFG_P33WP                   \ [0x01] P33WP
    $02 constant RAMCFG_P34WP                   \ [0x02] P34WP
    $03 constant RAMCFG_P35WP                   \ [0x03] P35WP
    $04 constant RAMCFG_P36WP                   \ [0x04] P36WP
    $05 constant RAMCFG_P37WP                   \ [0x05] P37WP
    $06 constant RAMCFG_P38WP                   \ [0x06] P38WP
    $07 constant RAMCFG_P39WP                   \ [0x07] P39WP
    $08 constant RAMCFG_P40WP                   \ [0x08] P40WP
    $09 constant RAMCFG_P41WP                   \ [0x09] P41WP
    $0a constant RAMCFG_P42WP                   \ [0x0a] P42WP
    $0b constant RAMCFG_P43WP                   \ [0x0b] P43WP
    $0c constant RAMCFG_P44WP                   \ [0x0c] P44WP
    $0d constant RAMCFG_P45WP                   \ [0x0d] P45WP
    $0e constant RAMCFG_P46WP                   \ [0x0e] P46WP
    $0f constant RAMCFG_P47WP                   \ [0x0f] P47WP
    $10 constant RAMCFG_P48WP                   \ [0x10] P48WP
    $11 constant RAMCFG_P49WP                   \ [0x11] P49WP
    $12 constant RAMCFG_P50WP                   \ [0x12] P50WP
    $13 constant RAMCFG_P51WP                   \ [0x13] P51WP
    $14 constant RAMCFG_P52WP                   \ [0x14] P52WP
    $15 constant RAMCFG_P53WP                   \ [0x15] P53WP
    $16 constant RAMCFG_P54WP                   \ [0x16] P54WP
    $17 constant RAMCFG_P55WP                   \ [0x17] P55WP
    $18 constant RAMCFG_P56WP                   \ [0x18] P56WP
    $19 constant RAMCFG_P57WP                   \ [0x19] P57WP
    $1a constant RAMCFG_P58WP                   \ [0x1a] P58WP
    $1b constant RAMCFG_P59WP                   \ [0x1b] P59WP
    $1c constant RAMCFG_P60WP                   \ [0x1c] P60WP
    $1d constant RAMCFG_P61WP                   \ [0x1d] P61WP
    $1e constant RAMCFG_P62WP                   \ [0x1e] P62WP
    $1f constant RAMCFG_P63WP                   \ [0x1f] P63WP
  [then]


  [ifdef] RAMCFG_M2ECCKEYR_DEF
    \
    \ @brief RAMCFG SRAM x ECC key register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECCKEY
  [then]


  [ifdef] RAMCFG_M2ERKEYR_DEF
    \
    \ @brief RAMCFG SRAM x erase key register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] ERASEKEY
  [then]


  [ifdef] RAMCFG_M3CR_DEF
    \
    \ @brief RAMCFG SRAM x control register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECCE
    $04 constant RAMCFG_ALE                     \ [0x04] ALE
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAMER
    $10 constant RAMCFG_WSC                     \ [0x10 : 3] WSC
  [then]


  [ifdef] RAMCFG_M3IER_DEF
    \
    \ @brief RAMCFG SRAM x interrupt enable register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] SEIE
    $01 constant RAMCFG_DEIE                    \ [0x01] DEIE
    $03 constant RAMCFG_ECCNMI                  \ [0x03] ECCNMI
  [then]


  [ifdef] RAMCFG_M3ISR_DEF
    \
    \ @brief RAMCFG RAMx interrupt status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] SEDC
    $01 constant RAMCFG_DED                     \ [0x01] DED
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAMBUSY
  [then]


  [ifdef] RAMCFG_M3SEAR_DEF
    \
    \ @brief RAMCFG RAM x ECC single error address register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 32] ESEA
  [then]


  [ifdef] RAMCFG_M3DEAR_DEF
    \
    \ @brief RAMCFG RAM x ECC double error address register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 32] EDEA
  [then]


  [ifdef] RAMCFG_M3ICR_DEF
    \
    \ @brief RAMCFG RAM x interrupt clear register x
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSEDC                   \ [0x00] CSEDC
    $01 constant RAMCFG_CDED                    \ [0x01] CDED
  [then]


  [ifdef] RAMCFG_M3ECCKEYR_DEF
    \
    \ @brief RAMCFG SRAM x ECC key register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECCKEY
  [then]


  [ifdef] RAMCFG_M3ERKEYR_DEF
    \
    \ @brief RAMCFG SRAM x erase key register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] ERASEKEY
  [then]


  [ifdef] RAMCFG_M4CR_DEF
    \
    \ @brief RAMCFG SRAM x control register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECCE
    $04 constant RAMCFG_ALE                     \ [0x04] ALE
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAMER
    $10 constant RAMCFG_WSC                     \ [0x10 : 3] WSC
  [then]


  [ifdef] RAMCFG_M4ISR_DEF
    \
    \ @brief RAMCFG RAMx interrupt status register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] SEDC
    $01 constant RAMCFG_DED                     \ [0x01] DED
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAMBUSY
  [then]


  [ifdef] RAMCFG_M4ERKEYR_DEF
    \
    \ @brief RAMCFG SRAM x erase key register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] ERASEKEY
  [then]


  [ifdef] RAMCFG_M5CR_DEF
    \
    \ @brief RAMCFG SRAM x control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECCE
    $04 constant RAMCFG_ALE                     \ [0x04] ALE
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAMER
    $10 constant RAMCFG_WSC                     \ [0x10 : 3] WSC
  [then]


  [ifdef] RAMCFG_M5IER_DEF
    \
    \ @brief RAMCFG SRAM x interrupt enable register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] SEIE
    $01 constant RAMCFG_DEIE                    \ [0x01] DEIE
    $03 constant RAMCFG_ECCNMI                  \ [0x03] ECCNMI
  [then]


  [ifdef] RAMCFG_M5ISR_DEF
    \
    \ @brief RAMCFG RAMx interrupt status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] SEDC
    $01 constant RAMCFG_DED                     \ [0x01] DED
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAMBUSY
  [then]


  [ifdef] RAMCFG_M5SEAR_DEF
    \
    \ @brief RAMCFG RAM x ECC single error address register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 32] ESEA
  [then]


  [ifdef] RAMCFG_M5DEAR_DEF
    \
    \ @brief RAMCFG RAM x ECC double error address register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 32] EDEA
  [then]


  [ifdef] RAMCFG_M5ICR_DEF
    \
    \ @brief RAMCFG RAM x interrupt clear register x
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSEDC                   \ [0x00] CSEDC
    $01 constant RAMCFG_CDED                    \ [0x01] CDED
  [then]


  [ifdef] RAMCFG_M5ECCKEYR_DEF
    \
    \ @brief RAMCFG RAM x interrupt clear register x
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECCKEY
  [then]


  [ifdef] RAMCFG_M5ERKEYR_DEF
    \
    \ @brief Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] RAMCFG_M6CR_DEF
    \
    \ @brief memory x control register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECCE
    $04 constant RAMCFG_ALE                     \ [0x04] ALE
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAMER
    $10 constant RAMCFG_WSC                     \ [0x10 : 3] WSC
  [then]


  [ifdef] RAMCFG_M6ISR_DEF
    \
    \ @brief ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1, SRAM4 and SRAM5 interrupt status registers.
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1, SRAM4 and SRAM5 interrupt status registers.
    $01 constant RAMCFG_DED                     \ [0x01] ECC double error detected Note: This bit is reserved and must be kept at reset value in SRAM1, SRAM4 and SRAM5 interrupt status registers.
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation Note: Depending on the SRAM, the erase operation can be performed due to software request, system reset if the option bit is enabled, tamper detection or readout protection regression. Refer to .
  [then]


  [ifdef] RAMCFG_M6ERKEYR_DEF
    \
    \ @brief Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]

  \
  \ @brief RAMCFG
  \
  $00 constant RAMCFG_M1CR              \ RAMCFG SRAM x control register
  $08 constant RAMCFG_M1ISR             \ RAMCFG RAMx interrupt status register
  $28 constant RAMCFG_RAM1ERKEYR        \ RAMCFG SRAM x erase key register
  $40 constant RAMCFG_M2CR              \ RAMCFG SRAM x control register
  $44 constant RAMCFG_M2IER             \ RAMCFG SRAM x interrupt enable register
  $48 constant RAMCFG_M2ISR             \ RAMCFG RAMx interrupt status register
  $4C constant RAMCFG_M2SEAR            \ RAMCFG RAM x ECC single error address register
  $50 constant RAMCFG_M2DEAR            \ RAMCFG RAM x ECC double error address register
  $54 constant RAMCFG_M2ICR             \ RAMCFG RAM x interrupt clear register x
  $58 constant RAMCFG_M2WPR1            \ RAMCFG SRAM2 write protection register 1
  $5C constant RAMCFG_M2WPR2            \ RAMCFG SRAM2 write protection register 2
  $64 constant RAMCFG_M2ECCKEYR         \ RAMCFG SRAM x ECC key register
  $68 constant RAMCFG_M2ERKEYR          \ RAMCFG SRAM x erase key register
  $80 constant RAMCFG_M3CR              \ RAMCFG SRAM x control register
  $84 constant RAMCFG_M3IER             \ RAMCFG SRAM x interrupt enable register
  $88 constant RAMCFG_M3ISR             \ RAMCFG RAMx interrupt status register
  $8C constant RAMCFG_M3SEAR            \ RAMCFG RAM x ECC single error address register
  $90 constant RAMCFG_M3DEAR            \ RAMCFG RAM x ECC double error address register
  $94 constant RAMCFG_M3ICR             \ RAMCFG RAM x interrupt clear register x
  $A4 constant RAMCFG_M3ECCKEYR         \ RAMCFG SRAM x ECC key register
  $A8 constant RAMCFG_M3ERKEYR          \ RAMCFG SRAM x erase key register
  $C0 constant RAMCFG_M4CR              \ RAMCFG SRAM x control register
  $C8 constant RAMCFG_M4ISR             \ RAMCFG RAMx interrupt status register
  $E8 constant RAMCFG_M4ERKEYR          \ RAMCFG SRAM x erase key register
  $100 constant RAMCFG_M5CR             \ RAMCFG SRAM x control register
  $104 constant RAMCFG_M5IER            \ RAMCFG SRAM x interrupt enable register
  $108 constant RAMCFG_M5ISR            \ RAMCFG RAMx interrupt status register
  $10C constant RAMCFG_M5SEAR           \ RAMCFG RAM x ECC single error address register
  $110 constant RAMCFG_M5DEAR           \ RAMCFG RAM x ECC double error address register
  $114 constant RAMCFG_M5ICR            \ RAMCFG RAM x interrupt clear register x
  $124 constant RAMCFG_M5ECCKEYR        \ RAMCFG RAM x interrupt clear register x
  $128 constant RAMCFG_M5ERKEYR         \ Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  $140 constant RAMCFG_M6CR             \ memory x control register
  $148 constant RAMCFG_M6ISR            \ ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1, SRAM4 and SRAM5 interrupt status registers.
  $168 constant RAMCFG_M6ERKEYR         \ Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.

: RAMCFG_DEF ; [then]
