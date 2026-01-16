\
\ @file ramcfg.fs
\ @brief RAMs configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RAMCFG SRAM1 control register
\ Address offset: 0x00
\ Reset value: 0x00010000
\

$00000100 constant RAMCFG_RAMCFG_M1CR_SRAMER                        \ SRAM1 erase This bit can be set by software only after writing the unlock sequence in the ERASEKEY field of the RAMCFG_M1ERKEYR register. Setting this bit starts the SRAM1 erase. This bit is automatically cleared by hardware at the end of the erase operation.
$00070000 constant RAMCFG_RAMCFG_M1CR_WSC                           \ SRAM1 wait state configuration This field is used to program the number of wait states inserted on the AHB when reading the SRAM1, depending on its access time. ... Note: Before entering Stop 1 mode software must set SRAM1 wait states to at least 1.


\
\ @brief RAMCFG SRAM1 interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000100 constant RAMCFG_RAMCFG_M1ISR_SRAMBUSY                     \ SRAM busy with erase operation. Note: Depending on the SRAM, the erase operation can be performed due to software request, system reset if the enabled by user option, tamper detection or RDP regression. Refer to Table38.


\
\ @brief RAMCFG SRAM1 erase key register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M1ERKEYR_ERASEKEY                  \ Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. Write 0xCA into ERASEKEY[7:0] Write 0x53 into ERASEKEY[7:0] Note: Writing a wrong key reactivates the write protection.


\
\ @brief RAMCFG SRAM2 control register
\ Address offset: 0x40
\ Reset value: 0x00010000
\

$00000010 constant RAMCFG_RAMCFG_M2CR_ALE                           \ SRAM2 parity fail address latch enable
$00000100 constant RAMCFG_RAMCFG_M2CR_SRAMER                        \ SRAM2 erase This bit can be set by software only after writing the unlock sequence in the ERASEKEY field of the RAMCFG_M2ERKEYR register. Setting this bit starts the SRAM2 erase. This bit is automatically cleared by hardware at the end of the erase operation.
$00070000 constant RAMCFG_RAMCFG_M2CR_WSC                           \ SRAM2 wait state configuration This field is used to program the number of wait states inserted on the AHB when reading the SRAM2, depending on its access time. ... Note: Before entering Stop 1 mode software must set SRAM2 wait states to at least 1.


\
\ @brief RAMCFG SRAM2 interrupt enable register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000002 constant RAMCFG_RAMCFG_M2IER_PEIE                         \ Parity error interrupt enable
$00000008 constant RAMCFG_RAMCFG_M2IER_PENMI                        \ Parity error NMI. This bit is set by software and cleared only by a global RAMCFG reset Note: When PENMI bit is set, the RAMCFG maskable interrupt is not generated for a parity error whatever PEIE bit value.


\
\ @brief RAMCFG SRAM2 interrupt status register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000002 constant RAMCFG_RAMCFG_M2ISR_PED                          \ Parity error detected
$00000100 constant RAMCFG_RAMCFG_M2ISR_SRAMBUSY                     \ SRAM2 busy with erase operation. Note: Depending on the SRAM2, the erase operation can be performed due to software request, system reset if the enabled by user option, tamper detection or RDP regression. Refer to Table38.


\
\ @brief RAMCFG SRAM2 parity error address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant RAMCFG_RAMCFG_M2PEAR_PEA                         \ Parity error SRAM word aligned address offset.PEA[1:0] read 0b00. When ALE bit is set in RAMCFG_M2CR register, this field is updated when PED and CPED are zero and a new parity error is detected, with the SRAM word aligned address offset corresponding to the parity error.
$0f000000 constant RAMCFG_RAMCFG_M2PEAR_ID                          \ Parity error AHB bus master ID. When ALE bit is set in RAMCFG_M2CR register, this field is updated when PED and CPED are zero and a new parity error is detected, with: Others: reserved
$f0000000 constant RAMCFG_RAMCFG_M2PEAR_BYTE                        \ Byte parity error flag. When ALE bit is set in RAMCFG_M2CR register, this field is updated when PED and CPED are zero and a new parity error is detected, with: 1xxx: parity error detected on fourth byte in word aligned address x1xx: parity error detected on third byte in word aligned address xx1x: parity error detected on second byte in word aligned address xxx1: parity error detected on first byte in word aligned address


\
\ @brief RAMCFG SRAM2 interrupt clear register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000002 constant RAMCFG_RAMCFG_M2ICR_CPED                         \ Clear parity error detect bit Writing 1 to this bit clears the PED bit in RAMCFG_M2ISR. Reading this bit returns the value of the RAMCFG_M2ISR PED bit.


\
\ @brief RAMCFG SRAM2 write protection register 1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M2WPR1_P0WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000002 constant RAMCFG_RAMCFG_M2WPR1_P1WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000004 constant RAMCFG_RAMCFG_M2WPR1_P2WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000008 constant RAMCFG_RAMCFG_M2WPR1_P3WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000010 constant RAMCFG_RAMCFG_M2WPR1_P4WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000020 constant RAMCFG_RAMCFG_M2WPR1_P5WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000040 constant RAMCFG_RAMCFG_M2WPR1_P6WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000080 constant RAMCFG_RAMCFG_M2WPR1_P7WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000100 constant RAMCFG_RAMCFG_M2WPR1_P8WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000200 constant RAMCFG_RAMCFG_M2WPR1_P9WP                        \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000400 constant RAMCFG_RAMCFG_M2WPR1_P10WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000800 constant RAMCFG_RAMCFG_M2WPR1_P11WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00001000 constant RAMCFG_RAMCFG_M2WPR1_P12WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00002000 constant RAMCFG_RAMCFG_M2WPR1_P13WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00004000 constant RAMCFG_RAMCFG_M2WPR1_P14WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00008000 constant RAMCFG_RAMCFG_M2WPR1_P15WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00010000 constant RAMCFG_RAMCFG_M2WPR1_P16WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00020000 constant RAMCFG_RAMCFG_M2WPR1_P17WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00040000 constant RAMCFG_RAMCFG_M2WPR1_P18WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00080000 constant RAMCFG_RAMCFG_M2WPR1_P19WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00100000 constant RAMCFG_RAMCFG_M2WPR1_P20WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00200000 constant RAMCFG_RAMCFG_M2WPR1_P21WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00400000 constant RAMCFG_RAMCFG_M2WPR1_P22WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00800000 constant RAMCFG_RAMCFG_M2WPR1_P23WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$01000000 constant RAMCFG_RAMCFG_M2WPR1_P24WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$02000000 constant RAMCFG_RAMCFG_M2WPR1_P25WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$04000000 constant RAMCFG_RAMCFG_M2WPR1_P26WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$08000000 constant RAMCFG_RAMCFG_M2WPR1_P27WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$10000000 constant RAMCFG_RAMCFG_M2WPR1_P28WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$20000000 constant RAMCFG_RAMCFG_M2WPR1_P29WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$40000000 constant RAMCFG_RAMCFG_M2WPR1_P30WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$80000000 constant RAMCFG_RAMCFG_M2WPR1_P31WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.


\
\ @brief RAMCFG SRAM2 write protection register 2
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M2WPR2_P32WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000002 constant RAMCFG_RAMCFG_M2WPR2_P33WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000004 constant RAMCFG_RAMCFG_M2WPR2_P34WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000008 constant RAMCFG_RAMCFG_M2WPR2_P35WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000010 constant RAMCFG_RAMCFG_M2WPR2_P36WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000020 constant RAMCFG_RAMCFG_M2WPR2_P37WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000040 constant RAMCFG_RAMCFG_M2WPR2_P38WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000080 constant RAMCFG_RAMCFG_M2WPR2_P39WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000100 constant RAMCFG_RAMCFG_M2WPR2_P40WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000200 constant RAMCFG_RAMCFG_M2WPR2_P41WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000400 constant RAMCFG_RAMCFG_M2WPR2_P42WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00000800 constant RAMCFG_RAMCFG_M2WPR2_P43WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00001000 constant RAMCFG_RAMCFG_M2WPR2_P44WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00002000 constant RAMCFG_RAMCFG_M2WPR2_P45WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00004000 constant RAMCFG_RAMCFG_M2WPR2_P46WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00008000 constant RAMCFG_RAMCFG_M2WPR2_P47WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00010000 constant RAMCFG_RAMCFG_M2WPR2_P48WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00020000 constant RAMCFG_RAMCFG_M2WPR2_P49WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00040000 constant RAMCFG_RAMCFG_M2WPR2_P50WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00080000 constant RAMCFG_RAMCFG_M2WPR2_P51WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00100000 constant RAMCFG_RAMCFG_M2WPR2_P52WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00200000 constant RAMCFG_RAMCFG_M2WPR2_P53WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00400000 constant RAMCFG_RAMCFG_M2WPR2_P54WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$00800000 constant RAMCFG_RAMCFG_M2WPR2_P55WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$01000000 constant RAMCFG_RAMCFG_M2WPR2_P56WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$02000000 constant RAMCFG_RAMCFG_M2WPR2_P57WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$04000000 constant RAMCFG_RAMCFG_M2WPR2_P58WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$08000000 constant RAMCFG_RAMCFG_M2WPR2_P59WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$10000000 constant RAMCFG_RAMCFG_M2WPR2_P60WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$20000000 constant RAMCFG_RAMCFG_M2WPR2_P61WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$40000000 constant RAMCFG_RAMCFG_M2WPR2_P62WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.
$80000000 constant RAMCFG_RAMCFG_M2WPR2_P63WP                       \ SRAM2 1-Kbyte write protect page y write protection These bits are set by software and cleared only by a system reset.


\
\ @brief RAMCFG SRAM2 erase key register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M2ERKEYR_ERASEKEY                  \ Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. Write 0xCA into ERASEKEY[7:0] Write 0x53 into ERASEKEY[7:0] Note: Writing a wrong key reactivates the write protection.


\
\ @brief RAMs configuration controller
\
$40026000 constant RAMCFG_RAMCFG_M1CR  \ offset: 0x00 : RAMCFG SRAM1 control register
$40026008 constant RAMCFG_RAMCFG_M1ISR  \ offset: 0x08 : RAMCFG SRAM1 interrupt status register
$40026028 constant RAMCFG_RAMCFG_M1ERKEYR  \ offset: 0x28 : RAMCFG SRAM1 erase key register
$40026040 constant RAMCFG_RAMCFG_M2CR  \ offset: 0x40 : RAMCFG SRAM2 control register
$40026044 constant RAMCFG_RAMCFG_M2IER  \ offset: 0x44 : RAMCFG SRAM2 interrupt enable register
$40026048 constant RAMCFG_RAMCFG_M2ISR  \ offset: 0x48 : RAMCFG SRAM2 interrupt status register
$40026050 constant RAMCFG_RAMCFG_M2PEAR  \ offset: 0x50 : RAMCFG SRAM2 parity error address register
$40026054 constant RAMCFG_RAMCFG_M2ICR  \ offset: 0x54 : RAMCFG SRAM2 interrupt clear register
$40026058 constant RAMCFG_RAMCFG_M2WPR1  \ offset: 0x58 : RAMCFG SRAM2 write protection register 1
$4002605c constant RAMCFG_RAMCFG_M2WPR2  \ offset: 0x5C : RAMCFG SRAM2 write protection register 2
$40026068 constant RAMCFG_RAMCFG_M2ERKEYR  \ offset: 0x68 : RAMCFG SRAM2 erase key register

