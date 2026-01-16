\
\ @file pwr.fs
\ @brief PWR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PWR control register 1
\ Address offset: 0x00
\ Reset value: 0x00000200
\

$00000001 constant PWR_PWR_CR1_LPDS                                 \ Low Power Deepsleep Stop mode selection.
$00000002 constant PWR_PWR_CR1_LPCFG                                \ PWR_ON pin configuration.
$00000004 constant PWR_PWR_CR1_LVDS                                 \ Low Voltage Deepsleep LPLV-Stop mode selection. This bit has only effect when the low power stop mode is selected in LPDS and changes the VDDCORE and VDDCPU domains supply reset level.
$00000008 constant PWR_PWR_CR1_STOP2                                \ System LPLV-Stop2 mode selection
$00000010 constant PWR_PWR_CR1_PVDEN                                \ Programmable Voltage detector enable. This bit is read only when the SYSCFG register bit PVDL is set (when PVDL is set, there is no bus errors generated when writing this register).
$000000e0 constant PWR_PWR_CR1_PLS                                  \ Programmable Voltage Detector level selection. These bits are read only when the SYSCFG register bit PVDL is set (when PVDL is set, there is no bus errors generated when writing this register). These bits select the voltage threshold detected by the PVD.
$00000100 constant PWR_PWR_CR1_DBP                                  \ Disable backup domain write protection. In reset state, the RCC_BDCR, PWR_CR2, RTC, and backup registers are protected against parasitic write access. This bit must be set to enable write access to these.
$00000200 constant PWR_PWR_CR1_MPU_RAM_LOWSPEED                     \ Low speed selection for MPU memories This bit must be reset by software when MPU needs to operate in Overdrive (High speed) mode It must be set after decreasing the MPU frequency to operate in standard frequency range.
$00010000 constant PWR_PWR_CR1_AVDEN                                \ Peripheral Voltage Monitor on VDDA enable.
$00060000 constant PWR_PWR_CR1_ALS                                  \ Analog Voltage Detector level selection. These bits select the voltage threshold detected by the AVD.


\
\ @brief PWR control status register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000010 constant PWR_PWR_CSR1_PVDO                                \ Programmable Voltage Detect Output This bit is set and cleared by hardware. It is valid only if PVD is enabled by the PVDEN bit. Note: The PVD is disabled in Standby mode and after a system reset. For this reason, this bit is equal to 0 after Standby and system reset.
$00010000 constant PWR_PWR_CSR1_AVDO                                \ Analog Voltage detector Output on VDDA. This bit is set and cleared by hardware. It is valid only if AVD on VDDA is enabled by the AVDEN bit. Note: The AVD is disabled in Standby mode and after system reset. For this reason, this bit is equal to 0 after Standby and reset.


\
\ @brief PWR control register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR2_BREN                                 \ Backup regulator enable When set, the backup regulator (used to maintain backup RAM content in Standby and VBAT modes) is enabled. If BREN is reset, the backup regulator is switched off. The backup RAM can still be used in Run mode and Stop mode but its content is lost in the Standby and VBAT modes. Once set, the application must wait that the Backup Regulator Ready flag (BRRDY) is set to indicate that the data written into the SRAM is maintained in the Standby and VBAT modes.
$00000010 constant PWR_PWR_CR2_MONEN                                \ VBAT and temperature monitoring enable When set, the VBAT supply and temperature monitoring is enabled.
$00010000 constant PWR_PWR_CR2_BRRDY                                \ Backup Regulator ready Set by hardware to indicate that the Backup Regulator is ready. Entering Standby or VBAT mode before the Backup Regulator is ready may cause loss of Backup RAM content.
$00100000 constant PWR_PWR_CR2_VBATL                                \ Monitored VBAT level above low threshold
$00200000 constant PWR_PWR_CR2_VBATH                                \ Monitored VBAT level above high threshold
$00400000 constant PWR_PWR_CR2_TEMPL                                \ Monitored temperature level above low threshold
$00800000 constant PWR_PWR_CR2_TEMPH                                \ Monitored temperature level above high threshold


\
\ @brief PWR control register 3
\ Address offset: 0x0C
\ Reset value: 0x5000A000
\

$00000100 constant PWR_PWR_CR3_VBE                                  \ VBAT charging enable
$00000200 constant PWR_PWR_CR3_VBRS                                 \ VBAT charging resistor selection
$00000400 constant PWR_PWR_CR3_DDRSREN                              \ DDR self-refresh in standby mode enable When set, the DDR PHY puts its pads in retention when entering Standby mode.
$00000800 constant PWR_PWR_CR3_DDRSRDIS                             \ DDR self-refresh retention after standby disable When written 'b1, the DDR PHY pads retention, enabled due to DDRSREN, is disabled.
$00001000 constant PWR_PWR_CR3_DDRRETEN                             \ DDR retention enable Set by Hardware on NRST pad reset, when the reset delay control is enabled in the RCC_MP_APRSTCR.RDCTLEN register bit, or when written 'b1 by software, the DDR PHY puts its pads in retention. To disable retention software must write this bit to 'b0.
$00002000 constant PWR_PWR_CR3_VDDSD1DEN                            \ VDDSD1 voltage level detector enable The voltage level detector is active by default. It enables the I/Os in the VDDSD1 domain if and when the VDDSD1 supply voltage is higher than VDDSDx_TH. Once the supply is stable above this threshold (VDDSD1RDYÂ =Â 1), the level detectors can be switched off to save power, without disabling the I/Os, by setting VDDSD1VALIDÂ =Â 1 followed by VDDSD1ENÂ =Â 0 (refer to datasheet for VDDSDx_TH value).
$00004000 constant PWR_PWR_CR3_VDDSD1RDY                            \ VDDSD1 supply ready When the level detector is active (VDDSD1DEN = 1), this bit indicates if a voltage higher than VDDSDx_TH is present on the VDDSD1 supply (refer to datasheet for VDDSDx_TH value).
$00008000 constant PWR_PWR_CR3_VDDSD2DEN                            \ VDDSD2 voltage level detector enable The voltage level detector is active by default. It enables the I/Os in the VDDSD2 domain if and when the VDDSD2 supply voltage is higher than VDDSDx_TH. Once the supply is stable above this threshold (VDDSD2RDYÂ =Â 1), the level detectors can be switched off to save power, without disabling the I/Os, by setting VDDSD2VALIDÂ =Â 1 followed by VDDSD2ENÂ =Â 0 (refer to datasheet for VDDSDx_TH value).
$00010000 constant PWR_PWR_CR3_VDDSD2RDY                            \ VDDSD2 supply ready When the level detector is active (VDDSD2DEN = 1), this bit indicates if a voltage higher than VDDSDx_TH is present on the VDDSD2 supply (refer to datasheet for VDDSDx_TH value).
$003e0000 constant PWR_PWR_CR3_POPL                                 \ PWR_ON, PWR_CPU_ON Standby pulse low configuration These bits are set and cleared by software. They define the minimum guaranteed duration of the PWR_ON and PWR_CPU_ON low pulse in Standby mode (there is no impact on the LP-Stop and LPLV-Stop modes). The LSI oscillator is automatically enabled when needed by the POPL pulse low configuration. ...
$00400000 constant PWR_PWR_CR3_VDDSD1VALID                          \ Override VDDSD1 voltage detector This bit enables the I/Os in the VDDSD1 domain whatever the state of VDDSD1RDY. This bit can be set by software once VDDSD1 is higher than VDDSDx_TH and stable (bit VDDSD1RDYÂ =Â 1). Subsequently VDDSD1EN can be reset to 0 to disable the voltage detector and save power (refer to datasheet for VDDSDx_TH value).
$00800000 constant PWR_PWR_CR3_VDDSD2VALID                          \ Override VDDSD2 voltage detector This bit enables the I/Os in the VDDSD2 domain whatever the state of VDDSD2RDY. This bit can be set by software once VDDSD2 is higher than VDDSDx_TH and stable (bit VDDSD2RDYÂ =Â 1). Subsequently VDDSD2EN can be reset to 0 to disable the voltage detector and save power (refer to datasheet for VDDSDx_TH value).
$01000000 constant PWR_PWR_CR3_USB33DEN                             \ USB 3.3V voltage level detector enable
$04000000 constant PWR_PWR_CR3_USB33RDY                             \ USB 3.3V supply ready
$10000000 constant PWR_PWR_CR3_REG18EN                              \ 1V8 regulator enable
$20000000 constant PWR_PWR_CR3_REG18RDY                             \ 1V8 regulator supply ready
$40000000 constant PWR_PWR_CR3_REG11EN                              \ 1V1 regulator enable
$80000000 constant PWR_PWR_CR3_REG11RDY                             \ 1V1 regulator supply ready


\
\ @brief PWR MPU control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_MPUCR_PDDS                               \ System Power Down Deepsleep selection This bit is reset only by a VDD POR reset (not reset when exit from Standby mode). Allows to define the Deepsleep mode for the system.
$00000020 constant PWR_PWR_MPUCR_STOPF                              \ Stop flag This bit is set by hardware and cleared only by any system reset or by setting the MPU CSSF bit. This bit is cleared by the MPU Boot ROM. For more information refer to Boot ROM application note.
$00000040 constant PWR_PWR_MPUCR_SBF                                \ System Standby flag This bit is set by hardware and cleared only by a VDD POR reset or by setting the MPU CSSF bit (not reset when exit from Standby mode). This bit is cleared by the MPU Boot ROM. For more information refer to Boot ROM application note.
$00000080 constant PWR_PWR_MPUCR_SBFMPU                             \ MPU Standby flag This bit is set by hardware and cleared only by a VDD POR reset or by setting the MPU CSSF bit (not reset when exit from Standby mode). This bit is cleared by the MPU Boot ROM. For more information refer to Boot ROM application note.
$00000200 constant PWR_PWR_MPUCR_CSSF                               \ Clear MPU Standby, Stop flags.(Always read as 0) This bit is reset on any system reset.
$00008000 constant PWR_PWR_MPUCR_STANDBYWFIL2                       \ MPU system idle indication This bit is set and reset by hardware based on the MPU operation mode.


\
\ @brief PWR wakeup control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPCR_WKUPC1                            \ Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
$00000002 constant PWR_PWR_WKUPCR_WKUPC2                            \ Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
$00000004 constant PWR_PWR_WKUPCR_WKUPC3                            \ Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
$00000008 constant PWR_PWR_WKUPCR_WKUPC4                            \ Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
$00000010 constant PWR_PWR_WKUPCR_WKUPC5                            \ Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
$00000020 constant PWR_PWR_WKUPCR_WKUPC6                            \ Clear Wakeup Flag for WKUPn pin, n range [6:1] When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access. These bits are always read as 0.
$00000100 constant PWR_PWR_WKUPCR_WKUPP1                            \ Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
$00000200 constant PWR_PWR_WKUPCR_WKUPP2                            \ Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
$00000400 constant PWR_PWR_WKUPCR_WKUPP3                            \ Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
$00000800 constant PWR_PWR_WKUPCR_WKUPP4                            \ Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
$00001000 constant PWR_PWR_WKUPCR_WKUPP5                            \ Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
$00002000 constant PWR_PWR_WKUPCR_WKUPP6                            \ Wakeup Polarity bit for WKUPn pin, n range [6:1] These bits define the polarity used for event detection on external wake-up WKUPn pin. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit n can only be written by a secure access, a non-secure write on this bit is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit n can be written by a secure and non-secure access.
$00030000 constant PWR_PWR_WKUPCR_WKUPPUPD1                         \ Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
$000c0000 constant PWR_PWR_WKUPCR_WKUPPUPD2                         \ Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
$00300000 constant PWR_PWR_WKUPCR_WKUPPUPD3                         \ Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
$00c00000 constant PWR_PWR_WKUPCR_WKUPPUPD4                         \ Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
$03000000 constant PWR_PWR_WKUPCR_WKUPPUPD5                         \ Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.
$0c000000 constant PWR_PWR_WKUPCR_WKUPPUPD6                         \ Wakeup pull configuration for WKUPn pin (n = 6 to 1) These bits define the IO pad pull configuration used when WKUPENn = 1 (note that the associated GPIO port pull configuration must be set to the same value or 00). The wakeup pin pull configuration is maintained in Standby mode. When TZEN is enabled in the RCC and WKUPENn in (PWR_MPUWKUPENR) is set, bit pair n can only be written by a secure access, a non-secure write on this bit pair is discarded. When TZEN is disabled in the RCC or WKUPENn in (PWR_MPUWKUPENR) is clear, bit pair n can be written by a secure and non-secure access.


\
\ @brief PWR wakeup flag register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPFR_WKUPF1                            \ Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
$00000002 constant PWR_PWR_WKUPFR_WKUPF2                            \ Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
$00000004 constant PWR_PWR_WKUPFR_WKUPF3                            \ Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
$00000008 constant PWR_PWR_WKUPFR_WKUPF4                            \ Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
$00000010 constant PWR_PWR_WKUPFR_WKUPF5                            \ Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the
$00000020 constant PWR_PWR_WKUPFR_WKUPF6                            \ Wakeup flag for WKUPn pin before enable, n range [6:1]. This bit is set by hardware and cleared only by a NRST Reset or by setting the WKUPCn bit in the


\
\ @brief PWR MPU wakeup enable register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_MPUWKUPENR_WKUPEN1                       \ Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
$00000002 constant PWR_PWR_MPUWKUPENR_WKUPEN2                       \ Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
$00000004 constant PWR_PWR_MPUWKUPENR_WKUPEN3                       \ Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
$00000008 constant PWR_PWR_MPUWKUPENR_WKUPEN4                       \ Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
$00000010 constant PWR_PWR_MPUWKUPENR_WKUPEN5                       \ Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.
$00000020 constant PWR_PWR_MPUWKUPENR_WKUPEN6                       \ Enable Wakeup WKUPn pin and interrupt for MPU, n range [6:1] Each bit is set and cleared by software. When TZEN is enabled in the RCC, these bits can only be written by a secure access, a non-secure write is discarded. When TZEN is disabled in the RCC, these bits can be written by a secure and non-secure access.


\
\ @brief PWR IP version register
\ Address offset: 0x3F4
\ Reset value: 0x00000020
\

$0000000f constant PWR_PWR_VER_MINREV                               \ Minor revision number
$000000f0 constant PWR_PWR_VER_MAJREV                               \ Major revision number


\
\ @brief PWR IP identification register
\ Address offset: 0x3F8
\ Reset value: 0x00010001
\

$00000000 constant PWR_PWR_ID_IPID                                  \ IP identification


\
\ @brief PWR size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant PWR_PWR_SID_SID                                  \ Size identification


\
\ @brief PWR
\
$50001000 constant PWR_PWR_CR1    \ offset: 0x00 : PWR control register 1
$50001004 constant PWR_PWR_CSR1   \ offset: 0x04 : PWR control status register 1
$50001008 constant PWR_PWR_CR2    \ offset: 0x08 : PWR control register 2
$5000100c constant PWR_PWR_CR3    \ offset: 0x0C : PWR control register 3
$50001010 constant PWR_PWR_MPUCR  \ offset: 0x10 : PWR MPU control register
$50001020 constant PWR_PWR_WKUPCR  \ offset: 0x20 : PWR wakeup control register
$50001024 constant PWR_PWR_WKUPFR  \ offset: 0x24 : PWR wakeup flag register
$50001028 constant PWR_PWR_MPUWKUPENR  \ offset: 0x28 : PWR MPU wakeup enable register
$500013f4 constant PWR_PWR_VER    \ offset: 0x3F4 : PWR IP version register
$500013f8 constant PWR_PWR_ID     \ offset: 0x3F8 : PWR IP identification register
$500013fc constant PWR_PWR_SID    \ offset: 0x3FC : PWR size ID register

