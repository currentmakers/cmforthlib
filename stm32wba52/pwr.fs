\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PWR control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000007 constant PWR_PWR_CR1_LPMS                                 \ Low-power mode selection These bits select the low-power mode entered when the CPU enters the SleepDeep mode. 10x: Standby mode others reserved
$00000020 constant PWR_PWR_CR1_R2RSB1                               \ SRAM2 retention in Standby mode This bit is used to keep the SRAM2 content in Standby retention mode.
$00000080 constant PWR_PWR_CR1_ULPMEN                               \ BOR0 ultra-low-power mode. This bit is used to reduce the consumption by configuring the BOR0 in discontinuous mode for Stop 1 and Standby modes. Discontinuous mode is only available when BOR levels 1 to 4 and PVD are disabled. Note: This bit must be set to reach the lowest power consumption in the low-power modes. Note: This bit must not be set together with autonomous peripherals using HSI16 as kernel clock. Note: When BOR level 1 to 4 or PVD is enabled continuous mode applies independent from ULPMEN.
$00000200 constant PWR_PWR_CR1_RADIORSB                             \ 2.4 GHz RADIO SRAMs (RXTXRAM and Sequence RAM) and Sleep clock retention in Standby mode. This bit is used to keep the 2.4 GHz RADIO SRAMs content in Standby retention mode and the 2.4 GHz RADIO sleep timer counter operational.
$00001000 constant PWR_PWR_CR1_R1RSB1                               \ SRAM1 retention in Standby mode This bit is used to keep the SRAM1 content in Standby retention mode.


\
\ @brief PWR control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR2_SRAM1PDS1                            \ SRAM1 power-down in Stop modes (Stop 0, 1) Note: The SRAM1 retention in Standby mode is controlled by R1RSB1 bit in PWR_CR1.
$00000010 constant PWR_PWR_CR2_SRAM2PDS1                            \ SRAM2 power-down in Stop modes (Stop 0, 1) Note: The SRAM2 retention in Standby mode is controlled by R2RSB1 bit in PWR_CR1.
$00000100 constant PWR_PWR_CR2_ICRAMPDS                             \ ICACHE SRAM power-down in Stop modes (Stop 0, 1)
$00004000 constant PWR_PWR_CR2_FLASHFWU                             \ Flash memory fast wakeup from Stop modes (Stop 0, 1) This bit is used to obtain the best trade-off between low-power consumption and wakeup time when exiting the Stop 0 or Stop 1 modes. When this bit is set, the Flash memory remains in normal mode in Stop 0 and Stop 1 modes, which offers a faster startup time with higher consumption.


\
\ @brief PWR control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant PWR_PWR_CR3_REGSEL                               \ Regulator selection
$00000004 constant PWR_PWR_CR3_FSTEN                                \ Fast soft start


\
\ @brief PWR voltage scaling register
\ Address offset: 0x0C
\ Reset value: 0x00008000
\

$00008000 constant PWR_PWR_VOSR_VOSRDY                              \ Ready bit for VsubCORE/sub voltage scaling output selection Set and cleared by hardware. When decreasing the voltage scaling range, VOSRDY must be one before increasing the SYSCLK frequency.
$00010000 constant PWR_PWR_VOSR_VOS                                 \ Voltage scaling range selection Set a and cleared by software. Cleared by hardware when entering Stop 1 mode. Access can be secured by RCC SYSCLKSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR supply voltage monitoring control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000010 constant PWR_PWR_SVMCR_PVDE                               \ Programmable voltage detector enable
$000000e0 constant PWR_PWR_SVMCR_PVDLS                              \ Programmable voltage detector level selection These bits select the voltage threshold detected by the programmable voltage detector:


\
\ @brief PWR wakeup control register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUCR1_WUPEN1                             \ Wakeup and interrupt pin WKUP1 enable Access can be secured by PWR WUP1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000002 constant PWR_PWR_WUCR1_WUPEN2                             \ Wakeup and interrupt pin WKUP2 enable Access can be secured by PWR WUP2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000004 constant PWR_PWR_WUCR1_WUPEN3                             \ Wakeup and interrupt pin WKUP3 enable Access can be secured by PWR WUP3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000008 constant PWR_PWR_WUCR1_WUPEN4                             \ Wakeup and interrupt pin WKUP4 enable Access can be secured by PWR WUP4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000010 constant PWR_PWR_WUCR1_WUPEN5                             \ Wakeup and interrupt pin WKUP5 enable Access can be secured by PWR WUP5SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000020 constant PWR_PWR_WUCR1_WUPEN6                             \ Wakeup and interrupt pin WKUP6 enable Access can be secured by PWR WUP6SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000040 constant PWR_PWR_WUCR1_WUPEN7                             \ Wakeup and interrupt pin WKUP7 enable Access can be secured by PWR WUP7SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000080 constant PWR_PWR_WUCR1_WUPEN8                             \ Wakeup and interrupt pin WKUP8 enable Access can be secured by PWR WUP8SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR wakeup control register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUCR2_WUPP1                              \ Wakeup pin WKUP1 polarity. This bit must be configured when WUPEN1 = 0. Access can be secured by PWR WUP1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000002 constant PWR_PWR_WUCR2_WUPP2                              \ Wakeup pin WKUP2 polarity This bit must be configured when WUPEN2 = 0. Access can be secured by PWR WUP2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000004 constant PWR_PWR_WUCR2_WUPP3                              \ Wakeup pin WKUP3 polarity This bit must be configured when WUPEN3 = 0. Access can be secured by PWR WUP3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000008 constant PWR_PWR_WUCR2_WUPP4                              \ Wakeup pin WKUP4 polarity This bit must be configured when WUPEN4 = 0. Access can be secured by PWR WUP4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000010 constant PWR_PWR_WUCR2_WUPP5                              \ Wakeup pin WKUP5 polarity This bit must be configured when WUPEN5 = 0. Access can be secured by PWR WUP5SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000020 constant PWR_PWR_WUCR2_WUPP6                              \ Wakeup pin WKUP6 polarity This bit must be configured when WUPEN6 = 0. Access can be secured by PWR WUP6SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000040 constant PWR_PWR_WUCR2_WUPP7                              \ Wakeup pin WKUP7 polarity This bit must be configured when WUPEN7 = 0. Access can be secured by PWR WUP7SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000080 constant PWR_PWR_WUCR2_WUPP8                              \ Wakeup pin WKUP8 polarity This bit must be configured when WUPEN8 = 0. Access can be secured by PWR WUP8SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR wakeup control register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant PWR_PWR_WUCR3_WUSEL1                             \ Wakeup and interrupt pin WKUP1 selection This field must be configured when WUPEN1 = 0. Access can be secured by PWR WUP1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$0000000c constant PWR_PWR_WUCR3_WUSEL2                             \ Wakeup and interrupt pin WKUP2 selection This field must be configured when WUPEN2 = 0. Access can be secured by PWR WUP2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000030 constant PWR_PWR_WUCR3_WUSEL3                             \ Wakeup and interrupt pin WKUP3 selection This field must be configured when WUPEN3 = 0. Access can be secured by PWR WUP3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$000000c0 constant PWR_PWR_WUCR3_WUSEL4                             \ Wakeup and interrupt pin WKUP4 selection This field must be configured when WUPEN4 = 0. Access can be secured by PWR WUP4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000300 constant PWR_PWR_WUCR3_WUSEL5                             \ Wakeup and interrupt pin WKUP5 selection This field must be configured when WUPEN5 = 0. Access can be secured by PWR WUP5SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000c00 constant PWR_PWR_WUCR3_WUSEL6                             \ Wakeup and interrupt pin WKUP6 selection This field must be configured when WUPEN6 = 0. Access can be secured by PWR WUP6SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00003000 constant PWR_PWR_WUCR3_WUSEL7                             \ Wakeup and interrupt pin WKUP7 selection This field must be configured when WUPEN7 = 0. Access can be secured by PWR WUP7SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$0000c000 constant PWR_PWR_WUCR3_WUSEL8                             \ Wakeup and interrupt pin WKUP8 selection This field must be configured when WUPEN8 = 0. Access can be secured by PWR WUP8SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR disable Backup domain register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_DBPR_DBP                                 \ Disable Backup domain write protection In reset state, all registers and SRAM in Backup domain are protected against parasitic write access. This bit must be set to enable the write access to these registers.


\
\ @brief PWR security configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SECCFGR_WUP1SEC                          \ WUP1 secure protection
$00000002 constant PWR_PWR_SECCFGR_WUP2SEC                          \ WUP2 secure protection
$00000004 constant PWR_PWR_SECCFGR_WUP3SEC                          \ WUP3 secure protection
$00000008 constant PWR_PWR_SECCFGR_WUP4SEC                          \ WUP4 secure protection
$00000010 constant PWR_PWR_SECCFGR_WUP5SEC                          \ WUP5 secure protection
$00000020 constant PWR_PWR_SECCFGR_WUP6SEC                          \ WUP6 secure protection
$00000040 constant PWR_PWR_SECCFGR_WUP7SEC                          \ WUP7 secure protection
$00000080 constant PWR_PWR_SECCFGR_WUP8SEC                          \ WUP8 secure protection
$00001000 constant PWR_PWR_SECCFGR_LPMSEC                           \ Low-power modes secure protection
$00002000 constant PWR_PWR_SECCFGR_VDMSEC                           \ Voltage detection secure protection
$00004000 constant PWR_PWR_SECCFGR_VBSEC                            \ Backup domain secure protection


\
\ @brief PWR privilege control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PRIVCFGR_SPRIV                           \ PWR secure functions privilege configuration This bit is set and reset by software. It can be written only by a secure privileged access.
$00000002 constant PWR_PWR_PRIVCFGR_NSPRIV                          \ PWR non-secure functions privilege configuration This bit is set and reset by software. It can be written only by privileged access, secure or non-secure.


\
\ @brief PWR status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SR_CSSF                                  \ Clear Stop and Standby flags Access can be secured by PWR LPMSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the STOPF and SBF flags.
$00000002 constant PWR_PWR_SR_STOPF                                 \ Stop flag This bit is set by hardware when the device enters a Stop or Standby mode at the same time as the sysclk has been set by hardware to select HSI16. It's cleared by software by writing 1 to the CSSF bit and by hardware when SBF is set.
$00000004 constant PWR_PWR_SR_SBF                                   \ Standby flag This bit is set by hardware when the device enters the Standby mode and the CPU restart from its reset vector. It's cleared by writing 1 to the CSSF bit, or by a power-on reset. It is not cleared by the system reset.


\
\ @brief PWR supply voltage monitoring status register
\ Address offset: 0x3C
\ Reset value: 0x00008000
\

$00000002 constant PWR_PWR_SVMSR_REGS                               \ Regulator selection
$00000010 constant PWR_PWR_SVMSR_PVDO                               \ Programmable voltage detector output
$00008000 constant PWR_PWR_SVMSR_ACTVOSRDY                          \ Voltage level ready for currently used VOS
$00010000 constant PWR_PWR_SVMSR_ACTVOS                             \ VOS currently applied to VsubCORE/sub This field provides the last VOS value.


\
\ @brief PWR wakeup status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUSR_WUF1                                \ Wakeup and interrupt pending flag 1 This bit is set when a wakeup event is detected on WKUP1 pin. This bit is cleared by writing 1 in the CWUF1 bit of PWR_WUSCR or by hardware when WUPEN1 = 0.
$00000002 constant PWR_PWR_WUSR_WUF2                                \ Wakeup and interrupt pending flag 2 This bit is set when a wakeup event is detected on WKUP2 pin. This bit is cleared by writing 1 in the CWUF2 bit of PWR_WUSCR or by hardware when WUPEN2 = 0.
$00000004 constant PWR_PWR_WUSR_WUF3                                \ Wakeup and interrupt pending flag 3 This bit is set when a wakeup event is detected on WKUP3 pin. This bit is cleared by writing 1 in the CWUF3 bit of PWR_WUSCR or by hardware when WUPEN3 = 0.
$00000008 constant PWR_PWR_WUSR_WUF4                                \ Wakeup and interrupt pending flag 4 This bit is set when a wakeup event is detected on WKUP4 pin. This bit is cleared by writing 1 in the CWUF4 bit of PWR_WUSCR or by hardware when WUPEN4 = 0.
$00000010 constant PWR_PWR_WUSR_WUF5                                \ Wakeup and interrupt pending flag 5 This bit is set when a wakeup event is detected on WKUP5 pin. This bit is cleared by writing 1 in the CWUF5 bit of PWR_WUSCR or by hardware when WUPEN5 = 0.
$00000020 constant PWR_PWR_WUSR_WUF6                                \ Wakeup and interrupt pending flag 6 This bit is set when a wakeup event is detected on WKUP6 pin. This bit is cleared by writing 1 in the CWUF6 bit of PWR_WUSCR when WUSEL6 different 11, or by hardware when WUPEN6 = 0. When WUSEL6 = 11, this bit is cleared by hardware when all associated internal wakeup source are cleared. When WUSEL6 = 11, no WKUP interrupt is generated
$00000040 constant PWR_PWR_WUSR_WUF7                                \ Wakeup and interrupt pending flag 7 This bit is set when a wakeup event is detected on WKUP7 pin. This bit is cleared by writing 1 in the CWUF7 bit of PWR_WUSCR when WUSEL7 different 11, or by hardware when WUPEN7 = 0. When WUSEL7 = 11, this bit is cleared by hardware when all associated internal wakeup source are cleared. When WUSEL7 = 11, no WKUP interrupt is generated.
$00000080 constant PWR_PWR_WUSR_WUF8                                \ Wakeup and interrupt pending flag 8 This bit is set when a wakeup event is detected on WKUP8 pin. This bit is cleared by writing 1 in the CWUF8 bit of PWR_WUSCR when WUSEL8 different 11, or by hardware when WUPEN8 = 0. When WUSEL8 = 11, this bit is cleared by hardware when all associated internal wakeup source are cleared. When WUSEL8 = 11, no WKUP interrupt is generated


\
\ @brief PWR wakeup status clear register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUSCR_CWUF1                              \ Clear wakeup flag 1 Access can be secured by PWR WUP1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF1 flag in PWR_WUSR.
$00000002 constant PWR_PWR_WUSCR_CWUF2                              \ Clear wakeup flag 2 Access can be secured by PWR WUP2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF2 flag in PWR_WUSR.
$00000004 constant PWR_PWR_WUSCR_CWUF3                              \ Clear wakeup flag 3 Access can be secured by PWR WUP3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF3 flag in PWR_WUSR.
$00000008 constant PWR_PWR_WUSCR_CWUF4                              \ Clear wakeup flag 4 Access can be secured by PWR WUP4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF4 flag in PWR_WUSR.
$00000010 constant PWR_PWR_WUSCR_CWUF5                              \ Clear wakeup flag 5 Access can be secured by PWR WUP5SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF5 flag in PWR_WUSR.
$00000020 constant PWR_PWR_WUSCR_CWUF6                              \ Clear wakeup flag 6 Access can be secured by PWR WUP6SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF6 flag in PWR_WUSR.
$00000040 constant PWR_PWR_WUSCR_CWUF7                              \ Clear wakeup flag 7 Access can be secured by PWR WUP7SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF7 flag in PWR_WUSR.
$00000080 constant PWR_PWR_WUSCR_CWUF8                              \ Clear wakeup flag 8 Access can be secured by PWR WUP8SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF8 flag in PWR_WUSR.


\
\ @brief PWR port A Standby IO retention enable register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_IORETENRA_EN0                            \ Port A Standby GPIO retention enable Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV. When set, each bit enables the Standby GPIO retention feature for PAy
$00000002 constant PWR_PWR_IORETENRA_EN1                            \ Port A Standby GPIO retention enable Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV. When set, each bit enables the Standby GPIO retention feature for PAy
$00000004 constant PWR_PWR_IORETENRA_EN2                            \ Port A Standby GPIO retention enable Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV. When set, each bit enables the Standby GPIO retention feature for PAy
$00000008 constant PWR_PWR_IORETENRA_EN3                            \ Port A Standby GPIO retention enable Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV. When set, each bit enables the Standby GPIO retention feature for PAy
$00000020 constant PWR_PWR_IORETENRA_EN5                            \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000040 constant PWR_PWR_IORETENRA_EN6                            \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000080 constant PWR_PWR_IORETENRA_EN7                            \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000100 constant PWR_PWR_IORETENRA_EN8                            \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000200 constant PWR_PWR_IORETENRA_EN9                            \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000400 constant PWR_PWR_IORETENRA_EN10                           \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000800 constant PWR_PWR_IORETENRA_EN11                           \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00001000 constant PWR_PWR_IORETENRA_EN12                           \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00002000 constant PWR_PWR_IORETENRA_EN13                           \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00004000 constant PWR_PWR_IORETENRA_EN14                           \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00008000 constant PWR_PWR_IORETENRA_EN15                           \ Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR port A Standby IO retention status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_IORETRA_RET0                             \ Port A Standby GPIO retention active Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV.
$00000002 constant PWR_PWR_IORETRA_RET1                             \ Port A Standby GPIO retention active Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV.
$00000004 constant PWR_PWR_IORETRA_RET2                             \ Port A Standby GPIO retention active Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV.
$00000008 constant PWR_PWR_IORETRA_RET3                             \ Port A Standby GPIO retention active Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV.
$00000020 constant PWR_PWR_IORETRA_RET5                             \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000040 constant PWR_PWR_IORETRA_RET6                             \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000080 constant PWR_PWR_IORETRA_RET7                             \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000100 constant PWR_PWR_IORETRA_RET8                             \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000200 constant PWR_PWR_IORETRA_RET9                             \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000400 constant PWR_PWR_IORETRA_RET10                            \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000800 constant PWR_PWR_IORETRA_RET11                            \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00001000 constant PWR_PWR_IORETRA_RET12                            \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00002000 constant PWR_PWR_IORETRA_RET13                            \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00004000 constant PWR_PWR_IORETRA_RET14                            \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00008000 constant PWR_PWR_IORETRA_RET15                            \ Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR port B Standby IO retention enable register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_IORETENRB_EN0                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000002 constant PWR_PWR_IORETENRB_EN1                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000004 constant PWR_PWR_IORETENRB_EN2                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000008 constant PWR_PWR_IORETENRB_EN3                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000010 constant PWR_PWR_IORETENRB_EN4                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000020 constant PWR_PWR_IORETENRB_EN5                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000040 constant PWR_PWR_IORETENRB_EN6                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000080 constant PWR_PWR_IORETENRB_EN7                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000100 constant PWR_PWR_IORETENRB_EN8                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000200 constant PWR_PWR_IORETENRB_EN9                            \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000400 constant PWR_PWR_IORETENRB_EN10                           \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000800 constant PWR_PWR_IORETENRB_EN11                           \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00001000 constant PWR_PWR_IORETENRB_EN12                           \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00002000 constant PWR_PWR_IORETENRB_EN13                           \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00004000 constant PWR_PWR_IORETENRB_EN14                           \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00008000 constant PWR_PWR_IORETENRB_EN15                           \ Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR port B Standby IO retention status register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_IORETRB_RET0                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000002 constant PWR_PWR_IORETRB_RET1                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000004 constant PWR_PWR_IORETRB_RET2                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000008 constant PWR_PWR_IORETRB_RET3                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000010 constant PWR_PWR_IORETRB_RET4                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000020 constant PWR_PWR_IORETRB_RET5                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000040 constant PWR_PWR_IORETRB_RET6                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000080 constant PWR_PWR_IORETRB_RET7                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000100 constant PWR_PWR_IORETRB_RET8                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000200 constant PWR_PWR_IORETRB_RET9                             \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000400 constant PWR_PWR_IORETRB_RET10                            \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00000800 constant PWR_PWR_IORETRB_RET11                            \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00001000 constant PWR_PWR_IORETRB_RET12                            \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00002000 constant PWR_PWR_IORETRB_RET13                            \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00004000 constant PWR_PWR_IORETRB_RET14                            \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00008000 constant PWR_PWR_IORETRB_RET15                            \ Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR port C Standby IO retention enable register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00002000 constant PWR_PWR_IORETENRC_EN13                           \ Port C Standby GPIO retention enable Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00004000 constant PWR_PWR_IORETENRC_EN14                           \ Port C Standby GPIO retention enable Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00008000 constant PWR_PWR_IORETENRC_EN15                           \ Port C Standby GPIO retention enable Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR port C Standby IO retention status register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00002000 constant PWR_PWR_IORETRC_RET13                            \ Port C Standby GPIO retention active Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00004000 constant PWR_PWR_IORETRC_RET14                            \ Port C Standby GPIO retention active Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
$00008000 constant PWR_PWR_IORETRC_RET15                            \ Port C Standby GPIO retention active Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR port H Standby IO retention enable register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000008 constant PWR_PWR_IORETENRH_EN3                            \ Port H Standby GPIO retention enable Access can be secured by GPIOH SEC3. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR port H Standby IO retention status register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000008 constant PWR_PWR_IORETRH_RET3                             \ Port H Standby GPIO retention active Access can be secured by GPIOH SEC3. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.


\
\ @brief PWR 2.4 GHz RADIO status and control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000003 constant PWR_PWR_RADIOSCR_MODE                            \ 2.4 GHz RADIO operating mode. 1x: 2.4 GHz RADIO active mode
$00000004 constant PWR_PWR_RADIOSCR_PHYMODE                         \ 2.4 GHz RADIO PHY operating mode
$00000008 constant PWR_PWR_RADIOSCR_ENCMODE                         \ 2.4 GHz RADIO encryption function operating mode
$00001f00 constant PWR_PWR_RADIOSCR_RFVDDHPA                        \ 2.4 GHz RADIO VDDHPA control word. Bits [3:0] see Table 81: PA output power table format for definition. Bit [4] rf_event.
$00008000 constant PWR_PWR_RADIOSCR_REGPARDYVDDRFPA                 \ Ready bit for VsubDDHPA/sub voltage level when selecting VDDRFPA input. Note: REGPARDYVDDRFPA does not allow to detect correct VsubDDHPA/sub voltage level when request to lower the level.


\
\ @brief Power control
\
$46020800 constant PWR_PWR_CR1    \ offset: 0x00 : PWR control register 1
$46020804 constant PWR_PWR_CR2    \ offset: 0x04 : PWR control register 2
$46020808 constant PWR_PWR_CR3    \ offset: 0x08 : PWR control register 3
$4602080c constant PWR_PWR_VOSR   \ offset: 0x0C : PWR voltage scaling register
$46020810 constant PWR_PWR_SVMCR  \ offset: 0x10 : PWR supply voltage monitoring control register
$46020814 constant PWR_PWR_WUCR1  \ offset: 0x14 : PWR wakeup control register 1
$46020818 constant PWR_PWR_WUCR2  \ offset: 0x18 : PWR wakeup control register 2
$4602081c constant PWR_PWR_WUCR3  \ offset: 0x1C : PWR wakeup control register 3
$46020828 constant PWR_PWR_DBPR   \ offset: 0x28 : PWR disable Backup domain register
$46020830 constant PWR_PWR_SECCFGR  \ offset: 0x30 : PWR security configuration register
$46020834 constant PWR_PWR_PRIVCFGR  \ offset: 0x34 : PWR privilege control register
$46020838 constant PWR_PWR_SR     \ offset: 0x38 : PWR status register
$4602083c constant PWR_PWR_SVMSR  \ offset: 0x3C : PWR supply voltage monitoring status register
$46020844 constant PWR_PWR_WUSR   \ offset: 0x44 : PWR wakeup status register
$46020848 constant PWR_PWR_WUSCR  \ offset: 0x48 : PWR wakeup status clear register
$46020850 constant PWR_PWR_IORETENRA  \ offset: 0x50 : PWR port A Standby IO retention enable register
$46020854 constant PWR_PWR_IORETRA  \ offset: 0x54 : PWR port A Standby IO retention status register
$46020858 constant PWR_PWR_IORETENRB  \ offset: 0x58 : PWR port B Standby IO retention enable register
$4602085c constant PWR_PWR_IORETRB  \ offset: 0x5C : PWR port B Standby IO retention status register
$46020860 constant PWR_PWR_IORETENRC  \ offset: 0x60 : PWR port C Standby IO retention enable register
$46020864 constant PWR_PWR_IORETRC  \ offset: 0x64 : PWR port C Standby IO retention status register
$46020888 constant PWR_PWR_IORETENRH  \ offset: 0x88 : PWR port H Standby IO retention enable register
$4602088c constant PWR_PWR_IORETRH  \ offset: 0x8C : PWR port H Standby IO retention status register
$46020900 constant PWR_PWR_RADIOSCR  \ offset: 0x100 : PWR 2.4 GHz RADIO status and control register

