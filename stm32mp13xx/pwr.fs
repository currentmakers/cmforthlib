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
    \ Reset value: 0x00000200
    \
    $00 constant PWR_LPDS                       \ [0x00] Low Power Deepsleep Stop mode selection.
    $01 constant PWR_LPCFG                      \ [0x01] PWR_ON pin configuration.
    $02 constant PWR_LVDS                       \ [0x02] Low Voltage Deepsleep LPLV-Stop mode selection. This bit has only effect when the low power stop mode is selected in LPDS and changes the VDDCORE and VDDCPU domains supply reset level.
    $03 constant PWR_STOP2                      \ [0x03] System LPLV-Stop2 mode selection
    $04 constant PWR_PVDEN                      \ [0x04] Programmable Voltage detector enable. This bit is read only when the SYSCFG register bit PVDL is set (when PVDL is set, there is no bus errors generated when writing this register).
    $05 constant PWR_PLS                        \ [0x05 : 3] Programmable Voltage Detector level selection. These bits are read only when the SYSCFG register bit PVDL is set (when PVDL is set, there is no bus errors generated when writing this register). These bits select the voltage threshold detected by the PVD.
    $08 constant PWR_DBP                        \ [0x08] Disable backup domain write protection. In reset state, the RCC_BDCR, PWR_CR2, RTC, and backup registers are protected against parasitic write access. This bit must be set to enable write access to these.
    $09 constant PWR_MPU_RAM_LOWSPEED           \ [0x09] Low speed selection for MPU memories This bit must be reset by software when MPU needs to operate in Overdrive (High speed) mode It must be set after decreasing the MPU frequency to operate in standard frequency range.
    $10 constant PWR_AVDEN                      \ [0x10] Peripheral Voltage Monitor on VDDA enable.
    $11 constant PWR_ALS                        \ [0x11 : 2] Analog Voltage Detector level selection. These bits select the voltage threshold detected by the AVD.
  [then]


  [ifdef] PWR_PWR_CSR1_DEF
    \
    \ @brief PWR control status register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant PWR_PVDO                       \ [0x04] Programmable Voltage Detect Output This bit is set and cleared by hardware. It is valid only if PVD is enabled by the PVDEN bit. Note: The PVD is disabled in Standby mode and after a system reset. For this reason, this bit is equal to 0 after Standby and system reset.
    $10 constant PWR_AVDO                       \ [0x10] Analog Voltage detector Output on VDDA. This bit is set and cleared by hardware. It is valid only if AVD on VDDA is enabled by the AVDEN bit. Note: The AVD is disabled in Standby mode and after system reset. For this reason, this bit is equal to 0 after Standby and reset.
  [then]


  [ifdef] PWR_PWR_CR2_DEF
    \
    \ @brief PWR control register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BREN                       \ [0x00] Backup regulator enable When set, the backup regulator (used to maintain backup RAM content in Standby and VBAT modes) is enabled. If BREN is reset, the backup regulator is switched off. The backup RAM can still be used in Run mode and Stop mode but its content is lost in the Standby and VBAT modes. Once set, the application must wait that the Backup Regulator Ready flag (BRRDY) is set to indicate that the data written into the SRAM is maintained in the Standby and VBAT modes.
    $04 constant PWR_MONEN                      \ [0x04] VBAT and temperature monitoring enable When set, the VBAT supply and temperature monitoring is enabled.
    $10 constant PWR_BRRDY                      \ [0x10] Backup Regulator ready Set by hardware to indicate that the Backup Regulator is ready. Entering Standby or VBAT mode before the Backup Regulator is ready may cause loss of Backup RAM content.
    $14 constant PWR_VBATL                      \ [0x14] Monitored VBAT level above low threshold
    $15 constant PWR_VBATH                      \ [0x15] Monitored VBAT level above high threshold
    $16 constant PWR_TEMPL                      \ [0x16] Monitored temperature level above low threshold
    $17 constant PWR_TEMPH                      \ [0x17] Monitored temperature level above high threshold
  [then]


  [ifdef] PWR_PWR_CR3_DEF
    \
    \ @brief PWR control register 3
    \ Address offset: 0x0C
    \ Reset value: 0x5000A000
    \
    $08 constant PWR_VBE                        \ [0x08] VBAT charging enable
    $09 constant PWR_VBRS                       \ [0x09] VBAT charging resistor selection
    $0a constant PWR_DDRSREN                    \ [0x0a] DDR self-refresh in standby mode enable When set, the DDR PHY puts its pads in retention when entering Standby mode.
    $0b constant PWR_DDRSRDIS                   \ [0x0b] DDR self-refresh retention after standby disable When written 'b1, the DDR PHY pads retention, enabled due to DDRSREN, is disabled.
    $0c constant PWR_DDRRETEN                   \ [0x0c] DDR retention enable Set by Hardware on NRST pad reset, when the reset delay control is enabled in the RCC_MP_APRSTCR.RDCTLEN register bit, or when written 'b1 by software, the DDR PHY puts its pads in retention. To disable retention software must write this bit to 'b0.
    $0d constant PWR_VDDSD1DEN                  \ [0x0d] VDDSD1 voltage level detector enable The voltage level detector is active by default. It enables the I/Os in the VDDSD1 domain if and when the VDDSD1 supply voltage is higher than VDDSDx_TH. Once the supply is stable above this threshold (VDDSD1RDYÂ =Â 1), the level detectors can be switched off to save power, without disabling the I/Os, by setting VDDSD1VALIDÂ =Â 1 followed by VDDSD1ENÂ =Â 0 (refer to datasheet for VDDSDx_TH value).
    $0e constant PWR_VDDSD1RDY                  \ [0x0e] VDDSD1 supply ready When the level detector is active (VDDSD1DEN = 1), this bit indicates if a voltage higher than VDDSDx_TH is present on the VDDSD1 supply (refer to datasheet for VDDSDx_TH value).
    $0f constant PWR_VDDSD2DEN                  \ [0x0f] VDDSD2 voltage level detector enable The voltage level detector is active by default. It enables the I/Os in the VDDSD2 domain if and when the VDDSD2 supply voltage is higher than VDDSDx_TH. Once the supply is stable above this threshold (VDDSD2RDYÂ =Â 1), the level detectors can be switched off to save power, without disabling the I/Os, by setting VDDSD2VALIDÂ =Â 1 followed by VDDSD2ENÂ =Â 0 (refer to datasheet for VDDSDx_TH value).
    $10 constant PWR_VDDSD2RDY                  \ [0x10] VDDSD2 supply ready When the level detector is active (VDDSD2DEN = 1), this bit indicates if a voltage higher than VDDSDx_TH is present on the VDDSD2 supply (refer to datasheet for VDDSDx_TH value).
    $11 constant PWR_POPL                       \ [0x11 : 5] PWR_ON, PWR_CPU_ON Standby pulse low configuration These bits are set and cleared by software. They define the minimum guaranteed duration of the PWR_ON and PWR_CPU_ON low pulse in Standby mode (there is no impact on the LP-Stop and LPLV-Stop modes). The LSI oscillator is automatically enabled when needed by the POPL pulse low configuration. ...
    $16 constant PWR_VDDSD1VALID                \ [0x16] Override VDDSD1 voltage detector This bit enables the I/Os in the VDDSD1 domain whatever the state of VDDSD1RDY. This bit can be set by software once VDDSD1 is higher than VDDSDx_TH and stable (bit VDDSD1RDYÂ =Â 1). Subsequently VDDSD1EN can be reset to 0 to disable the voltage detector and save power (refer to datasheet for VDDSDx_TH value).
    $17 constant PWR_VDDSD2VALID                \ [0x17] Override VDDSD2 voltage detector This bit enables the I/Os in the VDDSD2 domain whatever the state of VDDSD2RDY. This bit can be set by software once VDDSD2 is higher than VDDSDx_TH and stable (bit VDDSD2RDYÂ =Â 1). Subsequently VDDSD2EN can be reset to 0 to disable the voltage detector and save power (refer to datasheet for VDDSDx_TH value).
    $18 constant PWR_USB33DEN                   \ [0x18] USB 3.3V voltage level detector enable
    $1a constant PWR_USB33RDY                   \ [0x1a] USB 3.3V supply ready
    $1c constant PWR_REG18EN                    \ [0x1c] 1V8 regulator enable
    $1d constant PWR_REG18RDY                   \ [0x1d] 1V8 regulator supply ready
    $1e constant PWR_REG11EN                    \ [0x1e] 1V1 regulator enable
    $1f constant PWR_REG11RDY                   \ [0x1f] 1V1 regulator supply ready
  [then]


  [ifdef] PWR_PWR_MPUCR_DEF
    \
    \ @brief PWR MPU control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PDDS                       \ [0x00] System Power Down Deepsleep selection This bit is reset only by a VDD POR reset (not reset when exit from Standby mode). Allows to define the Deepsleep mode for the system.
    $05 constant PWR_STOPF                      \ [0x05] Stop flag This bit is set by hardware and cleared only by any system reset or by setting the MPU CSSF bit. This bit is cleared by the MPU Boot ROM. For more information refer to Boot ROM application note.
    $06 constant PWR_SBF                        \ [0x06] System Standby flag This bit is set by hardware and cleared only by a VDD POR reset or by setting the MPU CSSF bit (not reset when exit from Standby mode). This bit is cleared by the MPU Boot ROM. For more information refer to Boot ROM application note.
    $07 constant PWR_SBFMPU                     \ [0x07] MPU Standby flag This bit is set by hardware and cleared only by a VDD POR reset or by setting the MPU CSSF bit (not reset when exit from Standby mode). This bit is cleared by the MPU Boot ROM. For more information refer to Boot ROM application note.
    $09 constant PWR_CSSF                       \ [0x09] Clear MPU Standby, Stop flags.(Always read as 0) This bit is reset on any system reset.
    $0f constant PWR_STANDBYWFIL2               \ [0x0f] MPU system idle indication This bit is set and reset by hardware based on the MPU operation mode.
  [then]


  [ifdef] PWR_PWR_WKUPCR_DEF
    \
    \ @brief PWR wakeup control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPC1                     \ [0x00] Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
    $01 constant PWR_WKUPC2                     \ [0x01] Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
    $02 constant PWR_WKUPC3                     \ [0x02] Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
    $03 constant PWR_WKUPC4                     \ [0x03] Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
    $04 constant PWR_WKUPC5                     \ [0x04] Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
    $05 constant PWR_WKUPC6                     \ [0x05] Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
    $08 constant PWR_WKUPP1                     \ [0x08] Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
    $09 constant PWR_WKUPP2                     \ [0x09] Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
    $0a constant PWR_WKUPP3                     \ [0x0a] Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
    $0b constant PWR_WKUPP4                     \ [0x0b] Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
    $0c constant PWR_WKUPP5                     \ [0x0c] Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
    $0d constant PWR_WKUPP6                     \ [0x0d] Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
    $10 constant PWR_WKUPPUPD1                  \ [0x10 : 2] Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
    $12 constant PWR_WKUPPUPD2                  \ [0x12 : 2] Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
    $14 constant PWR_WKUPPUPD3                  \ [0x14 : 2] Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
    $16 constant PWR_WKUPPUPD4                  \ [0x16 : 2] Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
    $18 constant PWR_WKUPPUPD5                  \ [0x18 : 2] Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
    $1a constant PWR_WKUPPUPD6                  \ [0x1a : 2] Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
  [then]


  [ifdef] PWR_PWR_WKUPFR_DEF
    \
    \ @brief PWR wakeup flag register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPF1                     \ [0x00] Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
    $01 constant PWR_WKUPF2                     \ [0x01] Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
    $02 constant PWR_WKUPF3                     \ [0x02] Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
    $03 constant PWR_WKUPF4                     \ [0x03] Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
    $04 constant PWR_WKUPF5                     \ [0x04] Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
    $05 constant PWR_WKUPF6                     \ [0x05] Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
  [then]


  [ifdef] PWR_PWR_MPUWKUPENR_DEF
    \
    \ @brief PWR MPU wakeup enable register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPEN1                    \ [0x00] Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
    $01 constant PWR_WKUPEN2                    \ [0x01] Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
    $02 constant PWR_WKUPEN3                    \ [0x02] Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
    $03 constant PWR_WKUPEN4                    \ [0x03] Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
    $04 constant PWR_WKUPEN5                    \ [0x04] Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
    $05 constant PWR_WKUPEN6                    \ [0x05] Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
  [then]


  [ifdef] PWR_PWR_VER_DEF
    \
    \ @brief PWR IP version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000020
    \
    $00 constant PWR_MINREV                     \ [0x00 : 4] Minor revision number
    $04 constant PWR_MAJREV                     \ [0x04 : 4] Major revision number
  [then]


  [ifdef] PWR_PWR_ID_DEF
    \
    \ @brief PWR IP identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00010001
    \
    $00 constant PWR_IPID                       \ [0x00 : 32] IP identification
  [then]


  [ifdef] PWR_PWR_SID_DEF
    \
    \ @brief PWR size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant PWR_SID                        \ [0x00 : 32] Size identification
  [then]

  \
  \ @brief PWR
  \
  $00 constant PWR_PWR_CR1              \ PWR control register 1
  $04 constant PWR_PWR_CSR1             \ PWR control status register 1
  $08 constant PWR_PWR_CR2              \ PWR control register 2
  $0C constant PWR_PWR_CR3              \ PWR control register 3
  $10 constant PWR_PWR_MPUCR            \ PWR MPU control register
  $20 constant PWR_PWR_WKUPCR           \ PWR wakeup control register
  $24 constant PWR_PWR_WKUPFR           \ PWR wakeup flag register
  $28 constant PWR_PWR_MPUWKUPENR       \ PWR MPU wakeup enable register
  $3F4 constant PWR_PWR_VER             \ PWR IP version register
  $3F8 constant PWR_PWR_ID              \ PWR IP identification register
  $3FC constant PWR_PWR_SID             \ PWR size ID register

: PWR_DEF ; [then]
