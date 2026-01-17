\
\ @file bsec.fs
\ @brief BSEC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] BSEC_DEF

  [ifdef] BSEC_BSEC_OTP_CONFIG_DEF
    \
    \ @brief BSEC OTP configuration register
    \ Address offset: 0x00
    \ Reset value: 0x0000000E
    \
    $00 constant BSEC_PWRUP                     \ [0x00] OTP power-up control Note: After the power-on initial read of OTP, BSEC powers down OTP. PWRUP bit is then cleared. Prior to any read or programming operation, OTP must be powered up again by setting PWRUP bit. OTP read is qualified by pwrok input signal, which indicates that VDD and VDD1 supplies are in valid range.
    $01 constant BSEC_FRC                       \ [0x01 : 2] OTP clock frequency range selection Note: 0b11 is used by default. OTP initial read is always using an internal OSC with 64 MHz max frequency. Reading OTP at a lower frequency than the range programmed by FRC[1:0] is possible.
    $03 constant BSEC_PRGWIDTH                  \ [0x03 : 4] OTP programming pulse width (default = 0b0001)
    $07 constant BSEC_TREAD                     \ [0x07 : 2] set OTP reading current level (default = 0b00)
  [then]


  [ifdef] BSEC_BSEC_OTP_CONTROL_DEF
    \
    \ @brief BSEC OTP control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_ADDR                      \ [0x00 : 7] OTP word address Actual OTP word address. Words address are from 0 to 95 for BSEC Note: the actual OTP word address is adjusted according to the redundancy or ECC scheme.
    $08 constant BSEC_PROG                      \ [0x08] OTP operation control
    $09 constant BSEC_LOCK                      \ [0x09] OTP permanent word lock control
  [then]


  [ifdef] BSEC_BSEC_OTP_WRDATA_DEF
    \
    \ @brief BSEC OTP write data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRDATA                    \ [0x00 : 32] OTP write data
  [then]


  [ifdef] BSEC_BSEC_OTP_STATUS_DEF
    \
    \ @brief BSEC OTP status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SECURE                    \ [0x00] OTP secured mode
    $02 constant BSEC_INVALID                   \ [0x02] OTP invalid mode
    $03 constant BSEC_BUSY                      \ [0x03] OTP operation status Note: bit polling is used to determine operation completion.
    $04 constant BSEC_PROGFAIL                  \ [0x04] last programming status
    $05 constant BSEC_PWRON                     \ [0x05] OTP power status Note: used to poll pwrok signal value
    $08 constant BSEC_CLOSED                    \ [0x08] OTP_SECURED mode
    $09 constant BSEC_BSCANDIS                  \ [0x09] Boundary Scan status
    $0a constant BSEC_JTAGDIS                   \ [0x0a] JTAG port status
  [then]


  [ifdef] BSEC_BSEC_OTP_LOCK_DEF
    \
    \ @brief BSEC OTP lock configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_OTP                       \ [0x00] upper OTP read lock
    $01 constant BSEC_ROMLOCK                   \ [0x01] Upper ROM region read lock The upper ROM region is accessible only in OTP-SECURED open and OTP-SECURED closed modes and ROMLOCK bit is relevant only in these modes.
    $02 constant BSEC_DENREG                    \ [0x02] debug enable register sticky lock
    $04 constant BSEC_GPLOCK                    \ [0x04] programming sticky lock
  [then]


  [ifdef] BSEC_BSEC_DENABLE_DEF
    \
    \ @brief BSEC debug configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $01 constant BSEC_DBGEN                     \ [0x01] debug enable with signal dbgen
    $02 constant BSEC_NIDEN                     \ [0x02] non-invasive debug enable with signal niden
    $03 constant BSEC_DEVICEEN                  \ [0x03] controls access to debug component via external debug port by signal deviceen
    $04 constant BSEC_HDPEN                     \ [0x04] hardware debug port enable with signal hdpen
    $05 constant BSEC_SPIDEN                    \ [0x05] secure privilege invasive debug enable with signal spniden
    $06 constant BSEC_SPNIDEN                   \ [0x06] secure privilege non-invasive debug enable with signal spiden
    $07 constant BSEC_CP15SDISABLE              \ [0x07] write access to some secure Cortex®-A7 CP15 registers disable
    $09 constant BSEC_CFGSDISABLE               \ [0x09] write access to secure GIC registers disable with signal cfgsdisable
    $0a constant BSEC_DBGSWENABLE               \ [0x0a] control self hosted debug enable with signal dbgswenable
  [then]


  [ifdef] BSEC_BSEC_OTP_DISTURBED0_DEF
    \
    \ @brief BSEC OTP disturbed status register 0
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DIS                       \ [0x00 : 32] disturbed status of the corresponding OTP word Note: ECC bits resilience against hardware attacks is applied only to lower OTP region.
  [then]


  [ifdef] BSEC_BSEC_OTP_DISTURBED1_DEF
    \
    \ @brief BSEC OTP disturbed status register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DIS                       \ [0x00 : 32] disturbed status of the corresponding OTP word Note: ECC bits resilience against hardware attacks is applied only to lower OTP region.
  [then]


  [ifdef] BSEC_BSEC_OTP_DISTURBED2_DEF
    \
    \ @brief BSEC OTP disturbed status register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DIS                       \ [0x00 : 32] disturbed status of the corresponding OTP word Note: ECC bits resilience against hardware attacks is applied only to lower OTP region.
  [then]


  [ifdef] BSEC_BSEC_OTP_ERROR0_DEF
    \
    \ @brief BSEC OTP error status register 0
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_ERR                       \ [0x00 : 32] error status of the correspond OTP word
  [then]


  [ifdef] BSEC_BSEC_OTP_ERROR1_DEF
    \
    \ @brief BSEC OTP error status register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_ERR                       \ [0x00 : 32] error status of the correspond OTP word
  [then]


  [ifdef] BSEC_BSEC_OTP_ERROR2_DEF
    \
    \ @brief BSEC OTP error status register 2
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_ERR                       \ [0x00 : 32] error status of the correspond OTP word
  [then]


  [ifdef] BSEC_BSEC_OTP_WRLOCK0_DEF
    \
    \ @brief BSEC OTP lock status register 0
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRLOCK                    \ [0x00 : 32] permanent word lock status of the correspond OTP word
  [then]


  [ifdef] BSEC_BSEC_OTP_WRLOCK1_DEF
    \
    \ @brief BSEC OTP lock status register 1
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRLOCK                    \ [0x00 : 32] permanent word lock status of the correspond OTP word
  [then]


  [ifdef] BSEC_BSEC_OTP_WRLOCK2_DEF
    \
    \ @brief BSEC OTP lock status register 2
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRLOCK                    \ [0x00 : 32] permanent word lock status of the correspond OTP word
  [then]


  [ifdef] BSEC_BSEC_OTP_SPLOCK0_DEF
    \
    \ @brief BSEC OTP sticky programming lock register 0
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK                    \ [0x00 : 32] lock programming for the OTP word until next power-on reset
  [then]


  [ifdef] BSEC_BSEC_OTP_SPLOCK1_DEF
    \
    \ @brief BSEC OTP sticky programming lock register 1
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK                    \ [0x00 : 32] lock programming for the OTP word until next power-on reset
  [then]


  [ifdef] BSEC_BSEC_OTP_SPLOCK2_DEF
    \
    \ @brief BSEC OTP sticky programming lock register 2
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK                    \ [0x00 : 32] lock programming for the OTP word until next power-on reset
  [then]


  [ifdef] BSEC_BSEC_OTP_SWLOCK0_DEF
    \
    \ @brief BSEC OTP shadow write sticky lock register 0
    \ Address offset: 0x7C
    \ Reset value: 0x00000001
    \
    $00 constant BSEC_SWLOCK                    \ [0x00 : 32] lock the writing for the OTP shadow word until next power-on reset. Note: BSEC_OTP_SWLOCK0 bit 0 is forced to 1 by hardware, writing to this bit has no effect.
  [then]


  [ifdef] BSEC_BSEC_OTP_SWLOCK1_DEF
    \
    \ @brief BSEC OTP shadow write sticky lock register 1
    \ Address offset: 0x80
    \ Reset value: 0x00000001
    \
    $00 constant BSEC_SWLOCK                    \ [0x00 : 32] lock the writing for the OTP shadow word until next power-on reset. Note: BSEC_OTP_SWLOCK0 bit 0 is forced to 1 by hardware, writing to this bit has no effect.
  [then]


  [ifdef] BSEC_BSEC_OTP_SWLOCK2_DEF
    \
    \ @brief BSEC OTP shadow write sticky lock register 2
    \ Address offset: 0x84
    \ Reset value: 0x00000001
    \
    $00 constant BSEC_SWLOCK                    \ [0x00 : 32] lock the writing for the OTP shadow word until next power-on reset. Note: BSEC_OTP_SWLOCK0 bit 0 is forced to 1 by hardware, writing to this bit has no effect.
  [then]


  [ifdef] BSEC_BSEC_OTP_SRLOCK0_DEF
    \
    \ @brief BSEC OTP shadow read sticky lock register 0
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK                    \ [0x00 : 32] prevent reloading of the shadow word from OTP until next power-on reset. Note: Reloading of OTP word 0 is prevented after its initial read on a system reset.
  [then]


  [ifdef] BSEC_BSEC_OTP_SRLOCK1_DEF
    \
    \ @brief BSEC OTP shadow read sticky lock register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK                    \ [0x00 : 32] prevent reloading of the shadow word from OTP until next power-on reset. Note: Reloading of OTP word 0 is prevented after its initial read on a system reset.
  [then]


  [ifdef] BSEC_BSEC_OTP_SRLOCK2_DEF
    \
    \ @brief BSEC OTP shadow read sticky lock register 2
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK                    \ [0x00 : 32] prevent reloading of the shadow word from OTP until next power-on reset. Note: Reloading of OTP word 0 is prevented after its initial read on a system reset.
  [then]


  [ifdef] BSEC_BSEC_JTAGIN_DEF
    \
    \ @brief BSEC JTAG input register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] JTAG input data 32-bit copy from JTAG SoC register
  [then]


  [ifdef] BSEC_BSEC_JTAGOUT_DEF
    \
    \ @brief BSEC JTAG output register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] JTAG output data 32-bit copy to JTAG SoC register
  [then]


  [ifdef] BSEC_BSEC_SCRATCH_DEF
    \
    \ @brief BSEC scratch register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] scratch data This register is a general purpose register.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA0_DEF
    \
    \ @brief BSEC shadow register 0
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA1_DEF
    \
    \ @brief BSEC shadow register 1
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA2_DEF
    \
    \ @brief BSEC shadow register 2
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA3_DEF
    \
    \ @brief BSEC shadow register 3
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA4_DEF
    \
    \ @brief BSEC shadow register 4
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA5_DEF
    \
    \ @brief BSEC shadow register 5
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA6_DEF
    \
    \ @brief BSEC shadow register 6
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA7_DEF
    \
    \ @brief BSEC shadow register 7
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA8_DEF
    \
    \ @brief BSEC shadow register 8
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA9_DEF
    \
    \ @brief BSEC shadow register 9
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA10_DEF
    \
    \ @brief BSEC shadow register 10
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA11_DEF
    \
    \ @brief BSEC shadow register 11
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA12_DEF
    \
    \ @brief BSEC shadow register 12
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA13_DEF
    \
    \ @brief BSEC shadow register 13
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA14_DEF
    \
    \ @brief BSEC shadow register 14
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA15_DEF
    \
    \ @brief BSEC shadow register 15
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA16_DEF
    \
    \ @brief BSEC shadow register 16
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA17_DEF
    \
    \ @brief BSEC shadow register 17
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA18_DEF
    \
    \ @brief BSEC shadow register 18
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA19_DEF
    \
    \ @brief BSEC shadow register 19
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA20_DEF
    \
    \ @brief BSEC shadow register 20
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA21_DEF
    \
    \ @brief BSEC shadow register 21
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA22_DEF
    \
    \ @brief BSEC shadow register 22
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA23_DEF
    \
    \ @brief BSEC shadow register 23
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA24_DEF
    \
    \ @brief BSEC shadow register 24
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA25_DEF
    \
    \ @brief BSEC shadow register 25
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA26_DEF
    \
    \ @brief BSEC shadow register 26
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA27_DEF
    \
    \ @brief BSEC shadow register 27
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA28_DEF
    \
    \ @brief BSEC shadow register 28
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA29_DEF
    \
    \ @brief BSEC shadow register 29
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA30_DEF
    \
    \ @brief BSEC shadow register 30
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA31_DEF
    \
    \ @brief BSEC shadow register 31
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA32_DEF
    \
    \ @brief BSEC shadow register 32
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA33_DEF
    \
    \ @brief BSEC shadow register 33
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA34_DEF
    \
    \ @brief BSEC shadow register 34
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA35_DEF
    \
    \ @brief BSEC shadow register 35
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA36_DEF
    \
    \ @brief BSEC shadow register 36
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA37_DEF
    \
    \ @brief BSEC shadow register 37
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA38_DEF
    \
    \ @brief BSEC shadow register 38
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA39_DEF
    \
    \ @brief BSEC shadow register 39
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA40_DEF
    \
    \ @brief BSEC shadow register 40
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA41_DEF
    \
    \ @brief BSEC shadow register 41
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA42_DEF
    \
    \ @brief BSEC shadow register 42
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA43_DEF
    \
    \ @brief BSEC shadow register 43
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA44_DEF
    \
    \ @brief BSEC shadow register 44
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA45_DEF
    \
    \ @brief BSEC shadow register 45
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA46_DEF
    \
    \ @brief BSEC shadow register 46
    \ Address offset: 0x2B8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA47_DEF
    \
    \ @brief BSEC shadow register 47
    \ Address offset: 0x2BC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA48_DEF
    \
    \ @brief BSEC shadow register 48
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA49_DEF
    \
    \ @brief BSEC shadow register 49
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA50_DEF
    \
    \ @brief BSEC shadow register 50
    \ Address offset: 0x2C8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA51_DEF
    \
    \ @brief BSEC shadow register 51
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA52_DEF
    \
    \ @brief BSEC shadow register 52
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA53_DEF
    \
    \ @brief BSEC shadow register 53
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA54_DEF
    \
    \ @brief BSEC shadow register 54
    \ Address offset: 0x2D8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA55_DEF
    \
    \ @brief BSEC shadow register 55
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA56_DEF
    \
    \ @brief BSEC shadow register 56
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA57_DEF
    \
    \ @brief BSEC shadow register 57
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA58_DEF
    \
    \ @brief BSEC shadow register 58
    \ Address offset: 0x2E8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA59_DEF
    \
    \ @brief BSEC shadow register 59
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA60_DEF
    \
    \ @brief BSEC shadow register 60
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA61_DEF
    \
    \ @brief BSEC shadow register 61
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA62_DEF
    \
    \ @brief BSEC shadow register 62
    \ Address offset: 0x2F8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA63_DEF
    \
    \ @brief BSEC shadow register 63
    \ Address offset: 0x2FC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA64_DEF
    \
    \ @brief BSEC shadow register 64
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA65_DEF
    \
    \ @brief BSEC shadow register 65
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA66_DEF
    \
    \ @brief BSEC shadow register 66
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA67_DEF
    \
    \ @brief BSEC shadow register 67
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA68_DEF
    \
    \ @brief BSEC shadow register 68
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA69_DEF
    \
    \ @brief BSEC shadow register 69
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA70_DEF
    \
    \ @brief BSEC shadow register 70
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA71_DEF
    \
    \ @brief BSEC shadow register 71
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA72_DEF
    \
    \ @brief BSEC shadow register 72
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA73_DEF
    \
    \ @brief BSEC shadow register 73
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA74_DEF
    \
    \ @brief BSEC shadow register 74
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA75_DEF
    \
    \ @brief BSEC shadow register 75
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA76_DEF
    \
    \ @brief BSEC shadow register 76
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA77_DEF
    \
    \ @brief BSEC shadow register 77
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA78_DEF
    \
    \ @brief BSEC shadow register 78
    \ Address offset: 0x338
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA79_DEF
    \
    \ @brief BSEC shadow register 79
    \ Address offset: 0x33C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA80_DEF
    \
    \ @brief BSEC shadow register 80
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA81_DEF
    \
    \ @brief BSEC shadow register 81
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA82_DEF
    \
    \ @brief BSEC shadow register 82
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA83_DEF
    \
    \ @brief BSEC shadow register 83
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA84_DEF
    \
    \ @brief BSEC shadow register 84
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA85_DEF
    \
    \ @brief BSEC shadow register 85
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA86_DEF
    \
    \ @brief BSEC shadow register 86
    \ Address offset: 0x358
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA87_DEF
    \
    \ @brief BSEC shadow register 87
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA88_DEF
    \
    \ @brief BSEC shadow register 88
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA89_DEF
    \
    \ @brief BSEC shadow register 89
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA90_DEF
    \
    \ @brief BSEC shadow register 90
    \ Address offset: 0x368
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA91_DEF
    \
    \ @brief BSEC shadow register 91
    \ Address offset: 0x36C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA92_DEF
    \
    \ @brief BSEC shadow register 92
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA93_DEF
    \
    \ @brief BSEC shadow register 93
    \ Address offset: 0x374
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA94_DEF
    \
    \ @brief BSEC shadow register 94
    \ Address offset: 0x378
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA95_DEF
    \
    \ @brief BSEC shadow register 95
    \ Address offset: 0x37C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] shadow register read from OTP or written by software (OTP emulation mode) The update of shadow registers is controlled by other registers and by OTP security mode.
  [then]


  [ifdef] BSEC_BSEC_HWCFGR_DEF
    \
    \ @brief BSEC hardware configuration register
    \ Address offset: 0xFF0
    \ Reset value: 0x00000014
    \
    $00 constant BSEC_SIZE                      \ [0x00 : 4] OTP block size Others: reserved
    $04 constant BSEC_ECC_USE                   \ [0x04 : 4] protection / redundancy scheme used Others: reserved
  [then]


  [ifdef] BSEC_BSEC_VERR_DEF
    \
    \ @brief BSEC version register
    \ Address offset: 0xFF4
    \ Reset value: 0x00000020
    \
    $00 constant BSEC_MINREV                    \ [0x00 : 4] minor revision information
    $04 constant BSEC_MAJREV                    \ [0x04 : 4] major revision information
  [then]


  [ifdef] BSEC_BSEC_IPIDR_DEF
    \
    \ @brief BSEC identification register
    \ Address offset: 0xFF8
    \ Reset value: 0x00100032
    \
    $00 constant BSEC_ID                        \ [0x00 : 32] BSEC identification
  [then]


  [ifdef] BSEC_BSEC_SIDR_DEF
    \
    \ @brief BSEC size identification register
    \ Address offset: 0xFFC
    \ Reset value: 0xA3C5DD04
    \
    $00 constant BSEC_SID                       \ [0x00 : 32] BSEC size identification
  [then]

  \
  \ @brief BSEC
  \
  $00 constant BSEC_BSEC_OTP_CONFIG     \ BSEC OTP configuration register
  $04 constant BSEC_BSEC_OTP_CONTROL    \ BSEC OTP control register
  $08 constant BSEC_BSEC_OTP_WRDATA     \ BSEC OTP write data register
  $0C constant BSEC_BSEC_OTP_STATUS     \ BSEC OTP status register
  $10 constant BSEC_BSEC_OTP_LOCK       \ BSEC OTP lock configuration register
  $14 constant BSEC_BSEC_DENABLE        \ BSEC debug configuration register
  $1C constant BSEC_BSEC_OTP_DISTURBED0 \ BSEC OTP disturbed status register 0
  $20 constant BSEC_BSEC_OTP_DISTURBED1 \ BSEC OTP disturbed status register 1
  $24 constant BSEC_BSEC_OTP_DISTURBED2 \ BSEC OTP disturbed status register 2
  $34 constant BSEC_BSEC_OTP_ERROR0     \ BSEC OTP error status register 0
  $38 constant BSEC_BSEC_OTP_ERROR1     \ BSEC OTP error status register 1
  $3C constant BSEC_BSEC_OTP_ERROR2     \ BSEC OTP error status register 2
  $4C constant BSEC_BSEC_OTP_WRLOCK0    \ BSEC OTP lock status register 0
  $50 constant BSEC_BSEC_OTP_WRLOCK1    \ BSEC OTP lock status register 1
  $54 constant BSEC_BSEC_OTP_WRLOCK2    \ BSEC OTP lock status register 2
  $64 constant BSEC_BSEC_OTP_SPLOCK0    \ BSEC OTP sticky programming lock register 0
  $68 constant BSEC_BSEC_OTP_SPLOCK1    \ BSEC OTP sticky programming lock register 1
  $6C constant BSEC_BSEC_OTP_SPLOCK2    \ BSEC OTP sticky programming lock register 2
  $7C constant BSEC_BSEC_OTP_SWLOCK0    \ BSEC OTP shadow write sticky lock register 0
  $80 constant BSEC_BSEC_OTP_SWLOCK1    \ BSEC OTP shadow write sticky lock register 1
  $84 constant BSEC_BSEC_OTP_SWLOCK2    \ BSEC OTP shadow write sticky lock register 2
  $94 constant BSEC_BSEC_OTP_SRLOCK0    \ BSEC OTP shadow read sticky lock register 0
  $98 constant BSEC_BSEC_OTP_SRLOCK1    \ BSEC OTP shadow read sticky lock register 1
  $9C constant BSEC_BSEC_OTP_SRLOCK2    \ BSEC OTP shadow read sticky lock register 2
  $AC constant BSEC_BSEC_JTAGIN         \ BSEC JTAG input register
  $B0 constant BSEC_BSEC_JTAGOUT        \ BSEC JTAG output register
  $B4 constant BSEC_BSEC_SCRATCH        \ BSEC scratch register
  $200 constant BSEC_BSEC_OTP_DATA0     \ BSEC shadow register 0
  $204 constant BSEC_BSEC_OTP_DATA1     \ BSEC shadow register 1
  $208 constant BSEC_BSEC_OTP_DATA2     \ BSEC shadow register 2
  $20C constant BSEC_BSEC_OTP_DATA3     \ BSEC shadow register 3
  $210 constant BSEC_BSEC_OTP_DATA4     \ BSEC shadow register 4
  $214 constant BSEC_BSEC_OTP_DATA5     \ BSEC shadow register 5
  $218 constant BSEC_BSEC_OTP_DATA6     \ BSEC shadow register 6
  $21C constant BSEC_BSEC_OTP_DATA7     \ BSEC shadow register 7
  $220 constant BSEC_BSEC_OTP_DATA8     \ BSEC shadow register 8
  $224 constant BSEC_BSEC_OTP_DATA9     \ BSEC shadow register 9
  $228 constant BSEC_BSEC_OTP_DATA10    \ BSEC shadow register 10
  $22C constant BSEC_BSEC_OTP_DATA11    \ BSEC shadow register 11
  $230 constant BSEC_BSEC_OTP_DATA12    \ BSEC shadow register 12
  $234 constant BSEC_BSEC_OTP_DATA13    \ BSEC shadow register 13
  $238 constant BSEC_BSEC_OTP_DATA14    \ BSEC shadow register 14
  $23C constant BSEC_BSEC_OTP_DATA15    \ BSEC shadow register 15
  $240 constant BSEC_BSEC_OTP_DATA16    \ BSEC shadow register 16
  $244 constant BSEC_BSEC_OTP_DATA17    \ BSEC shadow register 17
  $248 constant BSEC_BSEC_OTP_DATA18    \ BSEC shadow register 18
  $24C constant BSEC_BSEC_OTP_DATA19    \ BSEC shadow register 19
  $250 constant BSEC_BSEC_OTP_DATA20    \ BSEC shadow register 20
  $254 constant BSEC_BSEC_OTP_DATA21    \ BSEC shadow register 21
  $258 constant BSEC_BSEC_OTP_DATA22    \ BSEC shadow register 22
  $25C constant BSEC_BSEC_OTP_DATA23    \ BSEC shadow register 23
  $260 constant BSEC_BSEC_OTP_DATA24    \ BSEC shadow register 24
  $264 constant BSEC_BSEC_OTP_DATA25    \ BSEC shadow register 25
  $268 constant BSEC_BSEC_OTP_DATA26    \ BSEC shadow register 26
  $26C constant BSEC_BSEC_OTP_DATA27    \ BSEC shadow register 27
  $270 constant BSEC_BSEC_OTP_DATA28    \ BSEC shadow register 28
  $274 constant BSEC_BSEC_OTP_DATA29    \ BSEC shadow register 29
  $278 constant BSEC_BSEC_OTP_DATA30    \ BSEC shadow register 30
  $27C constant BSEC_BSEC_OTP_DATA31    \ BSEC shadow register 31
  $280 constant BSEC_BSEC_OTP_DATA32    \ BSEC shadow register 32
  $284 constant BSEC_BSEC_OTP_DATA33    \ BSEC shadow register 33
  $288 constant BSEC_BSEC_OTP_DATA34    \ BSEC shadow register 34
  $28C constant BSEC_BSEC_OTP_DATA35    \ BSEC shadow register 35
  $290 constant BSEC_BSEC_OTP_DATA36    \ BSEC shadow register 36
  $294 constant BSEC_BSEC_OTP_DATA37    \ BSEC shadow register 37
  $298 constant BSEC_BSEC_OTP_DATA38    \ BSEC shadow register 38
  $29C constant BSEC_BSEC_OTP_DATA39    \ BSEC shadow register 39
  $2A0 constant BSEC_BSEC_OTP_DATA40    \ BSEC shadow register 40
  $2A4 constant BSEC_BSEC_OTP_DATA41    \ BSEC shadow register 41
  $2A8 constant BSEC_BSEC_OTP_DATA42    \ BSEC shadow register 42
  $2AC constant BSEC_BSEC_OTP_DATA43    \ BSEC shadow register 43
  $2B0 constant BSEC_BSEC_OTP_DATA44    \ BSEC shadow register 44
  $2B4 constant BSEC_BSEC_OTP_DATA45    \ BSEC shadow register 45
  $2B8 constant BSEC_BSEC_OTP_DATA46    \ BSEC shadow register 46
  $2BC constant BSEC_BSEC_OTP_DATA47    \ BSEC shadow register 47
  $2C0 constant BSEC_BSEC_OTP_DATA48    \ BSEC shadow register 48
  $2C4 constant BSEC_BSEC_OTP_DATA49    \ BSEC shadow register 49
  $2C8 constant BSEC_BSEC_OTP_DATA50    \ BSEC shadow register 50
  $2CC constant BSEC_BSEC_OTP_DATA51    \ BSEC shadow register 51
  $2D0 constant BSEC_BSEC_OTP_DATA52    \ BSEC shadow register 52
  $2D4 constant BSEC_BSEC_OTP_DATA53    \ BSEC shadow register 53
  $2D8 constant BSEC_BSEC_OTP_DATA54    \ BSEC shadow register 54
  $2DC constant BSEC_BSEC_OTP_DATA55    \ BSEC shadow register 55
  $2E0 constant BSEC_BSEC_OTP_DATA56    \ BSEC shadow register 56
  $2E4 constant BSEC_BSEC_OTP_DATA57    \ BSEC shadow register 57
  $2E8 constant BSEC_BSEC_OTP_DATA58    \ BSEC shadow register 58
  $2EC constant BSEC_BSEC_OTP_DATA59    \ BSEC shadow register 59
  $2F0 constant BSEC_BSEC_OTP_DATA60    \ BSEC shadow register 60
  $2F4 constant BSEC_BSEC_OTP_DATA61    \ BSEC shadow register 61
  $2F8 constant BSEC_BSEC_OTP_DATA62    \ BSEC shadow register 62
  $2FC constant BSEC_BSEC_OTP_DATA63    \ BSEC shadow register 63
  $300 constant BSEC_BSEC_OTP_DATA64    \ BSEC shadow register 64
  $304 constant BSEC_BSEC_OTP_DATA65    \ BSEC shadow register 65
  $308 constant BSEC_BSEC_OTP_DATA66    \ BSEC shadow register 66
  $30C constant BSEC_BSEC_OTP_DATA67    \ BSEC shadow register 67
  $310 constant BSEC_BSEC_OTP_DATA68    \ BSEC shadow register 68
  $314 constant BSEC_BSEC_OTP_DATA69    \ BSEC shadow register 69
  $318 constant BSEC_BSEC_OTP_DATA70    \ BSEC shadow register 70
  $31C constant BSEC_BSEC_OTP_DATA71    \ BSEC shadow register 71
  $320 constant BSEC_BSEC_OTP_DATA72    \ BSEC shadow register 72
  $324 constant BSEC_BSEC_OTP_DATA73    \ BSEC shadow register 73
  $328 constant BSEC_BSEC_OTP_DATA74    \ BSEC shadow register 74
  $32C constant BSEC_BSEC_OTP_DATA75    \ BSEC shadow register 75
  $330 constant BSEC_BSEC_OTP_DATA76    \ BSEC shadow register 76
  $334 constant BSEC_BSEC_OTP_DATA77    \ BSEC shadow register 77
  $338 constant BSEC_BSEC_OTP_DATA78    \ BSEC shadow register 78
  $33C constant BSEC_BSEC_OTP_DATA79    \ BSEC shadow register 79
  $340 constant BSEC_BSEC_OTP_DATA80    \ BSEC shadow register 80
  $344 constant BSEC_BSEC_OTP_DATA81    \ BSEC shadow register 81
  $348 constant BSEC_BSEC_OTP_DATA82    \ BSEC shadow register 82
  $34C constant BSEC_BSEC_OTP_DATA83    \ BSEC shadow register 83
  $350 constant BSEC_BSEC_OTP_DATA84    \ BSEC shadow register 84
  $354 constant BSEC_BSEC_OTP_DATA85    \ BSEC shadow register 85
  $358 constant BSEC_BSEC_OTP_DATA86    \ BSEC shadow register 86
  $35C constant BSEC_BSEC_OTP_DATA87    \ BSEC shadow register 87
  $360 constant BSEC_BSEC_OTP_DATA88    \ BSEC shadow register 88
  $364 constant BSEC_BSEC_OTP_DATA89    \ BSEC shadow register 89
  $368 constant BSEC_BSEC_OTP_DATA90    \ BSEC shadow register 90
  $36C constant BSEC_BSEC_OTP_DATA91    \ BSEC shadow register 91
  $370 constant BSEC_BSEC_OTP_DATA92    \ BSEC shadow register 92
  $374 constant BSEC_BSEC_OTP_DATA93    \ BSEC shadow register 93
  $378 constant BSEC_BSEC_OTP_DATA94    \ BSEC shadow register 94
  $37C constant BSEC_BSEC_OTP_DATA95    \ BSEC shadow register 95
  $FF0 constant BSEC_BSEC_HWCFGR        \ BSEC hardware configuration register
  $FF4 constant BSEC_BSEC_VERR          \ BSEC version register
  $FF8 constant BSEC_BSEC_IPIDR         \ BSEC identification register
  $FFC constant BSEC_BSEC_SIDR          \ BSEC size identification register

: BSEC_DEF ; [then]
