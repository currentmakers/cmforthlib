\
\ @file rtc.fs
\ @brief RTC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RTC_DEF

  [ifdef] RTC_RTC_TR_DEF
    \
    \ @brief The RTC_TR is the calendar time shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page1830 and Reading the calendar on page1831. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] SU
    $04 constant RTC_ST                         \ [0x04 : 3] ST
    $08 constant RTC_MNU                        \ [0x08 : 4] MNU
    $0c constant RTC_MNT                        \ [0x0c : 3] MNT
    $10 constant RTC_HU                         \ [0x10 : 4] HU
    $14 constant RTC_HT                         \ [0x14 : 2] HT
    $16 constant RTC_PM                         \ [0x16] PM
  [then]


  [ifdef] RTC_RTC_DR_DEF
    \
    \ @brief The RTC_DR is the calendar date shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page1830 and Reading the calendar on page1831. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x04
    \ Reset value: 0x00002101
    \
    $00 constant RTC_DU                         \ [0x00 : 4] DU
    $04 constant RTC_DT                         \ [0x04 : 2] DT
    $08 constant RTC_MU                         \ [0x08 : 4] MU
    $0c constant RTC_MT                         \ [0x0c] MT
    $0d constant RTC_WDU                        \ [0x0d : 3] WDU
    $10 constant RTC_YU                         \ [0x10 : 4] YU
    $14 constant RTC_YT                         \ [0x14 : 4] YT
  [then]


  [ifdef] RTC_RTC_SSR_DEF
    \
    \ @brief RTC sub second register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] SS
  [then]


  [ifdef] RTC_RTC_ICSR_DEF
    \
    \ @brief This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be globally protected, or each bit of this register can be individually protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $00 constant RTC_ALRAWF                     \ [0x00] ALRAWF
    $01 constant RTC_ALRBWF                     \ [0x01] ALRBWF
    $02 constant RTC_WUTWF                      \ [0x02] WUTWF
    $03 constant RTC_SHPF                       \ [0x03] SHPF
    $04 constant RTC_INITS                      \ [0x04] INITS
    $05 constant RTC_RSF                        \ [0x05] RSF
    $06 constant RTC_INITF                      \ [0x06] INITF
    $07 constant RTC_INIT                       \ [0x07] INIT
    $10 constant RTC_RECALPF                    \ [0x10] RECALPF
  [then]


  [ifdef] RTC_RTC_PRER_DEF
    \
    \ @brief This register must be written in initialization mode only. The initialization must be performed in two separate write accesses. Refer to Calendar initialization and configuration on page1830. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x10
    \ Reset value: 0x007F00FF
    \
    $00 constant RTC_PREDIV_S                   \ [0x00 : 15] PREDIV_S
    $10 constant RTC_PREDIV_A                   \ [0x10 : 7] PREDIV_A
  [then]


  [ifdef] RTC_RTC_WUTR_DEF
    \
    \ @brief This register can be written only when WUTWF is set to 1 in RTC_ICSR. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant RTC_WUT                        \ [0x00 : 16] WUT
  [then]


  [ifdef] RTC_RTC_CR_DEF
    \
    \ @brief This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be globally protected, or each bit of this register can be individually protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RTC_WUCKSEL                    \ [0x00 : 3] WUCKSEL
    $03 constant RTC_TSEDGE                     \ [0x03] TSEDGE
    $04 constant RTC_REFCKON                    \ [0x04] REFCKON
    $05 constant RTC_BYPSHAD                    \ [0x05] BYPSHAD
    $06 constant RTC_FMT                        \ [0x06] FMT
    $08 constant RTC_ALRAE                      \ [0x08] ALRAE
    $09 constant RTC_ALRBE                      \ [0x09] ALRBE
    $0a constant RTC_WUTE                       \ [0x0a] WUTE
    $0b constant RTC_TSE                        \ [0x0b] TSE
    $0c constant RTC_ALRAIE                     \ [0x0c] ALRAIE
    $0d constant RTC_ALRBIE                     \ [0x0d] ALRBIE
    $0e constant RTC_WUTIE                      \ [0x0e] WUTIE
    $0f constant RTC_TSIE                       \ [0x0f] TSIE
    $10 constant RTC_ADD1H                      \ [0x10] ADD1H
    $11 constant RTC_SUB1H                      \ [0x11] SUB1H
    $12 constant RTC_BKP                        \ [0x12] BKP
    $13 constant RTC_COSEL                      \ [0x13] COSEL
    $14 constant RTC_POL                        \ [0x14] POL
    $15 constant RTC_OSEL                       \ [0x15 : 2] OSEL
    $17 constant RTC_COE                        \ [0x17] COE
    $18 constant RTC_ITSE                       \ [0x18] ITSE
    $19 constant RTC_TAMPTS                     \ [0x19] TAMPTS
    $1a constant RTC_TAMPOE                     \ [0x1a] TAMPOE
    $1d constant RTC_TAMPALRM_PU                \ [0x1d] TAMPALRM_PU
    $1e constant RTC_TAMPALRM_TYPE              \ [0x1e] TAMPALRM_TYPE
    $1f constant RTC_OUT2EN                     \ [0x1f] OUT2EN
  [then]


  [ifdef] RTC_RTC_SMCR_DEF
    \
    \ @brief This register can be written only when the APB access is secure.
    \ Address offset: 0x20
    \ Reset value: 0x0000E00F
    \
    $00 constant RTC_ALRADPROT                  \ [0x00] ALRADPROT
    $01 constant RTC_ALRBDPROT                  \ [0x01] ALRBDPROT
    $02 constant RTC_WUTDPROT                   \ [0x02] WUTDPROT
    $03 constant RTC_TSDPROT                    \ [0x03] TSDPROT
    $0d constant RTC_CALDPROT                   \ [0x0d] CALDPROT
    $0e constant RTC_INITDPROT                  \ [0x0e] INITDPROT
    $0f constant RTC_DECPROT                    \ [0x0f] DECPROT
  [then]


  [ifdef] RTC_RTC_WPR_DEF
    \
    \ @brief RTC write protection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RTC_KEY                        \ [0x00 : 8] KEY
  [then]


  [ifdef] RTC_RTC_CALR_DEF
    \
    \ @brief This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALM                       \ [0x00 : 9] CALM
    $0d constant RTC_CALW16                     \ [0x0d] CALW16
    $0e constant RTC_CALW8                      \ [0x0e] CALW8
    $0f constant RTC_CALP                       \ [0x0f] CALP
  [then]


  [ifdef] RTC_RTC_SHIFTR_DEF
    \
    \ @brief This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SUBFS                      \ [0x00 : 15] SUBFS
    $1f constant RTC_ADD1S                      \ [0x1f] ADD1S
  [then]


  [ifdef] RTC_RTC_TSTR_DEF
    \
    \ @brief The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] SU
    $04 constant RTC_ST                         \ [0x04 : 3] ST
    $08 constant RTC_MNU                        \ [0x08 : 4] MNU
    $0c constant RTC_MNT                        \ [0x0c : 3] MNT
    $10 constant RTC_HU                         \ [0x10 : 4] HU
    $14 constant RTC_HT                         \ [0x14 : 2] HT
    $16 constant RTC_PM                         \ [0x16] PM
  [then]


  [ifdef] RTC_RTC_TSDR_DEF
    \
    \ @brief The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RTC_DU                         \ [0x00 : 4] DU
    $04 constant RTC_DT                         \ [0x04 : 2] DT
    $08 constant RTC_MU                         \ [0x08 : 4] MU
    $0c constant RTC_MT                         \ [0x0c] MT
    $0d constant RTC_WDU                        \ [0x0d : 3] WDU
  [then]


  [ifdef] RTC_RTC_TSSSR_DEF
    \
    \ @brief The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when the TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] SS
  [then]


  [ifdef] RTC_RTC_ALRMAR_DEF
    \
    \ @brief This register can be written only when ALRAWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] SU
    $04 constant RTC_ST                         \ [0x04 : 3] ST
    $07 constant RTC_MSK1                       \ [0x07] MSK1
    $08 constant RTC_MNU                        \ [0x08 : 4] MNU
    $0c constant RTC_MNT                        \ [0x0c : 3] MNT
    $0f constant RTC_MSK2                       \ [0x0f] MSK2
    $10 constant RTC_HU                         \ [0x10 : 4] HU
    $14 constant RTC_HT                         \ [0x14 : 2] HT
    $16 constant RTC_PM                         \ [0x16] PM
    $17 constant RTC_MSK3                       \ [0x17] MSK3
    $18 constant RTC_DU                         \ [0x18 : 4] DU
    $1c constant RTC_DT                         \ [0x1c : 2] DT
    $1e constant RTC_WDSEL                      \ [0x1e] WDSEL
    $1f constant RTC_MSK4                       \ [0x1f] MSK4
  [then]


  [ifdef] RTC_RTC_ALRMASSR_DEF
    \
    \ @brief This register can be written only when ALRAWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] SS
    $18 constant RTC_MASKSS                     \ [0x18 : 4] MASKSS
  [then]


  [ifdef] RTC_RTC_ALRMBR_DEF
    \
    \ @brief This register can be written only when ALRBWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] SU
    $04 constant RTC_ST                         \ [0x04 : 3] ST
    $07 constant RTC_MSK1                       \ [0x07] MSK1
    $08 constant RTC_MNU                        \ [0x08 : 4] MNU
    $0c constant RTC_MNT                        \ [0x0c : 3] MNT
    $0f constant RTC_MSK2                       \ [0x0f] MSK2
    $10 constant RTC_HU                         \ [0x10 : 4] HU
    $14 constant RTC_HT                         \ [0x14 : 2] HT
    $16 constant RTC_PM                         \ [0x16] PM
    $17 constant RTC_MSK3                       \ [0x17] MSK3
    $18 constant RTC_DU                         \ [0x18 : 4] DU
    $1c constant RTC_DT                         \ [0x1c : 2] DT
    $1e constant RTC_WDSEL                      \ [0x1e] WDSEL
    $1f constant RTC_MSK4                       \ [0x1f] MSK4
  [then]


  [ifdef] RTC_RTC_ALRMBSSR_DEF
    \
    \ @brief This register can be written only when ALRBE is reset in RTC_CR register, or in initialization mode. This register is write protected.The write access procedure is described in Section: RTC register write protection. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] SS
    $18 constant RTC_MASKSS                     \ [0x18 : 4] MASKSS
  [then]


  [ifdef] RTC_RTC_SR_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAF                      \ [0x00] ALRAF
    $01 constant RTC_ALRBF                      \ [0x01] ALRBF
    $02 constant RTC_WUTF                       \ [0x02] WUTF
    $03 constant RTC_TSF                        \ [0x03] TSF
    $04 constant RTC_TSOVF                      \ [0x04] TSOVF
    $05 constant RTC_ITSF                       \ [0x05] ITSF
  [then]


  [ifdef] RTC_RTC_MISR_DEF
    \
    \ @brief RTC non-secure masked interrupt status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAMF                     \ [0x00] ALRAMF
    $01 constant RTC_ALRBMF                     \ [0x01] ALRBMF
    $02 constant RTC_WUTMF                      \ [0x02] WUTMF
    $03 constant RTC_TSMF                       \ [0x03] TSMF
    $04 constant RTC_TSOVMF                     \ [0x04] TSOVMF
    $05 constant RTC_ITSMF                      \ [0x05] ITSMF
  [then]


  [ifdef] RTC_RTC_SMISR_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAMF                     \ [0x00] ALRAMF
    $01 constant RTC_ALRBMF                     \ [0x01] ALRBMF
    $02 constant RTC_WUTMF                      \ [0x02] WUTMF
    $03 constant RTC_TSMF                       \ [0x03] TSMF
    $04 constant RTC_TSOVMF                     \ [0x04] TSOVMF
    $05 constant RTC_ITSMF                      \ [0x05] ITSMF
  [then]


  [ifdef] RTC_RTC_SCR_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALRAF                     \ [0x00] CALRAF
    $01 constant RTC_CALRBF                     \ [0x01] CALRBF
    $02 constant RTC_CWUTF                      \ [0x02] CWUTF
    $03 constant RTC_CTSF                       \ [0x03] CTSF
    $04 constant RTC_CTSOVF                     \ [0x04] CTSOVF
    $05 constant RTC_CITSF                      \ [0x05] CITSF
  [then]


  [ifdef] RTC_RTC_CFGR_DEF
    \
    \ @brief RTC configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RTC_OUT2_RMP                   \ [0x00] OUT2_RMP
    $01 constant RTC_LSCOEN                     \ [0x01 : 2] LSCOEN
  [then]


  [ifdef] RTC_RTC_HWCFGR_DEF
    \
    \ @brief RTC hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x01031111
    \
    $00 constant RTC_ALARMB                     \ [0x00 : 4] ALARMB
    $04 constant RTC_WAKEUP                     \ [0x04 : 4] WAKEUP
    $08 constant RTC_SMOOTH_CALIB               \ [0x08 : 4] SMOOTH_CALIB
    $0c constant RTC_TIMESTAMP                  \ [0x0c : 4] TIMESTAMP
    $10 constant RTC_OPTIONREG_OUT              \ [0x10 : 8] OPTIONREG_OUT
    $18 constant RTC_TRUST_ZONE                 \ [0x18 : 4] TRUST_ZONE
  [then]


  [ifdef] RTC_RTC_VERR_DEF
    \
    \ @brief RTC version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant RTC_MINREV                     \ [0x00 : 4] MINREV
    $04 constant RTC_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] RTC_RTC_IPIDR_DEF
    \
    \ @brief RTC identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00120033
    \
    $00 constant RTC_ID                         \ [0x00 : 32] ID
  [then]


  [ifdef] RTC_RTC_SIDR_DEF
    \
    \ @brief RTC size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant RTC_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief RTC
  \
  $00 constant RTC_RTC_TR               \ The RTC_TR is the calendar time shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page1830 and Reading the calendar on page1831. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $04 constant RTC_RTC_DR               \ The RTC_DR is the calendar date shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page1830 and Reading the calendar on page1831. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $08 constant RTC_RTC_SSR              \ RTC sub second register
  $0C constant RTC_RTC_ICSR             \ This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be globally protected, or each bit of this register can be individually protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $10 constant RTC_RTC_PRER             \ This register must be written in initialization mode only. The initialization must be performed in two separate write accesses. Refer to Calendar initialization and configuration on page1830. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $14 constant RTC_RTC_WUTR             \ This register can be written only when WUTWF is set to 1 in RTC_ICSR. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $18 constant RTC_RTC_CR               \ This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be globally protected, or each bit of this register can be individually protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $20 constant RTC_RTC_SMCR             \ This register can be written only when the APB access is secure.
  $24 constant RTC_RTC_WPR              \ RTC write protection register
  $28 constant RTC_RTC_CALR             \ This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $2C constant RTC_RTC_SHIFTR           \ This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $30 constant RTC_RTC_TSTR             \ The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $34 constant RTC_RTC_TSDR             \ The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $38 constant RTC_RTC_TSSSR            \ The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when the TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $40 constant RTC_RTC_ALRMAR           \ This register can be written only when ALRAWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $44 constant RTC_RTC_ALRMASSR         \ This register can be written only when ALRAWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $48 constant RTC_RTC_ALRMBR           \ This register can be written only when ALRBWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $4C constant RTC_RTC_ALRMBSSR         \ This register can be written only when ALRBE is reset in RTC_CR register, or in initialization mode. This register is write protected.The write access procedure is described in Section: RTC register write protection. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $50 constant RTC_RTC_SR               \ This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $54 constant RTC_RTC_MISR             \ RTC non-secure masked interrupt status register
  $58 constant RTC_RTC_SMISR            \ This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $5C constant RTC_RTC_SCR              \ This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
  $60 constant RTC_RTC_CFGR             \ RTC configuration register
  $3F0 constant RTC_RTC_HWCFGR          \ RTC hardware configuration register
  $3F4 constant RTC_RTC_VERR            \ RTC version register
  $3F8 constant RTC_RTC_IPIDR           \ RTC identification register
  $3FC constant RTC_RTC_SIDR            \ RTC size identification register

: RTC_DEF ; [then]
