\
\ @file ramcfg.fs
\ @brief RAMs configuration controller
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
    $00 constant RAMCFG_ECCE                    \ [0x00] ECC enable. This bit reset value is defined by the user option bit configuration. When set, it can be cleared by software only after writing the unlock sequence in the RAMCFG_MxECCKEYR register. Note: This bit is reserved and must be kept at reset value in SRAM1 control register.
    $04 constant RAMCFG_ALE                     \ [0x04] Address latch enable Note: This bit is reserved and must be kept at reset value in SRAM1 control register.
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase This bit can be set by software only after writing the unlock sequence in the ERASEKEY field of the RAMCFG_MxERKEYR register. Setting this bit starts the SRAM erase. This bit is automatically cleared by hardware at the end of the erase operation.
  [then]


  [ifdef] RAMCFG_RAMCFG_M1ISR_DEF
    \
    \ @brief RAMCFG memory interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1 interrupt status register.
    $01 constant RAMCFG_DED                     \ [0x01] ECC double error detected Note: This bit is reserved and must be kept at reset value in SRAM1 interrupt status register.
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation Note: Depending on the SRAM, the erase operation can be performed due to software request, system reset if the option bit is enabled, tamper detection or product state regression. Refer to Table 9: Internal SRAMs features.
  [then]


  [ifdef] RAMCFG_RAMCFG_M1ERKEYR_DEF
    \
    \ @brief RAMCFG memory 1 erase key register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2CR_DEF
    \
    \ @brief RAMCFG memory 2 control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECC enable. This bit reset value is defined by the user option bit configuration. When set, it can be cleared by software only after writing the unlock sequence in the RAMCFG_MxECCKEYR register. Note: This bit is reserved and must be kept at reset value in SRAM1 control register.
    $04 constant RAMCFG_ALE                     \ [0x04] Address latch enable Note: This bit is reserved and must be kept at reset value in SRAM1 control register.
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase This bit can be set by software only after writing the unlock sequence in the ERASEKEY field of the RAMCFG_MxERKEYR register. Setting this bit starts the SRAM erase. This bit is automatically cleared by hardware at the end of the erase operation.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2IER_DEF
    \
    \ @brief RAMCFG memory 2 interrupt enable register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] ECC single error interrupt enable
    $01 constant RAMCFG_DEIE                    \ [0x01] ECC double error interrupt enable
    $03 constant RAMCFG_ECCNMI                  \ [0x03] Double error NMI This bit is set by software and cleared only by a global RAMCFG reset. Note: if ECCNMI is set, the RAMCFG maskable interrupt is not generated whatever DEIE bit value.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ISR_DEF
    \
    \ @brief RAMCFG memory interrupt status register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1 interrupt status register.
    $01 constant RAMCFG_DED                     \ [0x01] ECC double error detected Note: This bit is reserved and must be kept at reset value in SRAM1 interrupt status register.
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation Note: Depending on the SRAM, the erase operation can be performed due to software request, system reset if the option bit is enabled, tamper detection or product state regression. Refer to Table 9: Internal SRAMs features.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2SEAR_DEF
    \
    \ @brief RAMCFG memory 2 ECC single error address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 32] ECC single error address When the ALE bit is set in the RAMCFG_MxCR register, this field is updated with the address corresponding to the ECC single error.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2DEAR_DEF
    \
    \ @brief RAMCFG memory 2 ECC double error address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 32] ECC double error address When the ALE bit is set in the RAMCFG_MxCR register, this field is updated with the address corresponding to the ECC double error.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ICR_DEF
    \
    \ @brief RAMCFG memory 2 interrupt clear register 2
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSEDC                   \ [0x00] Clear ECC single error detected and corrected Writing 1 to this flag clears the SEDC bit in the RAMCFG_MxISR register. Reading this flag returns the SEDC value.
    $01 constant RAMCFG_CDED                    \ [0x01] Clear ECC double error detected Writing 1 to this flag clears the DED bit in the RAMCFG_MxISR register. Reading this flag returns the DED value.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2WPR1_DEF
    \
    \ @brief RAMCFG memory 2 write protection register 1
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_P0WP                    \ [0x00] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $01 constant RAMCFG_P1WP                    \ [0x01] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $02 constant RAMCFG_P2WP                    \ [0x02] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $03 constant RAMCFG_P3WP                    \ [0x03] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $04 constant RAMCFG_P4WP                    \ [0x04] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $05 constant RAMCFG_P5WP                    \ [0x05] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $06 constant RAMCFG_P6WP                    \ [0x06] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $07 constant RAMCFG_P7WP                    \ [0x07] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $08 constant RAMCFG_P8WP                    \ [0x08] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $09 constant RAMCFG_P9WP                    \ [0x09] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $0a constant RAMCFG_P10WP                   \ [0x0a] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $0b constant RAMCFG_P11WP                   \ [0x0b] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $0c constant RAMCFG_P12WP                   \ [0x0c] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $0d constant RAMCFG_P13WP                   \ [0x0d] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $0e constant RAMCFG_P14WP                   \ [0x0e] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
    $0f constant RAMCFG_P15WP                   \ [0x0f] SRAM2 1-Kbyte page y write protection These bits are set by software and cleared only by a global RAMCFG reset.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ECCKEYR_DEF
    \
    \ @brief RAMCFG memory 2 ECC key register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECC write protection key The following steps are required to unlock the write protection of the ECCE bit in the RAMCFG_MxCR register. 1) Write 0xAE into ECCKEY[7:0]. 2) Write 0x75 into ECCKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ERKEYR_DEF
    \
    \ @brief RAMCFG memory 2 erase key register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] RAMCFG_RAMCFG_M3IER_DEF
    \
    \ @brief RAMCFG memory 3 interrupt enable register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] ECC single error interrupt enable
    $01 constant RAMCFG_DEIE                    \ [0x01] ECC double error interrupt enable
    $03 constant RAMCFG_ECCNMI                  \ [0x03] Double error NMI This bit is set by software and cleared only by a global RAMCFG reset. Note: if ECCNMI is set, the RAMCFG maskable interrupt is not generated whatever DEIE bit value.
  [then]


  [ifdef] RAMCFG_RAMCFG_M3ISR_DEF
    \
    \ @brief RAMCFG memory interrupt status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1 interrupt status register.
    $01 constant RAMCFG_DED                     \ [0x01] ECC double error detected Note: This bit is reserved and must be kept at reset value in SRAM1 interrupt status register.
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation Note: Depending on the SRAM, the erase operation can be performed due to software request, system reset if the option bit is enabled, tamper detection or product state regression. Refer to Table 9: Internal SRAMs features.
  [then]


  [ifdef] RAMCFG_RAMCFG_M3SEAR_DEF
    \
    \ @brief RAMCFG memory 3 ECC single error address register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 32] ECC single error address When the ALE bit is set in the RAMCFG_MxCR register, this field is updated with the address corresponding to the ECC single error.
  [then]


  [ifdef] RAMCFG_RAMCFG_M3DEAR_DEF
    \
    \ @brief RAMCFG memory 3 ECC double error address register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 32] ECC double error address When the ALE bit is set in the RAMCFG_MxCR register, this field is updated with the address corresponding to the ECC double error.
  [then]


  [ifdef] RAMCFG_RAMCFG_M3ICR_DEF
    \
    \ @brief RAMCFG memory 3 interrupt clear register 3
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSEDC                   \ [0x00] Clear ECC single error detected and corrected Writing 1 to this flag clears the SEDC bit in the RAMCFG_MxISR register. Reading this flag returns the SEDC value.
    $01 constant RAMCFG_CDED                    \ [0x01] Clear ECC double error detected Writing 1 to this flag clears the DED bit in the RAMCFG_MxISR register. Reading this flag returns the DED value.
  [then]


  [ifdef] RAMCFG_RAMCFG_M3ECCKEYR_DEF
    \
    \ @brief RAMCFG memory 3 ECC key register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECC write protection key The following steps are required to unlock the write protection of the ECCE bit in the RAMCFG_MxCR register. 1) Write 0xAE into ECCKEY[7:0]. 2) Write 0x75 into ECCKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] RAMCFG_RAMCFG_M3ERKEYR_DEF
    \
    \ @brief RAMCFG memory 3 erase key register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] RAMCFG_RAMCFG_M4ERKEYR_DEF
    \
    \ @brief RAMCFG memory 4 erase key register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] RAMCFG_RAMCFG_M5CR_DEF
    \
    \ @brief RAMCFG memory 5 control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECC enable. This bit reset value is defined by the user option bit configuration. When set, it can be cleared by software only after writing the unlock sequence in the RAMCFG_MxECCKEYR register. Note: This bit is reserved and must be kept at reset value in SRAM1 control register.
    $04 constant RAMCFG_ALE                     \ [0x04] Address latch enable Note: This bit is reserved and must be kept at reset value in SRAM1 control register.
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase This bit can be set by software only after writing the unlock sequence in the ERASEKEY field of the RAMCFG_MxERKEYR register. Setting this bit starts the SRAM erase. This bit is automatically cleared by hardware at the end of the erase operation.
  [then]


  [ifdef] RAMCFG_RAMCFG_M5IER_DEF
    \
    \ @brief RAMCFG memory 5 interrupt enable register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] ECC single error interrupt enable
    $01 constant RAMCFG_DEIE                    \ [0x01] ECC double error interrupt enable
    $03 constant RAMCFG_ECCNMI                  \ [0x03] Double error NMI This bit is set by software and cleared only by a global RAMCFG reset. Note: if ECCNMI is set, the RAMCFG maskable interrupt is not generated whatever DEIE bit value.
  [then]


  [ifdef] RAMCFG_RAMCFG_M5ISR_DEF
    \
    \ @brief RAMCFG memory interrupt status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEDC                    \ [0x00] ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1 interrupt status register.
    $01 constant RAMCFG_DED                     \ [0x01] ECC double error detected Note: This bit is reserved and must be kept at reset value in SRAM1 interrupt status register.
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation Note: Depending on the SRAM, the erase operation can be performed due to software request, system reset if the option bit is enabled, tamper detection or product state regression. Refer to Table 9: Internal SRAMs features.
  [then]


  [ifdef] RAMCFG_RAMCFG_M5SEAR_DEF
    \
    \ @brief RAMCFG memory 5 ECC single error address register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 32] ECC single error address When the ALE bit is set in the RAMCFG_MxCR register, this field is updated with the address corresponding to the ECC single error.
  [then]


  [ifdef] RAMCFG_RAMCFG_M5DEAR_DEF
    \
    \ @brief RAMCFG memory 5 ECC double error address register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 32] ECC double error address When the ALE bit is set in the RAMCFG_MxCR register, this field is updated with the address corresponding to the ECC double error.
  [then]


  [ifdef] RAMCFG_RAMCFG_M5ICR_DEF
    \
    \ @brief RAMCFG memory 5 interrupt clear register 5
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSEDC                   \ [0x00] Clear ECC single error detected and corrected Writing 1 to this flag clears the SEDC bit in the RAMCFG_MxISR register. Reading this flag returns the SEDC value.
    $01 constant RAMCFG_CDED                    \ [0x01] Clear ECC double error detected Writing 1 to this flag clears the DED bit in the RAMCFG_MxISR register. Reading this flag returns the DED value.
  [then]


  [ifdef] RAMCFG_RAMCFG_M5ECCKEYR_DEF
    \
    \ @brief RAMCFG memory 5 ECC key register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECC write protection key The following steps are required to unlock the write protection of the ECCE bit in the RAMCFG_MxCR register. 1) Write 0xAE into ECCKEY[7:0]. 2) Write 0x75 into ECCKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] RAMCFG_RAMCFG_M5ERKEYR_DEF
    \
    \ @brief RAMCFG memory 5 erase key register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
  [then]

  \
  \ @brief RAMs configuration controller
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
  $64 constant RAMCFG_RAMCFG_M2ECCKEYR  \ RAMCFG memory 2 ECC key register
  $68 constant RAMCFG_RAMCFG_M2ERKEYR   \ RAMCFG memory 2 erase key register
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
