\
\ @file pwr.fs
\ @brief PWR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_CR1_DEF
    \
    \ @brief PWR control register 1
    \ Address offset: 0x00
    \ Reset value: 0xF000C000
    \
    $00 constant PWR_LPDS                       \ [0x00] Low-power Deepsleep with SVOS3 (SVOS4 and SVOS5 always use low-power, regardless of the setting of this bit)
    $04 constant PWR_PVDE                       \ [0x04] Programmable voltage detector enable
    $05 constant PWR_PLS                        \ [0x05 : 3] Programmable voltage detector level selection These bits select the voltage threshold detected by the PVD. Note: Refer to Section Electrical characteristics of the product datasheet for more details.
    $08 constant PWR_DBP                        \ [0x08] Disable backup domain write protection In reset state, the RCC_BDCR register, the RTC registers (including the backup registers), BREN and MOEN bits in PWR_CR2 register, are protected against parasitic write access. This bit must be set to enable write access to these registers.
    $09 constant PWR_FLPS                       \ [0x09] Flash low-power mode in DStop mode This bit allows to obtain the best trade-off between low-power consumption and restart time when exiting from DStop mode. When it is set, the Flash memory enters low-power mode when D1 domain is in DStop mode.
    $0e constant PWR_SVOS                       \ [0x0e : 2] System Stop mode voltage scaling selection These bits control the VCORE voltage level in system Stop mode, to obtain the best trade-off between power consumption and performance.
    $10 constant PWR_AVDEN                      \ [0x10] Peripheral voltage monitor on VDDA enable
    $11 constant PWR_ALS                        \ [0x11 : 2] Analog voltage detector level selection These bits select the voltage threshold detected by the AVD.
  [then]


  [ifdef] PWR_PWR_CSR1_DEF
    \
    \ @brief PWR control status register 1
    \ Address offset: 0x04
    \ Reset value: 0x00004000
    \
    $04 constant PWR_PVDO                       \ [0x04] Programmable voltage detect output This bit is set and cleared by hardware. It is valid only if the PVD has been enabled by the PVDE bit. Note: since the PVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the PVDE bit is set.
    $0d constant PWR_ACTVOSRDY                  \ [0x0d] Voltage levels ready bit for currently used VOS and SDLEVEL This bit is set to 1 by hardware when the voltage regulator and the SD converter are both disabled and Bypass mode is selected in PWR control register 3 (PWR_CR3).
    $0e constant PWR_ACTVOS                     \ [0x0e : 2] VOS currently applied for VCORE voltage scaling selection. These bits reflect the last VOS value applied to the PMU.
    $10 constant PWR_AVDO                       \ [0x10] Analog voltage detector output on VDDA This bit is set and cleared by hardware. It is valid only if AVD on VDDA is enabled by the AVDEN bit. Note: Since the AVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the AVDEN bit is set.
  [then]


  [ifdef] PWR_PWR_CR2_DEF
    \
    \ @brief This register is not reset by wakeup from Standby mode, RESET signal and VDD POR. It is only reset by VSW POR and VSWRST reset. This register shall not be accessed when VSWRST bit in RCC_BDCR register resets the VSW domain.After reset, PWR_CR2 register is write-protected. Prior to modifying its content, the DBP bit in PWR_CR1 register must be set to disable the write protection.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BREN                       \ [0x00] Backup regulator enable When set, the Backup regulator (used to maintain the backup RAM content in Standby and VBAT modes) is enabled. If BREN is reset, the backup regulator is switched off. The backup RAM can still be used in Run and Stop modes. However, its content will be lost in Standby and VBAT modes. If BREN is set, the application must wait till the Backup Regulator Ready flag (BRRDY) is set to indicate that the data written into the SRAM will be maintained in Standby and VBAT modes.
    $04 constant PWR_MONEN                      \ [0x04] VBAT and temperature monitoring enable When set, the VBAT supply and temperature monitoring is enabled.
    $10 constant PWR_BRRDY                      \ [0x10] Backup regulator ready This bit is set by hardware to indicate that the Backup regulator is ready.
    $14 constant PWR_VBATL                      \ [0x14] VBAT level monitoring versus low threshold
    $15 constant PWR_VBATH                      \ [0x15] VBAT level monitoring versus high threshold
    $16 constant PWR_TEMPL                      \ [0x16] Temperature level monitoring versus low threshold
    $17 constant PWR_TEMPH                      \ [0x17] Temperature level monitoring versus high threshold
  [then]


  [ifdef] PWR_PWR_CR3_DEF
    \
    \ @brief Reset only by POR only, not reset by wakeup from Standby mode and RESET pad. The lower byte of this register is written once after POR and shall be written before changing VOS level or ck_sys clock frequency. No limitation applies to the upper bytes.Programming data corresponding to an invalid combination of SDLEVEL, SDEXTHP, SDEN, LDOEN and BYPASS bits (see Table9) will be ignored: data will not be written, the written-once mechanism will lock the register and any further write access will be ignored. The default supply configuration will be kept and the ACTVOSRDY bit in PWR control status register 1 (PWR_CSR1) will go on indicating invalid voltage levels. The system shall be power cycled before writing a new value.
    \ Address offset: 0x0C
    \ Reset value: 0x00000006
    \
    $00 constant PWR_BYPASS                     \ [0x00] Power management unit bypass
    $01 constant PWR_LDOEN                      \ [0x01] Low drop-out regulator enable
    $02 constant PWR_SDEN                       \ [0x02] SD converter Enable
    $08 constant PWR_VBE                        \ [0x08] VBAT charging enable
    $09 constant PWR_VBRS                       \ [0x09] VBAT charging resistor selection
    $18 constant PWR_USB33DEN                   \ [0x18] VDD33USB voltage level detector enable.
    $19 constant PWR_USBREGEN                   \ [0x19] USB regulator enable.
    $1a constant PWR_USB33RDY                   \ [0x1a] USB supply ready.
  [then]


  [ifdef] PWR_PWR_CPUCR_DEF
    \
    \ @brief This register allows controlling CPU1 power.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PDDS_D1                    \ [0x00] D1 domain Power Down Deepsleep selection. This bit allows CPU1 to define the Deepsleep mode for D1 domain.
    $01 constant PWR_PDDS_D2                    \ [0x01] D2 domain Power Down Deepsleep. This bit allows CPU1 to define the Deepsleep mode for D2 domain.
    $02 constant PWR_PDDS_D3                    \ [0x02] System D3 domain Power Down Deepsleep. This bit allows CPU1 to define the Deepsleep mode for System D3 domain.
    $05 constant PWR_STOPF                      \ [0x05] STOP flag This bit is set by hardware and cleared only by any reset or by setting the CPU1 CSSF bit.
    $06 constant PWR_SBF                        \ [0x06] System Standby flag This bit is set by hardware and cleared only by a POR (Power-on Reset) or by setting the CPU1 CSSF bit
    $07 constant PWR_SBF_D1                     \ [0x07] D1 domain DStandby flag This bit is set by hardware and cleared by any system reset or by setting the CPU1 CSSF bit. Once set, this bit can be cleared only when the D1 domain is no longer in DStandby mode.
    $08 constant PWR_SBF_D2                     \ [0x08] D2 domain DStandby flag This bit is set by hardware and cleared by any system reset or by setting the CPU1 CSSF bit. Once set, this bit can be cleared only when the D2 domain is no longer in DStandby mode.
    $09 constant PWR_CSSF                       \ [0x09] Clear D1 domain CPU1 Standby, Stop and HOLD flags (always read as 0) This bit is cleared to 0 by hardware.
    $0b constant PWR_RUN_D3                     \ [0x0b] Keep system D3 domain in Run mode regardless of the CPU sub-systems modes
  [then]


  [ifdef] PWR_PWR_D3CR_DEF
    \
    \ @brief This register allows controlling D3 domain power.Following reset VOSRDY will be read 1 by software
    \ Address offset: 0x18
    \ Reset value: 0x00004000
    \
    $0d constant PWR_VOSRDY                     \ [0x0d] VOS Ready bit for VCORE voltage scaling output selection. This bit is set to 1 by hardware when Bypass mode is selected in PWR control register 3 (PWR_CR3).
    $0e constant PWR_VOS                        \ [0x0e : 2] Voltage scaling selection according to performance These bits control the VCORE voltage level and allow to obtains the best trade-off between power consumption and performance: When increasing the performance, the voltage scaling shall be changed before increasing the system frequency. When decreasing performance, the system frequency shall first be decreased before changing the voltage scaling.
  [then]


  [ifdef] PWR_PWR_WKUPCR_DEF
    \
    \ @brief reset only by system reset, not reset by wakeup from Standby mode5 wait states are required when writing this register (when clearing a WKUPF bit in PWR_WKUPFR, the AHB write access will complete after the WKUPF has been cleared).
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPC                      \ [0x00 : 6] Clear Wakeup pin flag for WKUP. These bits are always read as 0.
  [then]


  [ifdef] PWR_PWR_WKUPFR_DEF
    \
    \ @brief reset only by system reset, not reset by wakeup from Standby mode
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPF1                     \ [0x00] Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
    $01 constant PWR_WKUPF2                     \ [0x01] Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
    $02 constant PWR_WKUPF3                     \ [0x02] Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
    $03 constant PWR_WKUPF4                     \ [0x03] Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
    $04 constant PWR_WKUPF5                     \ [0x04] Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
    $05 constant PWR_WKUPF6                     \ [0x05] Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
  [then]


  [ifdef] PWR_PWR_WKUPEPR_DEF
    \
    \ @brief Reset only by system reset, not reset by wakeup from Standby mode
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPEN1                    \ [0x00] Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
    $01 constant PWR_WKUPEN2                    \ [0x01] Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
    $02 constant PWR_WKUPEN3                    \ [0x02] Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
    $03 constant PWR_WKUPEN4                    \ [0x03] Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
    $04 constant PWR_WKUPEN5                    \ [0x04] Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
    $05 constant PWR_WKUPEN6                    \ [0x05] Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
    $08 constant PWR_WKUPP1                     \ [0x08] Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
    $09 constant PWR_WKUPP2                     \ [0x09] Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
    $0a constant PWR_WKUPP3                     \ [0x0a] Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
    $0b constant PWR_WKUPP4                     \ [0x0b] Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
    $0c constant PWR_WKUPP5                     \ [0x0c] Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
    $0d constant PWR_WKUPP6                     \ [0x0d] Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
    $10 constant PWR_WKUPPUPD1                  \ [0x10 : 2] Wakeup pin pull configuration
    $12 constant PWR_WKUPPUPD2                  \ [0x12 : 2] Wakeup pin pull configuration
    $14 constant PWR_WKUPPUPD3                  \ [0x14 : 2] Wakeup pin pull configuration
    $16 constant PWR_WKUPPUPD4                  \ [0x16 : 2] Wakeup pin pull configuration
    $18 constant PWR_WKUPPUPD5                  \ [0x18 : 2] Wakeup pin pull configuration
    $1a constant PWR_WKUPPUPD6                  \ [0x1a : 2] Wakeup pin pull configuration for WKUP(truncate(n/2)-7) These bits define the I/O pad pull configuration used when WKUPEN(truncate(n/2)-7) = 1. The associated GPIO port pull configuration shall be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.
  [then]

  \
  \ @brief PWR
  \
  $00 constant PWR_PWR_CR1              \ PWR control register 1
  $04 constant PWR_PWR_CSR1             \ PWR control status register 1
  $08 constant PWR_PWR_CR2              \ This register is not reset by wakeup from Standby mode, RESET signal and VDD POR. It is only reset by VSW POR and VSWRST reset. This register shall not be accessed when VSWRST bit in RCC_BDCR register resets the VSW domain.After reset, PWR_CR2 register is write-protected. Prior to modifying its content, the DBP bit in PWR_CR1 register must be set to disable the write protection.
  $0C constant PWR_PWR_CR3              \ Reset only by POR only, not reset by wakeup from Standby mode and RESET pad. The lower byte of this register is written once after POR and shall be written before changing VOS level or ck_sys clock frequency. No limitation applies to the upper bytes.Programming data corresponding to an invalid combination of SDLEVEL, SDEXTHP, SDEN, LDOEN and BYPASS bits (see Table9) will be ignored: data will not be written, the written-once mechanism will lock the register and any further write access will be ignored. The default supply configuration will be kept and the ACTVOSRDY bit in PWR control status register 1 (PWR_CSR1) will go on indicating invalid voltage levels. The system shall be power cycled before writing a new value.
  $10 constant PWR_PWR_CPUCR            \ This register allows controlling CPU1 power.
  $18 constant PWR_PWR_D3CR             \ This register allows controlling D3 domain power.Following reset VOSRDY will be read 1 by software
  $20 constant PWR_PWR_WKUPCR           \ reset only by system reset, not reset by wakeup from Standby mode5 wait states are required when writing this register (when clearing a WKUPF bit in PWR_WKUPFR, the AHB write access will complete after the WKUPF has been cleared).
  $24 constant PWR_PWR_WKUPFR           \ reset only by system reset, not reset by wakeup from Standby mode
  $28 constant PWR_PWR_WKUPEPR          \ Reset only by system reset, not reset by wakeup from Standby mode

: PWR_DEF ; [then]
