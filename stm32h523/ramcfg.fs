\
\ @file ramcfg.fs
\ @brief RAMCFG address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RAMCFG_DEF

  [ifdef] RAMCFG_RAMCFG_M1CR_DEF
    \
    \ @brief RAMCFG memory 1 control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECC enable.
    $04 constant RAMCFG_ALE                     \ [0x04] Address latch enable
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
  [then]


  [ifdef] RAMCFG_RAMCFG_M1ISR_DEF
    \
    \ @brief RAMCFG memory interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] ECC single error detected and corrected
    $01 constant RAMCFG_DED                     \ [0x01] ECC double error detected
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_M1ERKEYR_DEF
    \
    \ @brief RAMCFG memory 1 erase key register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_M2CR_DEF
    \
    \ @brief RAMCFG memory 2 control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECC enable.
    $04 constant RAMCFG_ALE                     \ [0x04] Address latch enable
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
  [then]


  [ifdef] RAMCFG_RAMCFG_M2IER_DEF
    \
    \ @brief RAMCFG memory 2 interrupt enable register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] ECC single error interrupt enable
    $01 constant RAMCFG_DEIE                    \ [0x01] ECC double error interrupt enable
    $03 constant RAMCFG_ECCNMI                  \ [0x03] Double error NMI
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ISR_DEF
    \
    \ @brief RAMCFG memory interrupt status register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] ECC single error detected and corrected
    $01 constant RAMCFG_DED                     \ [0x01] ECC double error detected
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_M2SEAR_DEF
    \
    \ @brief RAMCFG memory 2 ECC single error address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 32] ECC single error address
  [then]


  [ifdef] RAMCFG_RAMCFG_M2DEAR_DEF
    \
    \ @brief RAMCFG memory 2 ECC double error address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 32] ECC double error address
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ICR_DEF
    \
    \ @brief RAMCFG memory 2 interrupt clear register 2
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSEDC                   \ [0x00] Clear ECC single error detected and corrected
    $01 constant RAMCFG_CDED                    \ [0x01] Clear ECC double error detected
  [then]


  [ifdef] RAMCFG_RAMCFG_M2WPR1_DEF
    \
    \ @brief RAMCFG memory 2 write protection register 1
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_P0WP                    \ [0x00] SRAM2 1-Kbyte page y write protection
    $01 constant RAMCFG_P1WP                    \ [0x01] SRAM2 1-Kbyte page y write protection
    $02 constant RAMCFG_P2WP                    \ [0x02] SRAM2 1-Kbyte page y write protection
    $03 constant RAMCFG_P3WP                    \ [0x03] SRAM2 1-Kbyte page y write protection
    $04 constant RAMCFG_P4WP                    \ [0x04] SRAM2 1-Kbyte page y write protection
    $05 constant RAMCFG_P5WP                    \ [0x05] SRAM2 1-Kbyte page y write protection
    $06 constant RAMCFG_P6WP                    \ [0x06] SRAM2 1-Kbyte page y write protection
    $07 constant RAMCFG_P7WP                    \ [0x07] SRAM2 1-Kbyte page y write protection
    $08 constant RAMCFG_P8WP                    \ [0x08] SRAM2 1-Kbyte page y write protection
    $09 constant RAMCFG_P9WP                    \ [0x09] SRAM2 1-Kbyte page y write protection
    $0a constant RAMCFG_P10WP                   \ [0x0a] SRAM2 1-Kbyte page y write protection
    $0b constant RAMCFG_P11WP                   \ [0x0b] SRAM2 1-Kbyte page y write protection
    $0c constant RAMCFG_P12WP                   \ [0x0c] SRAM2 1-Kbyte page y write protection
    $0d constant RAMCFG_P13WP                   \ [0x0d] SRAM2 1-Kbyte page y write protection
    $0e constant RAMCFG_P14WP                   \ [0x0e] SRAM2 1-Kbyte page y write protection
    $0f constant RAMCFG_P15WP                   \ [0x0f] SRAM2 1-Kbyte page y write protection
    $10 constant RAMCFG_P16WP                   \ [0x10] SRAM2 1-Kbyte page y write protection
    $11 constant RAMCFG_P17WP                   \ [0x11] SRAM2 1-Kbyte page y write protection
    $12 constant RAMCFG_P18WP                   \ [0x12] SRAM2 1-Kbyte page y write protection
    $13 constant RAMCFG_P19WP                   \ [0x13] SRAM2 1-Kbyte page y write protection
    $14 constant RAMCFG_P20WP                   \ [0x14] SRAM2 1-Kbyte page y write protection
    $15 constant RAMCFG_P21WP                   \ [0x15] SRAM2 1-Kbyte page y write protection
    $16 constant RAMCFG_P22WP                   \ [0x16] SRAM2 1-Kbyte page y write protection
    $17 constant RAMCFG_P23WP                   \ [0x17] SRAM2 1-Kbyte page y write protection
    $18 constant RAMCFG_P24WP                   \ [0x18] SRAM2 1-Kbyte page y write protection
    $19 constant RAMCFG_P25WP                   \ [0x19] SRAM2 1-Kbyte page y write protection
    $1a constant RAMCFG_P26WP                   \ [0x1a] SRAM2 1-Kbyte page y write protection
    $1b constant RAMCFG_P27WP                   \ [0x1b] SRAM2 1-Kbyte page y write protection
    $1c constant RAMCFG_P28WP                   \ [0x1c] SRAM2 1-Kbyte page y write protection
    $1d constant RAMCFG_P29WP                   \ [0x1d] SRAM2 1-Kbyte page y write protection
    $1e constant RAMCFG_P30WP                   \ [0x1e] SRAM2 1-Kbyte page y write protection
    $1f constant RAMCFG_P31WP                   \ [0x1f] SRAM2 1-Kbyte page y write protection
  [then]


  [ifdef] RAMCFG_RAMCFG_M2WPR2_DEF
    \
    \ @brief RAMCFG memory 2 write protection register 2
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_P32WP                   \ [0x00] SRAM2 1-Kbyte page y write protection
    $01 constant RAMCFG_P33WP                   \ [0x01] SRAM2 1-Kbyte page y write protection
    $02 constant RAMCFG_P34WP                   \ [0x02] SRAM2 1-Kbyte page y write protection
    $03 constant RAMCFG_P35WP                   \ [0x03] SRAM2 1-Kbyte page y write protection
    $04 constant RAMCFG_P36WP                   \ [0x04] SRAM2 1-Kbyte page y write protection
    $05 constant RAMCFG_P37WP                   \ [0x05] SRAM2 1-Kbyte page y write protection
    $06 constant RAMCFG_P38WP                   \ [0x06] SRAM2 1-Kbyte page y write protection
    $07 constant RAMCFG_P39WP                   \ [0x07] SRAM2 1-Kbyte page y write protection
    $08 constant RAMCFG_P40WP                   \ [0x08] SRAM2 1-Kbyte page y write protection
    $09 constant RAMCFG_P41WP                   \ [0x09] SRAM2 1-Kbyte page y write protection
    $0a constant RAMCFG_P42WP                   \ [0x0a] SRAM2 1-Kbyte page y write protection
    $0b constant RAMCFG_P43WP                   \ [0x0b] SRAM2 1-Kbyte page y write protection
    $0c constant RAMCFG_P44WP                   \ [0x0c] SRAM2 1-Kbyte page y write protection
    $0d constant RAMCFG_P45WP                   \ [0x0d] SRAM2 1-Kbyte page y write protection
    $0e constant RAMCFG_P46WP                   \ [0x0e] SRAM2 1-Kbyte page y write protection
    $0f constant RAMCFG_P47WP                   \ [0x0f] SRAM2 1-Kbyte page y write protection
    $10 constant RAMCFG_P48WP                   \ [0x10] SRAM2 1-Kbyte page y write protection
    $11 constant RAMCFG_P49WP                   \ [0x11] SRAM2 1-Kbyte page y write protection
    $12 constant RAMCFG_P50WP                   \ [0x12] SRAM2 1-Kbyte page y write protection
    $13 constant RAMCFG_P51WP                   \ [0x13] SRAM2 1-Kbyte page y write protection
    $14 constant RAMCFG_P52WP                   \ [0x14] SRAM2 1-Kbyte page y write protection
    $15 constant RAMCFG_P53WP                   \ [0x15] SRAM2 1-Kbyte page y write protection
    $16 constant RAMCFG_P54WP                   \ [0x16] SRAM2 1-Kbyte page y write protection
    $17 constant RAMCFG_P55WP                   \ [0x17] SRAM2 1-Kbyte page y write protection
    $18 constant RAMCFG_P56WP                   \ [0x18] SRAM2 1-Kbyte page y write protection
    $19 constant RAMCFG_P57WP                   \ [0x19] SRAM2 1-Kbyte page y write protection
    $1a constant RAMCFG_P58WP                   \ [0x1a] SRAM2 1-Kbyte page y write protection
    $1b constant RAMCFG_P59WP                   \ [0x1b] SRAM2 1-Kbyte page y write protection
    $1c constant RAMCFG_P60WP                   \ [0x1c] SRAM2 1-Kbyte page y write protection
    $1d constant RAMCFG_P61WP                   \ [0x1d] SRAM2 1-Kbyte page y write protection
    $1e constant RAMCFG_P62WP                   \ [0x1e] SRAM2 1-Kbyte page y write protection
    $1f constant RAMCFG_P63WP                   \ [0x1f] SRAM2 1-Kbyte page y write protection
  [then]


  [ifdef] RAMCFG_RAMCFG_M2WPR3_DEF
    \
    \ @brief RAMCFG memory 2 write protection register 3
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_P64WP                   \ [0x00] SRAM2 1-Kbyte page y write protection
    $01 constant RAMCFG_P65WP                   \ [0x01] SRAM2 1-Kbyte page y write protection
    $02 constant RAMCFG_P66WP                   \ [0x02] SRAM2 1-Kbyte page y write protection
    $03 constant RAMCFG_P67WP                   \ [0x03] SRAM2 1-Kbyte page y write protection
    $04 constant RAMCFG_P68WP                   \ [0x04] SRAM2 1-Kbyte page y write protection
    $05 constant RAMCFG_P69WP                   \ [0x05] SRAM2 1-Kbyte page y write protection
    $06 constant RAMCFG_P70WP                   \ [0x06] SRAM2 1-Kbyte page y write protection
    $07 constant RAMCFG_P71WP                   \ [0x07] SRAM2 1-Kbyte page y write protection
    $08 constant RAMCFG_P72WP                   \ [0x08] SRAM2 1-Kbyte page y write protection
    $09 constant RAMCFG_P73WP                   \ [0x09] SRAM2 1-Kbyte page y write protection
    $0a constant RAMCFG_P74WP                   \ [0x0a] SRAM2 1-Kbyte page y write protection
    $0b constant RAMCFG_P75WP                   \ [0x0b] SRAM2 1-Kbyte page y write protection
    $0c constant RAMCFG_P76WP                   \ [0x0c] SRAM2 1-Kbyte page y write protection
    $0d constant RAMCFG_P77WP                   \ [0x0d] SRAM2 1-Kbyte page y write protection
    $0e constant RAMCFG_P78WP                   \ [0x0e] SRAM2 1-Kbyte page y write protection
    $0f constant RAMCFG_P79WP                   \ [0x0f] SRAM2 1-Kbyte page y write protection
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ECCKEYR_DEF
    \
    \ @brief RAMCFG memory 2 ECC key register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECC write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ERKEYR_DEF
    \
    \ @brief RAMCFG memory 2 erase key register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_M3CR_DEF
    \
    \ @brief RAMCFG memory 3 control register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECC enable.
    $04 constant RAMCFG_ALE                     \ [0x04] Address latch enable
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
  [then]


  [ifdef] RAMCFG_RAMCFG_M3IER_DEF
    \
    \ @brief RAMCFG memory 3 interrupt enable register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] ECC single error interrupt enable
    $01 constant RAMCFG_DEIE                    \ [0x01] ECC double error interrupt enable
    $03 constant RAMCFG_ECCNMI                  \ [0x03] Double error NMI
  [then]


  [ifdef] RAMCFG_RAMCFG_M3ISR_DEF
    \
    \ @brief RAMCFG memory interrupt status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] ECC single error detected and corrected
    $01 constant RAMCFG_DED                     \ [0x01] ECC double error detected
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_M3SEAR_DEF
    \
    \ @brief RAMCFG memory 3 ECC single error address register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 32] ECC single error address
  [then]


  [ifdef] RAMCFG_RAMCFG_M3DEAR_DEF
    \
    \ @brief RAMCFG memory 3 ECC double error address register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 32] ECC double error address
  [then]


  [ifdef] RAMCFG_RAMCFG_M3ICR_DEF
    \
    \ @brief RAMCFG memory 3 interrupt clear register 3
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSEDC                   \ [0x00] Clear ECC single error detected and corrected
    $01 constant RAMCFG_CDED                    \ [0x01] Clear ECC double error detected
  [then]


  [ifdef] RAMCFG_RAMCFG_M3ECCKEYR_DEF
    \
    \ @brief RAMCFG memory 3 ECC key register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECC write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_M3ERKEYR_DEF
    \
    \ @brief RAMCFG memory 3 erase key register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_M4ERKEYR_DEF
    \
    \ @brief RAMCFG memory 4 erase key register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_M5CR_DEF
    \
    \ @brief RAMCFG memory 5 control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECC enable.
    $04 constant RAMCFG_ALE                     \ [0x04] Address latch enable
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
  [then]


  [ifdef] RAMCFG_RAMCFG_M5IER_DEF
    \
    \ @brief RAMCFG memory 5 interrupt enable register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] ECC single error interrupt enable
    $01 constant RAMCFG_DEIE                    \ [0x01] ECC double error interrupt enable
    $03 constant RAMCFG_ECCNMI                  \ [0x03] Double error NMI
  [then]


  [ifdef] RAMCFG_RAMCFG_M5ISR_DEF
    \
    \ @brief RAMCFG memory interrupt status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] ECC single error detected and corrected
    $01 constant RAMCFG_DED                     \ [0x01] ECC double error detected
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_M5SEAR_DEF
    \
    \ @brief RAMCFG memory 5 ECC single error address register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 32] ECC single error address
  [then]


  [ifdef] RAMCFG_RAMCFG_M5DEAR_DEF
    \
    \ @brief RAMCFG memory 5 ECC double error address register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 32] ECC double error address
  [then]


  [ifdef] RAMCFG_RAMCFG_M5ICR_DEF
    \
    \ @brief RAMCFG memory 5 interrupt clear register 5
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSEDC                   \ [0x00] Clear ECC single error detected and corrected
    $01 constant RAMCFG_CDED                    \ [0x01] Clear ECC double error detected
  [then]


  [ifdef] RAMCFG_RAMCFG_M5ECCKEYR_DEF
    \
    \ @brief RAMCFG memory 5 ECC key register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECC write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_M5ERKEYR_DEF
    \
    \ @brief RAMCFG memory 5 erase key register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]

  \
  \ @brief RAMCFG address block description
  \
  $00 constant RAMCFG_RAMCFG_M1CR       \ RAMCFG memory 1 control register
  $08 constant RAMCFG_RAMCFG_M1ISR      \ RAMCFG memory interrupt status register
  $28 constant RAMCFG_RAMCFG_M1ERKEYR   \ RAMCFG memory 1 erase key register
  $40 constant RAMCFG_RAMCFG_M2CR       \ RAMCFG memory 2 control register
  $44 constant RAMCFG_RAMCFG_M2IER      \ RAMCFG memory 2 interrupt enable register
  $48 constant RAMCFG_RAMCFG_M2ISR      \ RAMCFG memory interrupt status register
  $4C constant RAMCFG_RAMCFG_M2SEAR     \ RAMCFG memory 2 ECC single error address register
  $50 constant RAMCFG_RAMCFG_M2DEAR     \ RAMCFG memory 2 ECC double error address register
  $54 constant RAMCFG_RAMCFG_M2ICR      \ RAMCFG memory 2 interrupt clear register 2
  $58 constant RAMCFG_RAMCFG_M2WPR1     \ RAMCFG memory 2 write protection register 1
  $5C constant RAMCFG_RAMCFG_M2WPR2     \ RAMCFG memory 2 write protection register 2
  $60 constant RAMCFG_RAMCFG_M2WPR3     \ RAMCFG memory 2 write protection register 3
  $64 constant RAMCFG_RAMCFG_M2ECCKEYR  \ RAMCFG memory 2 ECC key register
  $68 constant RAMCFG_RAMCFG_M2ERKEYR   \ RAMCFG memory 2 erase key register
  $80 constant RAMCFG_RAMCFG_M3CR       \ RAMCFG memory 3 control register
  $84 constant RAMCFG_RAMCFG_M3IER      \ RAMCFG memory 3 interrupt enable register
  $88 constant RAMCFG_RAMCFG_M3ISR      \ RAMCFG memory interrupt status register
  $8C constant RAMCFG_RAMCFG_M3SEAR     \ RAMCFG memory 3 ECC single error address register
  $90 constant RAMCFG_RAMCFG_M3DEAR     \ RAMCFG memory 3 ECC double error address register
  $94 constant RAMCFG_RAMCFG_M3ICR      \ RAMCFG memory 3 interrupt clear register 3
  $A4 constant RAMCFG_RAMCFG_M3ECCKEYR  \ RAMCFG memory 3 ECC key register
  $A8 constant RAMCFG_RAMCFG_M3ERKEYR   \ RAMCFG memory 3 erase key register
  $E8 constant RAMCFG_RAMCFG_M4ERKEYR   \ RAMCFG memory 4 erase key register
  $100 constant RAMCFG_RAMCFG_M5CR      \ RAMCFG memory 5 control register
  $104 constant RAMCFG_RAMCFG_M5IER     \ RAMCFG memory 5 interrupt enable register
  $108 constant RAMCFG_RAMCFG_M5ISR     \ RAMCFG memory interrupt status register
  $10C constant RAMCFG_RAMCFG_M5SEAR    \ RAMCFG memory 5 ECC single error address register
  $110 constant RAMCFG_RAMCFG_M5DEAR    \ RAMCFG memory 5 ECC double error address register
  $114 constant RAMCFG_RAMCFG_M5ICR     \ RAMCFG memory 5 interrupt clear register 5
  $124 constant RAMCFG_RAMCFG_M5ECCKEYR \ RAMCFG memory 5 ECC key register
  $128 constant RAMCFG_RAMCFG_M5ERKEYR  \ RAMCFG memory 5 erase key register

: RAMCFG_DEF ; [then]
