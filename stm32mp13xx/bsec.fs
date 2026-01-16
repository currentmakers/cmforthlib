\
\ @file bsec.fs
\ @brief BSEC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief BSEC OTP configuration register
\ Address offset: 0x00
\ Reset value: 0x0000000E
\

$00000001 constant BSEC_BSEC_OTP_CONFIG_PWRUP                       \ OTP power-up control Note: After the power-on initial read of OTP, BSEC powers down OTP. PWRUP bit is then cleared. Prior to any read or programming operation, OTP must be powered up again by setting PWRUP bit. OTP read is qualified by pwrok input signal, which indicates that VDD and VDD1 supplies are in valid range.
$00000006 constant BSEC_BSEC_OTP_CONFIG_FRC                         \ OTP clock frequency range selection Note: 0b11 is used by default. OTP initial read is always using an internal OSC with 64 MHz max frequency. Reading OTP at a lower frequency than the range programmed by FRC[1:0] is possible.
$00000078 constant BSEC_BSEC_OTP_CONFIG_PRGWIDTH                    \ OTP programming pulse width (default = 0b0001)
$00000180 constant BSEC_BSEC_OTP_CONFIG_TREAD                       \ set OTP reading current level (default = 0b00)


\
\ @brief BSEC OTP control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000007f constant BSEC_BSEC_OTP_CONTROL_ADDR                       \ OTP word address Actual OTP word address. Words address are from 0 to 95 for BSEC Note: the actual OTP word address is adjusted according to the redundancy or ECC scheme.
$00000100 constant BSEC_BSEC_OTP_CONTROL_PROG                       \ OTP operation control
$00000200 constant BSEC_BSEC_OTP_CONTROL_LOCK                       \ OTP permanent word lock control


\
\ @brief BSEC OTP write data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_WRDATA_WRDATA                      \ OTP write data


\
\ @brief BSEC OTP status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant BSEC_BSEC_OTP_STATUS_SECURE                      \ OTP secured mode
$00000004 constant BSEC_BSEC_OTP_STATUS_INVALID                     \ OTP invalid mode
$00000008 constant BSEC_BSEC_OTP_STATUS_BUSY                        \ OTP operation status Note: bit polling is used to determine operation completion.
$00000010 constant BSEC_BSEC_OTP_STATUS_PROGFAIL                    \ last programming status
$00000020 constant BSEC_BSEC_OTP_STATUS_PWRON                       \ OTP power status Note: used to poll pwrok signal value
$00000100 constant BSEC_BSEC_OTP_STATUS_CLOSED                      \ OTP_SECURED mode
$00000200 constant BSEC_BSEC_OTP_STATUS_BSCANDIS                    \ Boundary Scan status
$00000400 constant BSEC_BSEC_OTP_STATUS_JTAGDIS                     \ JTAG port status


\
\ @brief BSEC OTP lock configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant BSEC_BSEC_OTP_LOCK_OTP                           \ upper OTP read lock
$00000002 constant BSEC_BSEC_OTP_LOCK_ROMLOCK                       \ Upper ROM region read lock The upper ROM region is accessible only in OTP-SECURED open and OTP-SECURED closed modes and ROMLOCK bit is relevant only in these modes.
$00000004 constant BSEC_BSEC_OTP_LOCK_DENREG                        \ debug enable register sticky lock
$00000010 constant BSEC_BSEC_OTP_LOCK_GPLOCK                        \ programming sticky lock


\
\ @brief BSEC debug configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000002 constant BSEC_BSEC_DENABLE_DBGEN                          \ debug enable with signal dbgen
$00000004 constant BSEC_BSEC_DENABLE_NIDEN                          \ non-invasive debug enable with signal niden
$00000008 constant BSEC_BSEC_DENABLE_DEVICEEN                       \ controls access to debug component via external debug port by signal deviceen
$00000010 constant BSEC_BSEC_DENABLE_HDPEN                          \ hardware debug port enable with signal hdpen
$00000020 constant BSEC_BSEC_DENABLE_SPIDEN                         \ secure privilege invasive debug enable with signal spniden
$00000040 constant BSEC_BSEC_DENABLE_SPNIDEN                        \ secure privilege non-invasive debug enable with signal spiden
$00000080 constant BSEC_BSEC_DENABLE_CP15SDISABLE                   \ write access to some secure Cortex®-A7 CP15 registers disable
$00000200 constant BSEC_BSEC_DENABLE_CFGSDISABLE                    \ write access to secure GIC registers disable with signal cfgsdisable
$00000400 constant BSEC_BSEC_DENABLE_DBGSWENABLE                    \ control self hosted debug enable with signal dbgswenable


\
\ @brief BSEC OTP disturbed status register 0
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DISTURBED0_DIS                     \ disturbed status of the corresponding OTP word Note: ECC bits resilience against hardware attacks is applied only to lower OTP region.


\
\ @brief BSEC OTP disturbed status register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DISTURBED1_DIS                     \ disturbed status of the corresponding OTP word Note: ECC bits resilience against hardware attacks is applied only to lower OTP region.


\
\ @brief BSEC OTP disturbed status register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DISTURBED2_DIS                     \ disturbed status of the corresponding OTP word Note: ECC bits resilience against hardware attacks is applied only to lower OTP region.


\
\ @brief BSEC OTP error status register 0
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_ERROR0_ERR                         \ error status of the correspond OTP word


\
\ @brief BSEC OTP error status register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_ERROR1_ERR                         \ error status of the correspond OTP word


\
\ @brief BSEC OTP error status register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_ERROR2_ERR                         \ error status of the correspond OTP word


\
\ @brief BSEC OTP lock status register 0
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_WRLOCK0_WRLOCK                     \ permanent word lock status of the correspond OTP word


\
\ @brief BSEC OTP lock status register 1
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_WRLOCK1_WRLOCK                     \ permanent word lock status of the correspond OTP word


\
\ @brief BSEC OTP lock status register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_WRLOCK2_WRLOCK                     \ permanent word lock status of the correspond OTP word


\
\ @brief BSEC OTP sticky programming lock register 0
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SPLOCK0_SPLOCK                     \ lock programming for the OTP word until next power-on reset


\
\ @brief BSEC OTP sticky programming lock register 1
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SPLOCK1_SPLOCK                     \ lock programming for the OTP word until next power-on reset


\
\ @brief BSEC OTP sticky programming lock register 2
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SPLOCK2_SPLOCK                     \ lock programming for the OTP word until next power-on reset


\
\ @brief BSEC OTP shadow write sticky lock register 0
\ Address offset: 0x7C
\ Reset value: 0x00000001
\

$00000000 constant BSEC_BSEC_OTP_SWLOCK0_SWLOCK                     \ lock the writing for the OTP shadow word until next power-on reset. Note: BSEC_OTP_SWLOCK0 bit 0 is forced to 1 by hardware, writing to this bit has no effect.


\
\ @brief BSEC OTP shadow write sticky lock register 1
\ Address offset: 0x80
\ Reset value: 0x00000001
\

$00000000 constant BSEC_BSEC_OTP_SWLOCK1_SWLOCK                     \ lock the writing for the OTP shadow word until next power-on reset. Note: BSEC_OTP_SWLOCK0 bit 0 is forced to 1 by hardware, writing to this bit has no effect.


\
\ @brief BSEC OTP shadow write sticky lock register 2
\ Address offset: 0x84
\ Reset value: 0x00000001
\

$00000000 constant BSEC_BSEC_OTP_SWLOCK2_SWLOCK                     \ lock the writing for the OTP shadow word until next power-on reset. Note: BSEC_OTP_SWLOCK0 bit 0 is forced to 1 by hardware, writing to this bit has no effect.


\
\ @brief BSEC OTP shadow read sticky lock register 0
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SRLOCK0_SRLOCK                     \ prevent reloading of the shadow word from OTP until next power-on reset. Note: Reloading of OTP word 0 is prevented after its initial read on a system reset.


\
\ @brief BSEC OTP shadow read sticky lock register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SRLOCK1_SRLOCK                     \ prevent reloading of the shadow word from OTP until next power-on reset. Note: Reloading of OTP word 0 is prevented after its initial read on a system reset.


\
\ @brief BSEC OTP shadow read sticky lock register 2
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_SRLOCK2_SRLOCK                     \ prevent reloading of the shadow word from OTP until next power-on reset. Note: Reloading of OTP word 0 is prevented after its initial read on a system reset.


\
\ @brief BSEC JTAG input register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_JTAGIN_DATA                            \ JTAG input data 32-bit copy from JTAG SoC register


\
\ @brief BSEC JTAG output register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_JTAGOUT_DATA                           \ JTAG output data 32-bit copy to JTAG SoC register


\
\ @brief BSEC scratch register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_SCRATCH_DATA                           \ scratch data This register is a general purpose register.


\
\ @brief BSEC shadow register 0
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA0_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 1
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA1_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 2
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA2_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA3_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 4
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA4_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 5
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA5_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 6
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA6_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 7
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA7_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 8
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA8_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 9
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA9_DATA                         \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 10
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA10_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 11
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA11_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 12
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA12_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 13
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA13_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 14
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA14_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 15
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA15_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 16
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA16_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 17
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA17_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 18
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA18_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 19
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA19_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 20
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA20_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 21
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA21_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 22
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA22_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 23
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA23_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 24
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA24_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 25
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA25_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 26
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA26_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 27
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA27_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 28
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA28_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 29
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA29_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 30
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA30_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 31
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA31_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 32
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA32_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 33
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA33_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 34
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA34_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 35
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA35_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 36
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA36_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 37
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA37_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 38
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA38_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 39
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA39_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 40
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA40_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 41
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA41_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 42
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA42_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 43
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA43_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 44
\ Address offset: 0x2B0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA44_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 45
\ Address offset: 0x2B4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA45_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 46
\ Address offset: 0x2B8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA46_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 47
\ Address offset: 0x2BC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA47_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 48
\ Address offset: 0x2C0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA48_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 49
\ Address offset: 0x2C4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA49_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 50
\ Address offset: 0x2C8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA50_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 51
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA51_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 52
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA52_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 53
\ Address offset: 0x2D4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA53_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 54
\ Address offset: 0x2D8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA54_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 55
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA55_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 56
\ Address offset: 0x2E0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA56_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 57
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA57_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 58
\ Address offset: 0x2E8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA58_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 59
\ Address offset: 0x2EC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA59_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 60
\ Address offset: 0x2F0
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA60_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 61
\ Address offset: 0x2F4
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA61_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 62
\ Address offset: 0x2F8
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA62_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 63
\ Address offset: 0x2FC
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA63_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 64
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA64_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 65
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA65_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 66
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA66_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 67
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA67_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 68
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA68_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 69
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA69_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 70
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA70_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 71
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA71_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 72
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA72_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 73
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA73_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 74
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA74_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 75
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA75_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 76
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA76_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 77
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA77_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 78
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA78_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 79
\ Address offset: 0x33C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA79_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 80
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA80_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 81
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA81_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 82
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA82_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 83
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA83_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 84
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA84_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 85
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA85_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 86
\ Address offset: 0x358
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA86_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 87
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA87_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 88
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA88_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 89
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA89_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 90
\ Address offset: 0x368
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA90_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 91
\ Address offset: 0x36C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA91_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 92
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA92_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 93
\ Address offset: 0x374
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA93_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 94
\ Address offset: 0x378
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA94_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC shadow register 95
\ Address offset: 0x37C
\ Reset value: 0x00000000
\

$00000000 constant BSEC_BSEC_OTP_DATA95_DATA                        \ shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.


\
\ @brief BSEC hardware configuration register
\ Address offset: 0xFF0
\ Reset value: 0x00000014
\

$0000000f constant BSEC_BSEC_HWCFGR_SIZE                            \ OTP block size Others: reserved
$000000f0 constant BSEC_BSEC_HWCFGR_ECC_USE                         \ protection / redundancy scheme used Others: reserved


\
\ @brief BSEC version register
\ Address offset: 0xFF4
\ Reset value: 0x00000020
\

$0000000f constant BSEC_BSEC_VERR_MINREV                            \ minor revision information
$000000f0 constant BSEC_BSEC_VERR_MAJREV                            \ major revision information


\
\ @brief BSEC identification register
\ Address offset: 0xFF8
\ Reset value: 0x00100032
\

$00000000 constant BSEC_BSEC_IPIDR_ID                               \ BSEC identification


\
\ @brief BSEC size identification register
\ Address offset: 0xFFC
\ Reset value: 0xA3C5DD04
\

$00000000 constant BSEC_BSEC_SIDR_SID                               \ BSEC size identification


\
\ @brief BSEC
\
$5c005000 constant BSEC_BSEC_OTP_CONFIG  \ offset: 0x00 : BSEC OTP configuration register
$5c005004 constant BSEC_BSEC_OTP_CONTROL  \ offset: 0x04 : BSEC OTP control register
$5c005008 constant BSEC_BSEC_OTP_WRDATA  \ offset: 0x08 : BSEC OTP write data register
$5c00500c constant BSEC_BSEC_OTP_STATUS  \ offset: 0x0C : BSEC OTP status register
$5c005010 constant BSEC_BSEC_OTP_LOCK  \ offset: 0x10 : BSEC OTP lock configuration register
$5c005014 constant BSEC_BSEC_DENABLE  \ offset: 0x14 : BSEC debug configuration register
$5c00501c constant BSEC_BSEC_OTP_DISTURBED0  \ offset: 0x1C : BSEC OTP disturbed status register 0
$5c005020 constant BSEC_BSEC_OTP_DISTURBED1  \ offset: 0x20 : BSEC OTP disturbed status register 1
$5c005024 constant BSEC_BSEC_OTP_DISTURBED2  \ offset: 0x24 : BSEC OTP disturbed status register 2
$5c005034 constant BSEC_BSEC_OTP_ERROR0  \ offset: 0x34 : BSEC OTP error status register 0
$5c005038 constant BSEC_BSEC_OTP_ERROR1  \ offset: 0x38 : BSEC OTP error status register 1
$5c00503c constant BSEC_BSEC_OTP_ERROR2  \ offset: 0x3C : BSEC OTP error status register 2
$5c00504c constant BSEC_BSEC_OTP_WRLOCK0  \ offset: 0x4C : BSEC OTP lock status register 0
$5c005050 constant BSEC_BSEC_OTP_WRLOCK1  \ offset: 0x50 : BSEC OTP lock status register 1
$5c005054 constant BSEC_BSEC_OTP_WRLOCK2  \ offset: 0x54 : BSEC OTP lock status register 2
$5c005064 constant BSEC_BSEC_OTP_SPLOCK0  \ offset: 0x64 : BSEC OTP sticky programming lock register 0
$5c005068 constant BSEC_BSEC_OTP_SPLOCK1  \ offset: 0x68 : BSEC OTP sticky programming lock register 1
$5c00506c constant BSEC_BSEC_OTP_SPLOCK2  \ offset: 0x6C : BSEC OTP sticky programming lock register 2
$5c00507c constant BSEC_BSEC_OTP_SWLOCK0  \ offset: 0x7C : BSEC OTP shadow write sticky lock register 0
$5c005080 constant BSEC_BSEC_OTP_SWLOCK1  \ offset: 0x80 : BSEC OTP shadow write sticky lock register 1
$5c005084 constant BSEC_BSEC_OTP_SWLOCK2  \ offset: 0x84 : BSEC OTP shadow write sticky lock register 2
$5c005094 constant BSEC_BSEC_OTP_SRLOCK0  \ offset: 0x94 : BSEC OTP shadow read sticky lock register 0
$5c005098 constant BSEC_BSEC_OTP_SRLOCK1  \ offset: 0x98 : BSEC OTP shadow read sticky lock register 1
$5c00509c constant BSEC_BSEC_OTP_SRLOCK2  \ offset: 0x9C : BSEC OTP shadow read sticky lock register 2
$5c0050ac constant BSEC_BSEC_JTAGIN  \ offset: 0xAC : BSEC JTAG input register
$5c0050b0 constant BSEC_BSEC_JTAGOUT  \ offset: 0xB0 : BSEC JTAG output register
$5c0050b4 constant BSEC_BSEC_SCRATCH  \ offset: 0xB4 : BSEC scratch register
$5c005200 constant BSEC_BSEC_OTP_DATA0  \ offset: 0x200 : BSEC shadow register 0
$5c005204 constant BSEC_BSEC_OTP_DATA1  \ offset: 0x204 : BSEC shadow register 1
$5c005208 constant BSEC_BSEC_OTP_DATA2  \ offset: 0x208 : BSEC shadow register 2
$5c00520c constant BSEC_BSEC_OTP_DATA3  \ offset: 0x20C : BSEC shadow register 3
$5c005210 constant BSEC_BSEC_OTP_DATA4  \ offset: 0x210 : BSEC shadow register 4
$5c005214 constant BSEC_BSEC_OTP_DATA5  \ offset: 0x214 : BSEC shadow register 5
$5c005218 constant BSEC_BSEC_OTP_DATA6  \ offset: 0x218 : BSEC shadow register 6
$5c00521c constant BSEC_BSEC_OTP_DATA7  \ offset: 0x21C : BSEC shadow register 7
$5c005220 constant BSEC_BSEC_OTP_DATA8  \ offset: 0x220 : BSEC shadow register 8
$5c005224 constant BSEC_BSEC_OTP_DATA9  \ offset: 0x224 : BSEC shadow register 9
$5c005228 constant BSEC_BSEC_OTP_DATA10  \ offset: 0x228 : BSEC shadow register 10
$5c00522c constant BSEC_BSEC_OTP_DATA11  \ offset: 0x22C : BSEC shadow register 11
$5c005230 constant BSEC_BSEC_OTP_DATA12  \ offset: 0x230 : BSEC shadow register 12
$5c005234 constant BSEC_BSEC_OTP_DATA13  \ offset: 0x234 : BSEC shadow register 13
$5c005238 constant BSEC_BSEC_OTP_DATA14  \ offset: 0x238 : BSEC shadow register 14
$5c00523c constant BSEC_BSEC_OTP_DATA15  \ offset: 0x23C : BSEC shadow register 15
$5c005240 constant BSEC_BSEC_OTP_DATA16  \ offset: 0x240 : BSEC shadow register 16
$5c005244 constant BSEC_BSEC_OTP_DATA17  \ offset: 0x244 : BSEC shadow register 17
$5c005248 constant BSEC_BSEC_OTP_DATA18  \ offset: 0x248 : BSEC shadow register 18
$5c00524c constant BSEC_BSEC_OTP_DATA19  \ offset: 0x24C : BSEC shadow register 19
$5c005250 constant BSEC_BSEC_OTP_DATA20  \ offset: 0x250 : BSEC shadow register 20
$5c005254 constant BSEC_BSEC_OTP_DATA21  \ offset: 0x254 : BSEC shadow register 21
$5c005258 constant BSEC_BSEC_OTP_DATA22  \ offset: 0x258 : BSEC shadow register 22
$5c00525c constant BSEC_BSEC_OTP_DATA23  \ offset: 0x25C : BSEC shadow register 23
$5c005260 constant BSEC_BSEC_OTP_DATA24  \ offset: 0x260 : BSEC shadow register 24
$5c005264 constant BSEC_BSEC_OTP_DATA25  \ offset: 0x264 : BSEC shadow register 25
$5c005268 constant BSEC_BSEC_OTP_DATA26  \ offset: 0x268 : BSEC shadow register 26
$5c00526c constant BSEC_BSEC_OTP_DATA27  \ offset: 0x26C : BSEC shadow register 27
$5c005270 constant BSEC_BSEC_OTP_DATA28  \ offset: 0x270 : BSEC shadow register 28
$5c005274 constant BSEC_BSEC_OTP_DATA29  \ offset: 0x274 : BSEC shadow register 29
$5c005278 constant BSEC_BSEC_OTP_DATA30  \ offset: 0x278 : BSEC shadow register 30
$5c00527c constant BSEC_BSEC_OTP_DATA31  \ offset: 0x27C : BSEC shadow register 31
$5c005280 constant BSEC_BSEC_OTP_DATA32  \ offset: 0x280 : BSEC shadow register 32
$5c005284 constant BSEC_BSEC_OTP_DATA33  \ offset: 0x284 : BSEC shadow register 33
$5c005288 constant BSEC_BSEC_OTP_DATA34  \ offset: 0x288 : BSEC shadow register 34
$5c00528c constant BSEC_BSEC_OTP_DATA35  \ offset: 0x28C : BSEC shadow register 35
$5c005290 constant BSEC_BSEC_OTP_DATA36  \ offset: 0x290 : BSEC shadow register 36
$5c005294 constant BSEC_BSEC_OTP_DATA37  \ offset: 0x294 : BSEC shadow register 37
$5c005298 constant BSEC_BSEC_OTP_DATA38  \ offset: 0x298 : BSEC shadow register 38
$5c00529c constant BSEC_BSEC_OTP_DATA39  \ offset: 0x29C : BSEC shadow register 39
$5c0052a0 constant BSEC_BSEC_OTP_DATA40  \ offset: 0x2A0 : BSEC shadow register 40
$5c0052a4 constant BSEC_BSEC_OTP_DATA41  \ offset: 0x2A4 : BSEC shadow register 41
$5c0052a8 constant BSEC_BSEC_OTP_DATA42  \ offset: 0x2A8 : BSEC shadow register 42
$5c0052ac constant BSEC_BSEC_OTP_DATA43  \ offset: 0x2AC : BSEC shadow register 43
$5c0052b0 constant BSEC_BSEC_OTP_DATA44  \ offset: 0x2B0 : BSEC shadow register 44
$5c0052b4 constant BSEC_BSEC_OTP_DATA45  \ offset: 0x2B4 : BSEC shadow register 45
$5c0052b8 constant BSEC_BSEC_OTP_DATA46  \ offset: 0x2B8 : BSEC shadow register 46
$5c0052bc constant BSEC_BSEC_OTP_DATA47  \ offset: 0x2BC : BSEC shadow register 47
$5c0052c0 constant BSEC_BSEC_OTP_DATA48  \ offset: 0x2C0 : BSEC shadow register 48
$5c0052c4 constant BSEC_BSEC_OTP_DATA49  \ offset: 0x2C4 : BSEC shadow register 49
$5c0052c8 constant BSEC_BSEC_OTP_DATA50  \ offset: 0x2C8 : BSEC shadow register 50
$5c0052cc constant BSEC_BSEC_OTP_DATA51  \ offset: 0x2CC : BSEC shadow register 51
$5c0052d0 constant BSEC_BSEC_OTP_DATA52  \ offset: 0x2D0 : BSEC shadow register 52
$5c0052d4 constant BSEC_BSEC_OTP_DATA53  \ offset: 0x2D4 : BSEC shadow register 53
$5c0052d8 constant BSEC_BSEC_OTP_DATA54  \ offset: 0x2D8 : BSEC shadow register 54
$5c0052dc constant BSEC_BSEC_OTP_DATA55  \ offset: 0x2DC : BSEC shadow register 55
$5c0052e0 constant BSEC_BSEC_OTP_DATA56  \ offset: 0x2E0 : BSEC shadow register 56
$5c0052e4 constant BSEC_BSEC_OTP_DATA57  \ offset: 0x2E4 : BSEC shadow register 57
$5c0052e8 constant BSEC_BSEC_OTP_DATA58  \ offset: 0x2E8 : BSEC shadow register 58
$5c0052ec constant BSEC_BSEC_OTP_DATA59  \ offset: 0x2EC : BSEC shadow register 59
$5c0052f0 constant BSEC_BSEC_OTP_DATA60  \ offset: 0x2F0 : BSEC shadow register 60
$5c0052f4 constant BSEC_BSEC_OTP_DATA61  \ offset: 0x2F4 : BSEC shadow register 61
$5c0052f8 constant BSEC_BSEC_OTP_DATA62  \ offset: 0x2F8 : BSEC shadow register 62
$5c0052fc constant BSEC_BSEC_OTP_DATA63  \ offset: 0x2FC : BSEC shadow register 63
$5c005300 constant BSEC_BSEC_OTP_DATA64  \ offset: 0x300 : BSEC shadow register 64
$5c005304 constant BSEC_BSEC_OTP_DATA65  \ offset: 0x304 : BSEC shadow register 65
$5c005308 constant BSEC_BSEC_OTP_DATA66  \ offset: 0x308 : BSEC shadow register 66
$5c00530c constant BSEC_BSEC_OTP_DATA67  \ offset: 0x30C : BSEC shadow register 67
$5c005310 constant BSEC_BSEC_OTP_DATA68  \ offset: 0x310 : BSEC shadow register 68
$5c005314 constant BSEC_BSEC_OTP_DATA69  \ offset: 0x314 : BSEC shadow register 69
$5c005318 constant BSEC_BSEC_OTP_DATA70  \ offset: 0x318 : BSEC shadow register 70
$5c00531c constant BSEC_BSEC_OTP_DATA71  \ offset: 0x31C : BSEC shadow register 71
$5c005320 constant BSEC_BSEC_OTP_DATA72  \ offset: 0x320 : BSEC shadow register 72
$5c005324 constant BSEC_BSEC_OTP_DATA73  \ offset: 0x324 : BSEC shadow register 73
$5c005328 constant BSEC_BSEC_OTP_DATA74  \ offset: 0x328 : BSEC shadow register 74
$5c00532c constant BSEC_BSEC_OTP_DATA75  \ offset: 0x32C : BSEC shadow register 75
$5c005330 constant BSEC_BSEC_OTP_DATA76  \ offset: 0x330 : BSEC shadow register 76
$5c005334 constant BSEC_BSEC_OTP_DATA77  \ offset: 0x334 : BSEC shadow register 77
$5c005338 constant BSEC_BSEC_OTP_DATA78  \ offset: 0x338 : BSEC shadow register 78
$5c00533c constant BSEC_BSEC_OTP_DATA79  \ offset: 0x33C : BSEC shadow register 79
$5c005340 constant BSEC_BSEC_OTP_DATA80  \ offset: 0x340 : BSEC shadow register 80
$5c005344 constant BSEC_BSEC_OTP_DATA81  \ offset: 0x344 : BSEC shadow register 81
$5c005348 constant BSEC_BSEC_OTP_DATA82  \ offset: 0x348 : BSEC shadow register 82
$5c00534c constant BSEC_BSEC_OTP_DATA83  \ offset: 0x34C : BSEC shadow register 83
$5c005350 constant BSEC_BSEC_OTP_DATA84  \ offset: 0x350 : BSEC shadow register 84
$5c005354 constant BSEC_BSEC_OTP_DATA85  \ offset: 0x354 : BSEC shadow register 85
$5c005358 constant BSEC_BSEC_OTP_DATA86  \ offset: 0x358 : BSEC shadow register 86
$5c00535c constant BSEC_BSEC_OTP_DATA87  \ offset: 0x35C : BSEC shadow register 87
$5c005360 constant BSEC_BSEC_OTP_DATA88  \ offset: 0x360 : BSEC shadow register 88
$5c005364 constant BSEC_BSEC_OTP_DATA89  \ offset: 0x364 : BSEC shadow register 89
$5c005368 constant BSEC_BSEC_OTP_DATA90  \ offset: 0x368 : BSEC shadow register 90
$5c00536c constant BSEC_BSEC_OTP_DATA91  \ offset: 0x36C : BSEC shadow register 91
$5c005370 constant BSEC_BSEC_OTP_DATA92  \ offset: 0x370 : BSEC shadow register 92
$5c005374 constant BSEC_BSEC_OTP_DATA93  \ offset: 0x374 : BSEC shadow register 93
$5c005378 constant BSEC_BSEC_OTP_DATA94  \ offset: 0x378 : BSEC shadow register 94
$5c00537c constant BSEC_BSEC_OTP_DATA95  \ offset: 0x37C : BSEC shadow register 95
$5c005ff0 constant BSEC_BSEC_HWCFGR  \ offset: 0xFF0 : BSEC hardware configuration register
$5c005ff4 constant BSEC_BSEC_VERR  \ offset: 0xFF4 : BSEC version register
$5c005ff8 constant BSEC_BSEC_IPIDR  \ offset: 0xFF8 : BSEC identification register
$5c005ffc constant BSEC_BSEC_SIDR  \ offset: 0xFFC : BSEC size identification register

