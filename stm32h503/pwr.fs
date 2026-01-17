\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_PMCR_DEF
    \
    \ @brief PWR power mode control register
    \ Address offset: 0x00
    \ Reset value: 0x0000000C
    \
    $00 constant PWR_LPMS                       \ [0x00] low-power mode selection This bit defines the Deepsleep mode.
    $02 constant PWR_SVOS                       \ [0x02 : 2] system Stop mode voltage scaling selection These bits control the V CORE voltage level in system Stop mode, to obtain the best trade-off between power consumption and performance.
    $07 constant PWR_CSSF                       \ [0x07] clear Standby and Stop flags (always read as 0) This bit is cleared to 0 by hardware.
    $09 constant PWR_FLPS                       \ [0x09] Flash memory low-power mode in Stop mode This bit is used to obtain the best trade-off between low-power consumption and restart time when exiting from Stop mode. When it is set, the Flash memory enters low-power mode when the CPU domain is in Stop mode. Note: When system enters stop mode with SVOS5 enabled, Flash memory is automatically forced in low-power mode.
    $0c constant PWR_BOOSTE                     \ [0x0c] analog switch V BOOST control This bit enables the booster to guarantee the analog switch AC performance when the V DD supply voltage is below 2.7 V (reduction of the total harmonic distortion to have the same switch performance over the full supply voltage range) The V DD supply voltage can be monitored through the PVD and the PLS bits.
    $0d constant PWR_AVD_READY                  \ [0x0d] analog voltage ready This bit is only used when the analog switch boost needs to be enabled (see BOOSTE bit). It must be set by software when the expected V DDA analog supply level is available. The correct analog supply level is indicated by the AVDO bit (PWR_VMSR register) after setting the AVDEN bit (PWR_VMCR register) and selecting the supply level to be monitored (ALS bits).
    $19 constant PWR_SRAM2SO                    \ [0x19] AHB SRAM2 shut-off in Stop mode.
    $1a constant PWR_SRAM1SO                    \ [0x1a] AHB SRAM1 shut-off in Stop mode
  [then]


  [ifdef] PWR_PWR_PMSR_DEF
    \
    \ @brief PWR status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $05 constant PWR_STOPF                      \ [0x05] Stop flag This bit is set by hardware and cleared only by any reset or by setting the CSSF bit.
    $06 constant PWR_SBF                        \ [0x06] System standby flag This bit is set by hardware and cleared only by a POR or by setting the CSSF bit.
  [then]


  [ifdef] PWR_PWR_VOSCR_DEF
    \
    \ @brief PWR voltage scaling control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant PWR_VOS                        \ [0x04 : 2] voltage scaling selection according to performance These bits control the V CORE voltage level and allow to obtain the best trade-off between power consumption and performance: - In bypass mode, these bits must also be set according to the external provided core voltage level and related performance. - When increasing the performance, the voltage scaling must be changed before increasing the system frequency. - When decreasing performance, the system frequency must first be decreased before changing the voltage scaling.
  [then]


  [ifdef] PWR_PWR_VOSSR_DEF
    \
    \ @brief PWR voltage scaling status register
    \ Address offset: 0x14
    \ Reset value: 0x00000008
    \
    $03 constant PWR_VOSRDY                     \ [0x03] Ready bit for V CORE voltage scaling output selection.
    $0d constant PWR_ACTVOSRDY                  \ [0x0d] Voltage level ready for currently used VOS
    $0e constant PWR_ACTVOS                     \ [0x0e : 2] voltage output scaling currently applied to V CORE This field provides the last VOS value.
  [then]


  [ifdef] PWR_PWR_BDCR_DEF
    \
    \ @brief PWR Backup domain control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BREN                       \ [0x00] Backup RAM retention in Standby and V BAT modes When this bit set, the backup regulator (used to maintain the backup RAM content in Standby and V BAT modes) is enabled. If BREN is cleared, the backup regulator is switched off. The backup RAM can still be used in Run and Stop modes. However its content is lost in Standby and V BAT modes. If BREN is set, the application must wait till the backup regulator ready flag (BRRDY) is set to indicate that the data written into the SRAM is maintained in Standby and V BAT modes.
    $01 constant PWR_MONEN                      \ [0x01] Backup domain voltage and temperature monitoring enable
    $08 constant PWR_VBE                        \ [0x08] V BAT charging enable Note: Reset only by POR,.
    $09 constant PWR_VBRS                       \ [0x09] V BAT charging resistor selection
  [then]


  [ifdef] PWR_PWR_DBPCR_DEF
    \
    \ @brief PWR disable backup protection control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_DBP                        \ [0x00] Disable Backup domain write protection In reset state, all registers and SRAM in Backup domain are protected against parasitic write access. This bit must be set to enable write access to these registers.
  [then]


  [ifdef] PWR_PWR_BDSR_DEF
    \
    \ @brief PWR Backup domain status register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $10 constant PWR_BRRDY                      \ [0x10] backup regulator ready This bit is set by hardware to indicate that the backup regulator is ready.
    $14 constant PWR_VBATL                      \ [0x14] V BAT level monitoring versus low threshold
    $15 constant PWR_VBATH                      \ [0x15] V BAT level monitoring versus high threshold
    $16 constant PWR_TEMPL                      \ [0x16] temperature level monitoring versus low threshold
    $17 constant PWR_TEMPH                      \ [0x17] temperature level monitoring versus high threshold
  [then]


  [ifdef] PWR_PWR_SCCR_DEF
    \
    \ @brief PWR supply configuration control register
    \ Address offset: 0x30
    \ Reset value: 0x00000100
    \
    $00 constant PWR_BYPASS                     \ [0x00] power management unit bypass
    $08 constant PWR_LDOEN                      \ [0x08] LDO enable The value is set by hardware when the package uses the LDO regulator.
  [then]


  [ifdef] PWR_PWR_VMCR_DEF
    \
    \ @brief PWR voltage monitor control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PVDE                       \ [0x00] PVD enable
    $01 constant PWR_PLS                        \ [0x01 : 3] programmable voltage detector (PVD) level selection These bits select the voltage threshold detected by the PVD.
    $08 constant PWR_AVDEN                      \ [0x08] peripheral voltage monitor on V DDA enable
    $09 constant PWR_ALS                        \ [0x09 : 2] analog voltage detector (AVD) level selection These bits select the voltage threshold detected by the AVD.
  [then]


  [ifdef] PWR_PWR_VMSR_DEF
    \
    \ @brief PWR voltage monitor status register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $13 constant PWR_AVDO                       \ [0x13] analog voltage detector output on V DDA This bit is set and cleared by hardware. It is valid only if AVD on VDDA is enabled by the AVDEN bit. Note: Since the AVD is disabled in Standby mode, this bit is equal to 0 after standby or reset until the AVDEN bit is set.
    $14 constant PWR_VDDIO2RDY                  \ [0x14] voltage detector output on V DDIO2 This bit is set and cleared by hardware.
    $16 constant PWR_PVDO                       \ [0x16] programmable voltage detect output This bit is set and cleared by hardware. It is valid only if the PVD has been enabled by the PVDE bit. Note: Since the PVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the PVDE bit is set.
  [then]


  [ifdef] PWR_PWR_WUSCR_DEF
    \
    \ @brief PWR wakeup status clear register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CWUF1                      \ [0x00] clear wakeup pin flag for WUFx These bits are always read as 0.
    $01 constant PWR_CWUF2                      \ [0x01] clear wakeup pin flag for WUFx These bits are always read as 0.
    $02 constant PWR_CWUF3                      \ [0x02] clear wakeup pin flag for WUFx These bits are always read as 0.
    $03 constant PWR_CWUF4                      \ [0x03] clear wakeup pin flag for WUFx These bits are always read as 0.
    $04 constant PWR_CWUF5                      \ [0x04] clear wakeup pin flag for WUFx These bits are always read as 0.
  [then]


  [ifdef] PWR_PWR_WUSR_DEF
    \
    \ @brief PWR wakeup status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUF1                       \ [0x00] wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
    $01 constant PWR_WUF2                       \ [0x01] wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
    $02 constant PWR_WUF3                       \ [0x02] wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
    $03 constant PWR_WUF4                       \ [0x03] wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
    $04 constant PWR_WUF5                       \ [0x04] wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
  [then]


  [ifdef] PWR_PWR_WUCR_DEF
    \
    \ @brief PWR wakeup configuration register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUPEN1                     \ [0x00] enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
    $01 constant PWR_WUPEN2                     \ [0x01] enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
    $02 constant PWR_WUPEN3                     \ [0x02] enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
    $03 constant PWR_WUPEN4                     \ [0x03] enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
    $04 constant PWR_WUPEN5                     \ [0x04] enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
    $08 constant PWR_WUPP1                      \ [0x08] wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
    $09 constant PWR_WUPP2                      \ [0x09] wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
    $0a constant PWR_WUPP3                      \ [0x0a] wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
    $0b constant PWR_WUPP4                      \ [0x0b] wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
    $0c constant PWR_WUPP5                      \ [0x0c] wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
    $10 constant PWR_WUPPUPD1                   \ [0x10 : 2] wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
    $12 constant PWR_WUPPUPD2                   \ [0x12 : 2] wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
    $14 constant PWR_WUPPUPD3                   \ [0x14 : 2] wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
    $16 constant PWR_WUPPUPD4                   \ [0x16 : 2] wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
    $18 constant PWR_WUPPUPD5                   \ [0x18 : 2] wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
  [then]


  [ifdef] PWR_PWR_IORETR_DEF
    \
    \ @brief PWR I/O retention register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant PWR_IORETEN                    \ [0x00] IO retention enable: When entering into standby mode, the output is sampled, and applied to the output IO during the standby power mode. Note: the IO state is not retained if the DBG_STANDBY bit is set in DBGMCU_CR register.
    $10 constant PWR_JTAGIORETEN                \ [0x10] IO retention enable for JTAG IOs when entering into standby mode, the output is sampled, and applied to the output IO during the standby power mode
  [then]


  [ifdef] PWR_PWR_PRIVCFGR_DEF
    \
    \ @brief PWR privilege configuration register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $01 constant PWR_NSPRIV                     \ [0x01] PWR functions privilege configuration Set and reset by software. This bit can be written only by privileged access.
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_PWR_PMCR             \ PWR power mode control register
  $04 constant PWR_PWR_PMSR             \ PWR status register
  $10 constant PWR_PWR_VOSCR            \ PWR voltage scaling control register
  $14 constant PWR_PWR_VOSSR            \ PWR voltage scaling status register
  $20 constant PWR_PWR_BDCR             \ PWR Backup domain control register
  $24 constant PWR_PWR_DBPCR            \ PWR disable backup protection control register
  $28 constant PWR_PWR_BDSR             \ PWR Backup domain status register
  $30 constant PWR_PWR_SCCR             \ PWR supply configuration control register
  $34 constant PWR_PWR_VMCR             \ PWR voltage monitor control register
  $3C constant PWR_PWR_VMSR             \ PWR voltage monitor status register
  $40 constant PWR_PWR_WUSCR            \ PWR wakeup status clear register
  $44 constant PWR_PWR_WUSR             \ PWR wakeup status register
  $48 constant PWR_PWR_WUCR             \ PWR wakeup configuration register
  $50 constant PWR_PWR_IORETR           \ PWR I/O retention register
  $104 constant PWR_PWR_PRIVCFGR        \ PWR privilege configuration register

: PWR_DEF ; [then]
