\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_CR1_DEF
    \
    \ @brief PWR control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PWR_LPMS                       \ [0x00 : 3] Low-power mode selection These bits select the low-power mode entered when the CPU enters the SleepDeep mode. 10x: Standby mode others reserved
    $05 constant PWR_R2RSB1                     \ [0x05] SRAM2 retention in Standby mode This bit is used to keep the SRAM2 content in Standby retention mode.
    $07 constant PWR_ULPMEN                     \ [0x07] BOR0 ultra-low-power mode. This bit is used to reduce the consumption by configuring the BOR0 in discontinuous mode for Stop 1 and Standby modes. Discontinuous mode is only available when BOR levels 1 to 4 and PVD are disabled. Note: This bit must be set to reach the lowest power consumption in the low-power modes. Note: This bit must not be set together with autonomous peripherals using HSI16 as kernel clock. Note: When BOR level 1 to 4 or PVD is enabled continuous mode applies independent from ULPMEN.
    $09 constant PWR_RADIORSB                   \ [0x09] 2.4 GHz RADIO SRAMs (RXTXRAM and Sequence RAM) and Sleep clock retention in Standby mode. This bit is used to keep the 2.4 GHz RADIO SRAMs content in Standby retention mode and the 2.4 GHz RADIO sleep timer counter operational.
    $0c constant PWR_R1RSB1                     \ [0x0c] SRAM1 retention in Standby mode This bit is used to keep the SRAM1 content in Standby retention mode.
  [then]


  [ifdef] PWR_PWR_CR2_DEF
    \
    \ @brief PWR control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWR_SRAM1PDS1                  \ [0x00] SRAM1 power-down in Stop modes (Stop 0, 1) Note: The SRAM1 retention in Standby mode is controlled by R1RSB1 bit in PWR_CR1.
    $04 constant PWR_SRAM2PDS1                  \ [0x04] SRAM2 power-down in Stop modes (Stop 0, 1) Note: The SRAM2 retention in Standby mode is controlled by R2RSB1 bit in PWR_CR1.
    $08 constant PWR_ICRAMPDS                   \ [0x08] ICACHE SRAM power-down in Stop modes (Stop 0, 1)
    $0e constant PWR_FLASHFWU                   \ [0x0e] Flash memory fast wakeup from Stop modes (Stop 0, 1) This bit is used to obtain the best trade-off between low-power consumption and wakeup time when exiting the Stop 0 or Stop 1 modes. When this bit is set, the Flash memory remains in normal mode in Stop 0 and Stop 1 modes, which offers a faster startup time with higher consumption.
  [then]


  [ifdef] PWR_PWR_CR3_DEF
    \
    \ @brief PWR control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant PWR_REGSEL                     \ [0x01] Regulator selection
    $02 constant PWR_FSTEN                      \ [0x02] Fast soft start
  [then]


  [ifdef] PWR_PWR_VOSR_DEF
    \
    \ @brief PWR voltage scaling register
    \ Address offset: 0x0C
    \ Reset value: 0x00008000
    \
    $0f constant PWR_VOSRDY                     \ [0x0f] Ready bit for VsubCORE/sub voltage scaling output selection Set and cleared by hardware. When decreasing the voltage scaling range, VOSRDY must be one before increasing the SYSCLK frequency.
    $10 constant PWR_VOS                        \ [0x10] Voltage scaling range selection Set a and cleared by software. Cleared by hardware when entering Stop 1 mode. Access can be secured by RCC SYSCLKSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_SVMCR_DEF
    \
    \ @brief PWR supply voltage monitoring control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant PWR_PVDE                       \ [0x04] Programmable voltage detector enable
    $05 constant PWR_PVDLS                      \ [0x05 : 3] Programmable voltage detector level selection These bits select the voltage threshold detected by the programmable voltage detector:
  [then]


  [ifdef] PWR_PWR_WUCR1_DEF
    \
    \ @brief PWR wakeup control register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUPEN1                     \ [0x00] Wakeup and interrupt pin WKUP1 enable Access can be secured by PWR WUP1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $01 constant PWR_WUPEN2                     \ [0x01] Wakeup and interrupt pin WKUP2 enable Access can be secured by PWR WUP2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $02 constant PWR_WUPEN3                     \ [0x02] Wakeup and interrupt pin WKUP3 enable Access can be secured by PWR WUP3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $03 constant PWR_WUPEN4                     \ [0x03] Wakeup and interrupt pin WKUP4 enable Access can be secured by PWR WUP4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $04 constant PWR_WUPEN5                     \ [0x04] Wakeup and interrupt pin WKUP5 enable Access can be secured by PWR WUP5SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $05 constant PWR_WUPEN6                     \ [0x05] Wakeup and interrupt pin WKUP6 enable Access can be secured by PWR WUP6SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $06 constant PWR_WUPEN7                     \ [0x06] Wakeup and interrupt pin WKUP7 enable Access can be secured by PWR WUP7SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $07 constant PWR_WUPEN8                     \ [0x07] Wakeup and interrupt pin WKUP8 enable Access can be secured by PWR WUP8SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_WUCR2_DEF
    \
    \ @brief PWR wakeup control register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUPP1                      \ [0x00] Wakeup pin WKUP1 polarity. This bit must be configured when WUPEN1 = 0. Access can be secured by PWR WUP1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $01 constant PWR_WUPP2                      \ [0x01] Wakeup pin WKUP2 polarity This bit must be configured when WUPEN2 = 0. Access can be secured by PWR WUP2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $02 constant PWR_WUPP3                      \ [0x02] Wakeup pin WKUP3 polarity This bit must be configured when WUPEN3 = 0. Access can be secured by PWR WUP3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $03 constant PWR_WUPP4                      \ [0x03] Wakeup pin WKUP4 polarity This bit must be configured when WUPEN4 = 0. Access can be secured by PWR WUP4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $04 constant PWR_WUPP5                      \ [0x04] Wakeup pin WKUP5 polarity This bit must be configured when WUPEN5 = 0. Access can be secured by PWR WUP5SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $05 constant PWR_WUPP6                      \ [0x05] Wakeup pin WKUP6 polarity This bit must be configured when WUPEN6 = 0. Access can be secured by PWR WUP6SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $06 constant PWR_WUPP7                      \ [0x06] Wakeup pin WKUP7 polarity This bit must be configured when WUPEN7 = 0. Access can be secured by PWR WUP7SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $07 constant PWR_WUPP8                      \ [0x07] Wakeup pin WKUP8 polarity This bit must be configured when WUPEN8 = 0. Access can be secured by PWR WUP8SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_WUCR3_DEF
    \
    \ @brief PWR wakeup control register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUSEL1                     \ [0x00 : 2] Wakeup and interrupt pin WKUP1 selection This field must be configured when WUPEN1 = 0. Access can be secured by PWR WUP1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $02 constant PWR_WUSEL2                     \ [0x02 : 2] Wakeup and interrupt pin WKUP2 selection This field must be configured when WUPEN2 = 0. Access can be secured by PWR WUP2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $04 constant PWR_WUSEL3                     \ [0x04 : 2] Wakeup and interrupt pin WKUP3 selection This field must be configured when WUPEN3 = 0. Access can be secured by PWR WUP3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $06 constant PWR_WUSEL4                     \ [0x06 : 2] Wakeup and interrupt pin WKUP4 selection This field must be configured when WUPEN4 = 0. Access can be secured by PWR WUP4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $08 constant PWR_WUSEL5                     \ [0x08 : 2] Wakeup and interrupt pin WKUP5 selection This field must be configured when WUPEN5 = 0. Access can be secured by PWR WUP5SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0a constant PWR_WUSEL6                     \ [0x0a : 2] Wakeup and interrupt pin WKUP6 selection This field must be configured when WUPEN6 = 0. Access can be secured by PWR WUP6SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0c constant PWR_WUSEL7                     \ [0x0c : 2] Wakeup and interrupt pin WKUP7 selection This field must be configured when WUPEN7 = 0. Access can be secured by PWR WUP7SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0e constant PWR_WUSEL8                     \ [0x0e : 2] Wakeup and interrupt pin WKUP8 selection This field must be configured when WUPEN8 = 0. Access can be secured by PWR WUP8SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_DBPR_DEF
    \
    \ @brief PWR disable Backup domain register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_DBP                        \ [0x00] Disable Backup domain write protection In reset state, all registers and SRAM in Backup domain are protected against parasitic write access. This bit must be set to enable the write access to these registers.
  [then]


  [ifdef] PWR_PWR_SECCFGR_DEF
    \
    \ @brief PWR security configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUP1SEC                    \ [0x00] WUP1 secure protection
    $01 constant PWR_WUP2SEC                    \ [0x01] WUP2 secure protection
    $02 constant PWR_WUP3SEC                    \ [0x02] WUP3 secure protection
    $03 constant PWR_WUP4SEC                    \ [0x03] WUP4 secure protection
    $04 constant PWR_WUP5SEC                    \ [0x04] WUP5 secure protection
    $05 constant PWR_WUP6SEC                    \ [0x05] WUP6 secure protection
    $06 constant PWR_WUP7SEC                    \ [0x06] WUP7 secure protection
    $07 constant PWR_WUP8SEC                    \ [0x07] WUP8 secure protection
    $0c constant PWR_LPMSEC                     \ [0x0c] Low-power modes secure protection
    $0d constant PWR_VDMSEC                     \ [0x0d] Voltage detection secure protection
    $0e constant PWR_VBSEC                      \ [0x0e] Backup domain secure protection
  [then]


  [ifdef] PWR_PWR_PRIVCFGR_DEF
    \
    \ @brief PWR privilege control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWR_SPRIV                      \ [0x00] PWR secure functions privilege configuration This bit is set and reset by software. It can be written only by a secure privileged access.
    $01 constant PWR_NSPRIV                     \ [0x01] PWR non-secure functions privilege configuration This bit is set and reset by software. It can be written only by privileged access, secure or non-secure.
  [then]


  [ifdef] PWR_PWR_SR_DEF
    \
    \ @brief PWR status register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CSSF                       \ [0x00] Clear Stop and Standby flags Access can be secured by PWR LPMSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the STOPF and SBF flags.
    $01 constant PWR_STOPF                      \ [0x01] Stop flag This bit is set by hardware when the device enters a Stop or Standby mode at the same time as the sysclk has been set by hardware to select HSI16. It's cleared by software by writing 1 to the CSSF bit and by hardware when SBF is set.
    $02 constant PWR_SBF                        \ [0x02] Standby flag This bit is set by hardware when the device enters the Standby mode and the CPU restart from its reset vector. It's cleared by writing 1 to the CSSF bit, or by a power-on reset. It is not cleared by the system reset.
  [then]


  [ifdef] PWR_PWR_SVMSR_DEF
    \
    \ @brief PWR supply voltage monitoring status register
    \ Address offset: 0x3C
    \ Reset value: 0x00008000
    \
    $01 constant PWR_REGS                       \ [0x01] Regulator selection
    $04 constant PWR_PVDO                       \ [0x04] Programmable voltage detector output
    $0f constant PWR_ACTVOSRDY                  \ [0x0f] Voltage level ready for currently used VOS
    $10 constant PWR_ACTVOS                     \ [0x10] VOS currently applied to VsubCORE/sub This field provides the last VOS value.
  [then]


  [ifdef] PWR_PWR_WUSR_DEF
    \
    \ @brief PWR wakeup status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUF1                       \ [0x00] Wakeup and interrupt pending flag 1 This bit is set when a wakeup event is detected on WKUP1 pin. This bit is cleared by writing 1 in the CWUF1 bit of PWR_WUSCR or by hardware when WUPEN1 = 0.
    $01 constant PWR_WUF2                       \ [0x01] Wakeup and interrupt pending flag 2 This bit is set when a wakeup event is detected on WKUP2 pin. This bit is cleared by writing 1 in the CWUF2 bit of PWR_WUSCR or by hardware when WUPEN2 = 0.
    $02 constant PWR_WUF3                       \ [0x02] Wakeup and interrupt pending flag 3 This bit is set when a wakeup event is detected on WKUP3 pin. This bit is cleared by writing 1 in the CWUF3 bit of PWR_WUSCR or by hardware when WUPEN3 = 0.
    $03 constant PWR_WUF4                       \ [0x03] Wakeup and interrupt pending flag 4 This bit is set when a wakeup event is detected on WKUP4 pin. This bit is cleared by writing 1 in the CWUF4 bit of PWR_WUSCR or by hardware when WUPEN4 = 0.
    $04 constant PWR_WUF5                       \ [0x04] Wakeup and interrupt pending flag 5 This bit is set when a wakeup event is detected on WKUP5 pin. This bit is cleared by writing 1 in the CWUF5 bit of PWR_WUSCR or by hardware when WUPEN5 = 0.
    $05 constant PWR_WUF6                       \ [0x05] Wakeup and interrupt pending flag 6 This bit is set when a wakeup event is detected on WKUP6 pin. This bit is cleared by writing 1 in the CWUF6 bit of PWR_WUSCR when WUSEL6 different 11, or by hardware when WUPEN6 = 0. When WUSEL6 = 11, this bit is cleared by hardware when all associated internal wakeup source are cleared. When WUSEL6 = 11, no WKUP interrupt is generated
    $06 constant PWR_WUF7                       \ [0x06] Wakeup and interrupt pending flag 7 This bit is set when a wakeup event is detected on WKUP7 pin. This bit is cleared by writing 1 in the CWUF7 bit of PWR_WUSCR when WUSEL7 different 11, or by hardware when WUPEN7 = 0. When WUSEL7 = 11, this bit is cleared by hardware when all associated internal wakeup source are cleared. When WUSEL7 = 11, no WKUP interrupt is generated.
    $07 constant PWR_WUF8                       \ [0x07] Wakeup and interrupt pending flag 8 This bit is set when a wakeup event is detected on WKUP8 pin. This bit is cleared by writing 1 in the CWUF8 bit of PWR_WUSCR when WUSEL8 different 11, or by hardware when WUPEN8 = 0. When WUSEL8 = 11, this bit is cleared by hardware when all associated internal wakeup source are cleared. When WUSEL8 = 11, no WKUP interrupt is generated
  [then]


  [ifdef] PWR_PWR_WUSCR_DEF
    \
    \ @brief PWR wakeup status clear register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CWUF1                      \ [0x00] Clear wakeup flag 1 Access can be secured by PWR WUP1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF1 flag in PWR_WUSR.
    $01 constant PWR_CWUF2                      \ [0x01] Clear wakeup flag 2 Access can be secured by PWR WUP2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF2 flag in PWR_WUSR.
    $02 constant PWR_CWUF3                      \ [0x02] Clear wakeup flag 3 Access can be secured by PWR WUP3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF3 flag in PWR_WUSR.
    $03 constant PWR_CWUF4                      \ [0x03] Clear wakeup flag 4 Access can be secured by PWR WUP4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF4 flag in PWR_WUSR.
    $04 constant PWR_CWUF5                      \ [0x04] Clear wakeup flag 5 Access can be secured by PWR WUP5SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF5 flag in PWR_WUSR.
    $05 constant PWR_CWUF6                      \ [0x05] Clear wakeup flag 6 Access can be secured by PWR WUP6SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF6 flag in PWR_WUSR.
    $06 constant PWR_CWUF7                      \ [0x06] Clear wakeup flag 7 Access can be secured by PWR WUP7SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF7 flag in PWR_WUSR.
    $07 constant PWR_CWUF8                      \ [0x07] Clear wakeup flag 8 Access can be secured by PWR WUP8SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV. Writing 1 to this bit clears the WUF8 flag in PWR_WUSR.
  [then]


  [ifdef] PWR_PWR_IORETENRA_DEF
    \
    \ @brief PWR port A Standby IO retention enable register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant PWR_EN0                        \ [0x00] Port A Standby GPIO retention enable Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV. When set, each bit enables the Standby GPIO retention feature for PAy
    $01 constant PWR_EN1                        \ [0x01] Port A Standby GPIO retention enable Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV. When set, each bit enables the Standby GPIO retention feature for PAy
    $02 constant PWR_EN2                        \ [0x02] Port A Standby GPIO retention enable Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV. When set, each bit enables the Standby GPIO retention feature for PAy
    $03 constant PWR_EN3                        \ [0x03] Port A Standby GPIO retention enable Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV. When set, each bit enables the Standby GPIO retention feature for PAy
    $05 constant PWR_EN5                        \ [0x05] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $06 constant PWR_EN6                        \ [0x06] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $07 constant PWR_EN7                        \ [0x07] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $08 constant PWR_EN8                        \ [0x08] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $09 constant PWR_EN9                        \ [0x09] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0a constant PWR_EN10                       \ [0x0a] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0b constant PWR_EN11                       \ [0x0b] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0c constant PWR_EN12                       \ [0x0c] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0d constant PWR_EN13                       \ [0x0d] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0e constant PWR_EN14                       \ [0x0e] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0f constant PWR_EN15                       \ [0x0f] Port A Standby GPIO retention enable Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_IORETRA_DEF
    \
    \ @brief PWR port A Standby IO retention status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant PWR_RET0                       \ [0x00] Port A Standby GPIO retention active Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV.
    $01 constant PWR_RET1                       \ [0x01] Port A Standby GPIO retention active Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV.
    $02 constant PWR_RET2                       \ [0x02] Port A Standby GPIO retention active Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV.
    $03 constant PWR_RET3                       \ [0x03] Port A Standby GPIO retention active Access can be protected by GPIOA SECy, privilege protection is controlled by PWR SPRIV or PWR NSPRIV.
    $05 constant PWR_RET5                       \ [0x05] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $06 constant PWR_RET6                       \ [0x06] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $07 constant PWR_RET7                       \ [0x07] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $08 constant PWR_RET8                       \ [0x08] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $09 constant PWR_RET9                       \ [0x09] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0a constant PWR_RET10                      \ [0x0a] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0b constant PWR_RET11                      \ [0x0b] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0c constant PWR_RET12                      \ [0x0c] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0d constant PWR_RET13                      \ [0x0d] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0e constant PWR_RET14                      \ [0x0e] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0f constant PWR_RET15                      \ [0x0f] Port A Standby GPIO retention active Access can be secured by GPIOA SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_IORETENRB_DEF
    \
    \ @brief PWR port B Standby IO retention enable register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant PWR_EN0                        \ [0x00] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $01 constant PWR_EN1                        \ [0x01] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $02 constant PWR_EN2                        \ [0x02] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $03 constant PWR_EN3                        \ [0x03] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $04 constant PWR_EN4                        \ [0x04] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $05 constant PWR_EN5                        \ [0x05] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $06 constant PWR_EN6                        \ [0x06] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $07 constant PWR_EN7                        \ [0x07] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $08 constant PWR_EN8                        \ [0x08] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $09 constant PWR_EN9                        \ [0x09] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0a constant PWR_EN10                       \ [0x0a] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0b constant PWR_EN11                       \ [0x0b] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0c constant PWR_EN12                       \ [0x0c] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0d constant PWR_EN13                       \ [0x0d] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0e constant PWR_EN14                       \ [0x0e] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0f constant PWR_EN15                       \ [0x0f] Port B Standby GPIO retention enable Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_IORETRB_DEF
    \
    \ @brief PWR port B Standby IO retention status register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_RET0                       \ [0x00] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $01 constant PWR_RET1                       \ [0x01] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $02 constant PWR_RET2                       \ [0x02] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $03 constant PWR_RET3                       \ [0x03] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $04 constant PWR_RET4                       \ [0x04] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $05 constant PWR_RET5                       \ [0x05] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $06 constant PWR_RET6                       \ [0x06] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $07 constant PWR_RET7                       \ [0x07] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $08 constant PWR_RET8                       \ [0x08] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $09 constant PWR_RET9                       \ [0x09] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0a constant PWR_RET10                      \ [0x0a] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0b constant PWR_RET11                      \ [0x0b] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0c constant PWR_RET12                      \ [0x0c] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0d constant PWR_RET13                      \ [0x0d] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0e constant PWR_RET14                      \ [0x0e] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0f constant PWR_RET15                      \ [0x0f] Port B Standby GPIO retention active Access can be secured by GPIOB SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_IORETENRC_DEF
    \
    \ @brief PWR port C Standby IO retention enable register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $0d constant PWR_EN13                       \ [0x0d] Port C Standby GPIO retention enable Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0e constant PWR_EN14                       \ [0x0e] Port C Standby GPIO retention enable Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0f constant PWR_EN15                       \ [0x0f] Port C Standby GPIO retention enable Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_IORETRC_DEF
    \
    \ @brief PWR port C Standby IO retention status register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $0d constant PWR_RET13                      \ [0x0d] Port C Standby GPIO retention active Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0e constant PWR_RET14                      \ [0x0e] Port C Standby GPIO retention active Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
    $0f constant PWR_RET15                      \ [0x0f] Port C Standby GPIO retention active Access can be secured by GPIOC SECy. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_IORETENRH_DEF
    \
    \ @brief PWR port H Standby IO retention enable register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $03 constant PWR_EN3                        \ [0x03] Port H Standby GPIO retention enable Access can be secured by GPIOH SEC3. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_IORETRH_DEF
    \
    \ @brief PWR port H Standby IO retention status register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $03 constant PWR_RET3                       \ [0x03] Port H Standby GPIO retention active Access can be secured by GPIOH SEC3. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with PWR SPRIV or when non-secure with PWR NSPRIV.
  [then]


  [ifdef] PWR_PWR_RADIOSCR_DEF
    \
    \ @brief PWR 2.4 GHz RADIO status and control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant PWR_MODE                       \ [0x00 : 2] 2.4 GHz RADIO operating mode. 1x: 2.4 GHz RADIO active mode
    $02 constant PWR_PHYMODE                    \ [0x02] 2.4 GHz RADIO PHY operating mode
    $03 constant PWR_ENCMODE                    \ [0x03] 2.4 GHz RADIO encryption function operating mode
    $08 constant PWR_RFVDDHPA                   \ [0x08 : 5] 2.4 GHz RADIO VDDHPA control word. Bits [3:0] see Table 81: PA output power table format for definition. Bit [4] rf_event.
    $0f constant PWR_REGPARDYVDDRFPA            \ [0x0f] Ready bit for VsubDDHPA/sub voltage level when selecting VDDRFPA input. Note: REGPARDYVDDRFPA does not allow to detect correct VsubDDHPA/sub voltage level when request to lower the level.
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_PWR_CR1              \ PWR control register 1
  $04 constant PWR_PWR_CR2              \ PWR control register 2
  $08 constant PWR_PWR_CR3              \ PWR control register 3
  $0C constant PWR_PWR_VOSR             \ PWR voltage scaling register
  $10 constant PWR_PWR_SVMCR            \ PWR supply voltage monitoring control register
  $14 constant PWR_PWR_WUCR1            \ PWR wakeup control register 1
  $18 constant PWR_PWR_WUCR2            \ PWR wakeup control register 2
  $1C constant PWR_PWR_WUCR3            \ PWR wakeup control register 3
  $28 constant PWR_PWR_DBPR             \ PWR disable Backup domain register
  $30 constant PWR_PWR_SECCFGR          \ PWR security configuration register
  $34 constant PWR_PWR_PRIVCFGR         \ PWR privilege control register
  $38 constant PWR_PWR_SR               \ PWR status register
  $3C constant PWR_PWR_SVMSR            \ PWR supply voltage monitoring status register
  $44 constant PWR_PWR_WUSR             \ PWR wakeup status register
  $48 constant PWR_PWR_WUSCR            \ PWR wakeup status clear register
  $50 constant PWR_PWR_IORETENRA        \ PWR port A Standby IO retention enable register
  $54 constant PWR_PWR_IORETRA          \ PWR port A Standby IO retention status register
  $58 constant PWR_PWR_IORETENRB        \ PWR port B Standby IO retention enable register
  $5C constant PWR_PWR_IORETRB          \ PWR port B Standby IO retention status register
  $60 constant PWR_PWR_IORETENRC        \ PWR port C Standby IO retention enable register
  $64 constant PWR_PWR_IORETRC          \ PWR port C Standby IO retention status register
  $88 constant PWR_PWR_IORETENRH        \ PWR port H Standby IO retention enable register
  $8C constant PWR_PWR_IORETRH          \ PWR port H Standby IO retention status register
  $100 constant PWR_PWR_RADIOSCR        \ PWR 2.4 GHz RADIO status and control register

: PWR_DEF ; [then]
