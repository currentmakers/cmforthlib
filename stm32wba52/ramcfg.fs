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
    \ @brief RAMCFG SRAM1 control register
    \ Address offset: 0x00
    \ Reset value: 0x00010000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM1 erase This bit can be set by software only after writing the unlock sequence in the ERASEKEY field of the RAMCFG_M1ERKEYR register. Setting this bit starts the SRAM1 erase. This bit is automatically cleared by hardware at the end of the erase operation.
    $10 constant RAMCFG_WSC                     \ [0x10 : 3] SRAM1 wait state configuration This field is used to program the number of wait states inserted on the AHB when reading the SRAM1, depending on its access time. ... Note: Before entering Stop 1 mode software must set SRAM1 wait states to at least 1.
  [then]


  [ifdef] RAMCFG_RAMCFG_M1ISR_DEF
    \
    \ @brief RAMCFG SRAM1 interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation. Note: Depending on the SRAM, the erase operation can be performed due to software request, system reset if the enabled by user option, tamper detection or RDP regression. Refer to Table38.
  [then]


  [ifdef] RAMCFG_RAMCFG_M1ERKEYR_DEF
    \
    \ @brief RAMCFG SRAM1 erase key register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. Write 0xCA into ERASEKEY[7:0] Write 0x53 into ERASEKEY[7:0] Note: Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2CR_DEF
    \
    \ @brief RAMCFG SRAM2 control register
    \ Address offset: 0x40
    \ Reset value: 0x00010000
    \
    $04 constant RAMCFG_ALE                     \ [0x04] SRAM2 parity fail address latch enable
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM2 erase This bit can be set by software only after writing the unlock sequence in the ERASEKEY field of the RAMCFG_M2ERKEYR register. Setting this bit starts the SRAM2 erase. This bit is automatically cleared by hardware at the end of the erase operation.
    $10 constant RAMCFG_WSC                     \ [0x10 : 3] SRAM2 wait state configuration This field is used to program the number of wait states inserted on the AHB when reading the SRAM2, depending on its access time. ... Note: Before entering Stop 1 mode software must set SRAM2 wait states to at least 1.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2IER_DEF
    \
    \ @brief RAMCFG SRAM2 interrupt enable register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $01 constant RAMCFG_PEIE                    \ [0x01] Parity error interrupt enable
    $03 constant RAMCFG_PENMI                   \ [0x03] Parity error NMI. This bit is set by software and cleared only by a global RAMCFG reset Note: When PENMI bit is set, the RAMCFG maskable interrupt is not generated for a parity error whatever PEIE bit value.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ISR_DEF
    \
    \ @brief RAMCFG SRAM2 interrupt status register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $01 constant RAMCFG_PED                     \ [0x01] Parity error detected
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM2 busy with erase operation. Note: Depending on the SRAM2, the erase operation can be performed due to software request, system reset if the enabled by user option, tamper detection or RDP regression. Refer to Table38.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2PEAR_DEF
    \
    \ @brief RAMCFG SRAM2 parity error address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_PEA                     \ [0x00 : 16] Parity error SRAM word aligned address offset.PEA[1:0] read 0b00. When ALE bit is set in RAMCFG_M2CR register, this field is updated when PED and CPED are zero and a new parity error is detected, with the SRAM word aligned address offset corresponding to the parity error.
    $18 constant RAMCFG_ID                      \ [0x18 : 4] Parity error AHB bus master ID. When ALE bit is set in RAMCFG_M2CR register, this field is updated when PED and CPED are zero and a new parity error is detected, with: Others: reserved
    $1c constant RAMCFG_BYTE                    \ [0x1c : 4] Byte parity error flag. When ALE bit is set in RAMCFG_M2CR register, this field is updated when PED and CPED are zero and a new parity error is detected, with: 1xxx: parity error detected on fourth byte in word aligned address x1xx: parity error detected on third byte in word aligned address xx1x: parity error detected on second byte in word aligned address xxx1: parity error detected on first byte in word aligned address
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ICR_DEF
    \
    \ @brief RAMCFG SRAM2 interrupt clear register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $01 constant RAMCFG_CPED                    \ [0x01] Clear parity error detect bit Writing 1 to this bit clears the PED bit in RAMCFG_M2ISR. Reading this bit returns the value of the RAMCFG_M2ISR PED bit.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2WPR1_DEF
    \
    \ @brief RAMCFG SRAM2 write protection register 1
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_P0WP                    \ [0x00] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $01 constant RAMCFG_P1WP                    \ [0x01] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $02 constant RAMCFG_P2WP                    \ [0x02] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $03 constant RAMCFG_P3WP                    \ [0x03] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $04 constant RAMCFG_P4WP                    \ [0x04] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $05 constant RAMCFG_P5WP                    \ [0x05] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $06 constant RAMCFG_P6WP                    \ [0x06] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $07 constant RAMCFG_P7WP                    \ [0x07] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $08 constant RAMCFG_P8WP                    \ [0x08] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $09 constant RAMCFG_P9WP                    \ [0x09] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0a constant RAMCFG_P10WP                   \ [0x0a] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0b constant RAMCFG_P11WP                   \ [0x0b] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0c constant RAMCFG_P12WP                   \ [0x0c] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0d constant RAMCFG_P13WP                   \ [0x0d] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0e constant RAMCFG_P14WP                   \ [0x0e] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0f constant RAMCFG_P15WP                   \ [0x0f] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $10 constant RAMCFG_P16WP                   \ [0x10] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $11 constant RAMCFG_P17WP                   \ [0x11] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $12 constant RAMCFG_P18WP                   \ [0x12] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $13 constant RAMCFG_P19WP                   \ [0x13] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $14 constant RAMCFG_P20WP                   \ [0x14] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $15 constant RAMCFG_P21WP                   \ [0x15] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $16 constant RAMCFG_P22WP                   \ [0x16] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $17 constant RAMCFG_P23WP                   \ [0x17] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $18 constant RAMCFG_P24WP                   \ [0x18] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $19 constant RAMCFG_P25WP                   \ [0x19] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1a constant RAMCFG_P26WP                   \ [0x1a] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1b constant RAMCFG_P27WP                   \ [0x1b] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1c constant RAMCFG_P28WP                   \ [0x1c] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1d constant RAMCFG_P29WP                   \ [0x1d] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1e constant RAMCFG_P30WP                   \ [0x1e] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1f constant RAMCFG_P31WP                   \ [0x1f] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2WPR2_DEF
    \
    \ @brief RAMCFG SRAM2 write protection register 2
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_P32WP                   \ [0x00] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $01 constant RAMCFG_P33WP                   \ [0x01] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $02 constant RAMCFG_P34WP                   \ [0x02] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $03 constant RAMCFG_P35WP                   \ [0x03] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $04 constant RAMCFG_P36WP                   \ [0x04] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $05 constant RAMCFG_P37WP                   \ [0x05] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $06 constant RAMCFG_P38WP                   \ [0x06] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $07 constant RAMCFG_P39WP                   \ [0x07] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $08 constant RAMCFG_P40WP                   \ [0x08] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $09 constant RAMCFG_P41WP                   \ [0x09] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0a constant RAMCFG_P42WP                   \ [0x0a] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0b constant RAMCFG_P43WP                   \ [0x0b] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0c constant RAMCFG_P44WP                   \ [0x0c] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0d constant RAMCFG_P45WP                   \ [0x0d] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0e constant RAMCFG_P46WP                   \ [0x0e] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $0f constant RAMCFG_P47WP                   \ [0x0f] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $10 constant RAMCFG_P48WP                   \ [0x10] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $11 constant RAMCFG_P49WP                   \ [0x11] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $12 constant RAMCFG_P50WP                   \ [0x12] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $13 constant RAMCFG_P51WP                   \ [0x13] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $14 constant RAMCFG_P52WP                   \ [0x14] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $15 constant RAMCFG_P53WP                   \ [0x15] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $16 constant RAMCFG_P54WP                   \ [0x16] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $17 constant RAMCFG_P55WP                   \ [0x17] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $18 constant RAMCFG_P56WP                   \ [0x18] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $19 constant RAMCFG_P57WP                   \ [0x19] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1a constant RAMCFG_P58WP                   \ [0x1a] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1b constant RAMCFG_P59WP                   \ [0x1b] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1c constant RAMCFG_P60WP                   \ [0x1c] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1d constant RAMCFG_P61WP                   \ [0x1d] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1e constant RAMCFG_P62WP                   \ [0x1e] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
    $1f constant RAMCFG_P63WP                   \ [0x1f] SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
  [then]


  [ifdef] RAMCFG_RAMCFG_M2ERKEYR_DEF
    \
    \ @brief RAMCFG SRAM2 erase key register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. Write 0xCA into ERASEKEY[7:0] Write 0x53 into ERASEKEY[7:0] Note: Writing a wrong key reactivates the write protection.
  [then]

  \
  \ @brief RAMs configuration controller
  \
  $00 constant RAMCFG_RAMCFG_M1CR       \ RAMCFG SRAM1 control register
  $08 constant RAMCFG_RAMCFG_M1ISR      \ RAMCFG SRAM1 interrupt status register
  $28 constant RAMCFG_RAMCFG_M1ERKEYR   \ RAMCFG SRAM1 erase key register
  $40 constant RAMCFG_RAMCFG_M2CR       \ RAMCFG SRAM2 control register
  $44 constant RAMCFG_RAMCFG_M2IER      \ RAMCFG SRAM2 interrupt enable register
  $48 constant RAMCFG_RAMCFG_M2ISR      \ RAMCFG SRAM2 interrupt status register
  $50 constant RAMCFG_RAMCFG_M2PEAR     \ RAMCFG SRAM2 parity error address register
  $54 constant RAMCFG_RAMCFG_M2ICR      \ RAMCFG SRAM2 interrupt clear register
  $58 constant RAMCFG_RAMCFG_M2WPR1     \ RAMCFG SRAM2 write protection register 1
  $5C constant RAMCFG_RAMCFG_M2WPR2     \ RAMCFG SRAM2 write protection register 2
  $68 constant RAMCFG_RAMCFG_M2ERKEYR   \ RAMCFG SRAM2 erase key register

: RAMCFG_DEF ; [then]
