\
\ @file hrtim_common.fs
\ @brief High Resolution Timer: Common functions
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HRTIM_COMMON_DEF

  [ifdef] HRTIM_COMMON_CR1_DEF
    \
    \ @brief Control Register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_MUDIS             \ [0x00] Master Update Disable
    $01 constant HRTIM_COMMON_TAUDIS            \ [0x01] Timer A Update Disable
    $02 constant HRTIM_COMMON_TBUDIS            \ [0x02] Timer B Update Disable
    $03 constant HRTIM_COMMON_TCUDIS            \ [0x03] Timer C Update Disable
    $04 constant HRTIM_COMMON_TDUDIS            \ [0x04] Timer D Update Disable
    $05 constant HRTIM_COMMON_TEUDIS            \ [0x05] Timer E Update Disable
    $10 constant HRTIM_COMMON_AD1USRC           \ [0x10 : 3] ADC Trigger 1 Update Source
    $13 constant HRTIM_COMMON_AD2USRC           \ [0x13 : 3] ADC Trigger 2 Update Source
    $16 constant HRTIM_COMMON_AD3USRC           \ [0x16 : 3] ADC Trigger 3 Update Source
    $19 constant HRTIM_COMMON_AD4USRC           \ [0x19 : 3] ADC Trigger 4 Update Source
  [then]


  [ifdef] HRTIM_COMMON_CR2_DEF
    \
    \ @brief Control Register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_MSWU              \ [0x00] Master Timer Software update
    $01 constant HRTIM_COMMON_TASWU             \ [0x01] Timer A Software update
    $02 constant HRTIM_COMMON_TBSWU             \ [0x02] Timer B Software Update
    $03 constant HRTIM_COMMON_TCSWU             \ [0x03] Timer C Software Update
    $04 constant HRTIM_COMMON_TDSWU             \ [0x04] Timer D Software Update
    $05 constant HRTIM_COMMON_TESWU             \ [0x05] Timer E Software Update
    $08 constant HRTIM_COMMON_MRST              \ [0x08] Master Counter software reset
    $09 constant HRTIM_COMMON_TARST             \ [0x09] Timer A counter software reset
    $0a constant HRTIM_COMMON_TBRST             \ [0x0a] Timer B counter software reset
    $0b constant HRTIM_COMMON_TCRST             \ [0x0b] Timer C counter software reset
    $0c constant HRTIM_COMMON_TDRST             \ [0x0c] Timer D counter software reset
    $0d constant HRTIM_COMMON_TERST             \ [0x0d] Timer E counter software reset
  [then]


  [ifdef] HRTIM_COMMON_ISR_DEF
    \
    \ @brief Interrupt Status Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_FLT1              \ [0x00] Fault 1 Interrupt Flag
    $01 constant HRTIM_COMMON_FLT2              \ [0x01] Fault 2 Interrupt Flag
    $02 constant HRTIM_COMMON_FLT3              \ [0x02] Fault 3 Interrupt Flag
    $03 constant HRTIM_COMMON_FLT4              \ [0x03] Fault 4 Interrupt Flag
    $04 constant HRTIM_COMMON_FLT5              \ [0x04] Fault 5 Interrupt Flag
    $05 constant HRTIM_COMMON_SYSFLT            \ [0x05] System Fault Interrupt Flag
    $10 constant HRTIM_COMMON_DLLRDY            \ [0x10] DLL Ready Interrupt Flag
    $11 constant HRTIM_COMMON_BMPER             \ [0x11] Burst mode Period Interrupt Flag
  [then]


  [ifdef] HRTIM_COMMON_ICR_DEF
    \
    \ @brief Interrupt Clear Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_FLT1C             \ [0x00] Fault 1 Interrupt Flag Clear
    $01 constant HRTIM_COMMON_FLT2C             \ [0x01] Fault 2 Interrupt Flag Clear
    $02 constant HRTIM_COMMON_FLT3C             \ [0x02] Fault 3 Interrupt Flag Clear
    $03 constant HRTIM_COMMON_FLT4C             \ [0x03] Fault 4 Interrupt Flag Clear
    $04 constant HRTIM_COMMON_FLT5C             \ [0x04] Fault 5 Interrupt Flag Clear
    $05 constant HRTIM_COMMON_SYSFLTC           \ [0x05] System Fault Interrupt Flag Clear
    $10 constant HRTIM_COMMON_DLLRDYC           \ [0x10] DLL Ready Interrupt flag Clear
    $11 constant HRTIM_COMMON_BMPERC            \ [0x11] Burst mode period flag Clear
  [then]


  [ifdef] HRTIM_COMMON_IER_DEF
    \
    \ @brief Interrupt Enable Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_FLT1IE            \ [0x00] Fault 1 Interrupt Enable
    $01 constant HRTIM_COMMON_FLT2IE            \ [0x01] Fault 2 Interrupt Enable
    $02 constant HRTIM_COMMON_FLT3IE            \ [0x02] Fault 3 Interrupt Enable
    $03 constant HRTIM_COMMON_FLT4IE            \ [0x03] Fault 4 Interrupt Enable
    $04 constant HRTIM_COMMON_FLT5IE            \ [0x04] Fault 5 Interrupt Enable
    $05 constant HRTIM_COMMON_SYSFLTE           \ [0x05] System Fault Interrupt Enable
    $10 constant HRTIM_COMMON_DLLRDYIE          \ [0x10] DLL Ready Interrupt Enable
    $11 constant HRTIM_COMMON_BMPERIE           \ [0x11] Burst mode period Interrupt Enable
  [then]


  [ifdef] HRTIM_COMMON_OENR_DEF
    \
    \ @brief Output Enable Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_TA1OEN            \ [0x00] Timer A Output 1 Enable
    $01 constant HRTIM_COMMON_TA2OEN            \ [0x01] Timer A Output 2 Enable
    $02 constant HRTIM_COMMON_TB1OEN            \ [0x02] Timer B Output 1 Enable
    $03 constant HRTIM_COMMON_TB2OEN            \ [0x03] Timer B Output 2 Enable
    $04 constant HRTIM_COMMON_TC1OEN            \ [0x04] Timer C Output 1 Enable
    $05 constant HRTIM_COMMON_TC2OEN            \ [0x05] Timer C Output 2 Enable
    $06 constant HRTIM_COMMON_TD1OEN            \ [0x06] Timer D Output 1 Enable
    $07 constant HRTIM_COMMON_TD2OEN            \ [0x07] Timer D Output 2 Enable
    $08 constant HRTIM_COMMON_TE1OEN            \ [0x08] Timer E Output 1 Enable
    $09 constant HRTIM_COMMON_TE2OEN            \ [0x09] Timer E Output 2 Enable
  [then]


  [ifdef] HRTIM_COMMON_ODISR_DEF
    \
    \ @brief DISR
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_TA1ODIS           \ [0x00] TA1ODIS
    $01 constant HRTIM_COMMON_TA2ODIS           \ [0x01] TA2ODIS
    $02 constant HRTIM_COMMON_TB1ODIS           \ [0x02] TB1ODIS
    $03 constant HRTIM_COMMON_TB2ODIS           \ [0x03] TB2ODIS
    $04 constant HRTIM_COMMON_TC1ODIS           \ [0x04] TC1ODIS
    $05 constant HRTIM_COMMON_TC2ODIS           \ [0x05] TC2ODIS
    $06 constant HRTIM_COMMON_TD1ODIS           \ [0x06] TD1ODIS
    $07 constant HRTIM_COMMON_TD2ODIS           \ [0x07] TD2ODIS
    $08 constant HRTIM_COMMON_TE1ODIS           \ [0x08] TE1ODIS
    $09 constant HRTIM_COMMON_TE2ODIS           \ [0x09] TE2ODIS
  [then]


  [ifdef] HRTIM_COMMON_ODSR_DEF
    \
    \ @brief Output Disable Status Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_TA1ODS            \ [0x00] Timer A Output 1 disable status
    $01 constant HRTIM_COMMON_TA2ODS            \ [0x01] Timer A Output 2 disable status
    $02 constant HRTIM_COMMON_TB1ODS            \ [0x02] Timer B Output 1 disable status
    $03 constant HRTIM_COMMON_TB2ODS            \ [0x03] Timer B Output 2 disable status
    $04 constant HRTIM_COMMON_TC1ODS            \ [0x04] Timer C Output 1 disable status
    $05 constant HRTIM_COMMON_TC2ODS            \ [0x05] Timer C Output 2 disable status
    $06 constant HRTIM_COMMON_TD1ODS            \ [0x06] Timer D Output 1 disable status
    $07 constant HRTIM_COMMON_TD2ODS            \ [0x07] Timer D Output 2 disable status
    $08 constant HRTIM_COMMON_TE1ODS            \ [0x08] Timer E Output 1 disable status
    $09 constant HRTIM_COMMON_TE2ODS            \ [0x09] Timer E Output 2 disable status
  [then]


  [ifdef] HRTIM_COMMON_BMCR_DEF
    \
    \ @brief Burst Mode Control Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_BME               \ [0x00] Burst Mode enable
    $01 constant HRTIM_COMMON_BMOM              \ [0x01] Burst Mode operating mode
    $02 constant HRTIM_COMMON_BMCLK             \ [0x02 : 4] Burst Mode Clock source
    $06 constant HRTIM_COMMON_BMPRSC            \ [0x06 : 4] Burst Mode Prescaler
    $0a constant HRTIM_COMMON_BMPREN            \ [0x0a] Burst Mode Preload Enable
    $10 constant HRTIM_COMMON_MTBM              \ [0x10] Master Timer Burst Mode
    $11 constant HRTIM_COMMON_TABM              \ [0x11] Timer A Burst Mode
    $12 constant HRTIM_COMMON_TBBM              \ [0x12] Timer B Burst Mode
    $13 constant HRTIM_COMMON_TCBM              \ [0x13] Timer C Burst Mode
    $14 constant HRTIM_COMMON_TDBM              \ [0x14] Timer D Burst Mode
    $15 constant HRTIM_COMMON_TEBM              \ [0x15] Timer E Burst Mode
    $1f constant HRTIM_COMMON_BMSTAT            \ [0x1f] Burst Mode Status
  [then]


  [ifdef] HRTIM_COMMON_BMTRGR_DEF
    \
    \ @brief BMTRGR
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_SW                \ [0x00] SW
    $01 constant HRTIM_COMMON_MSTRST            \ [0x01] MSTRST
    $02 constant HRTIM_COMMON_MSTREP            \ [0x02] MSTREP
    $03 constant HRTIM_COMMON_MSTCMP1           \ [0x03] MSTCMP1
    $04 constant HRTIM_COMMON_MSTCMP2           \ [0x04] MSTCMP2
    $05 constant HRTIM_COMMON_MSTCMP3           \ [0x05] MSTCMP3
    $06 constant HRTIM_COMMON_MSTCMP4           \ [0x06] MSTCMP4
    $07 constant HRTIM_COMMON_TARST             \ [0x07] TARST
    $08 constant HRTIM_COMMON_TAREP             \ [0x08] TAREP
    $09 constant HRTIM_COMMON_TACMP1            \ [0x09] TACMP1
    $0a constant HRTIM_COMMON_TACMP2            \ [0x0a] TACMP2
    $0b constant HRTIM_COMMON_TBRST             \ [0x0b] TBRST
    $0c constant HRTIM_COMMON_TBREP             \ [0x0c] TBREP
    $0d constant HRTIM_COMMON_TBCMP1            \ [0x0d] TBCMP1
    $0e constant HRTIM_COMMON_TBCMP2            \ [0x0e] TBCMP2
    $0f constant HRTIM_COMMON_TCRST             \ [0x0f] TCRST
    $10 constant HRTIM_COMMON_TCREP             \ [0x10] TCREP
    $11 constant HRTIM_COMMON_TCCMP1            \ [0x11] TCCMP1
    $12 constant HRTIM_COMMON_TCCMP2            \ [0x12] TCCMP2
    $13 constant HRTIM_COMMON_TDRST             \ [0x13] TDRST
    $14 constant HRTIM_COMMON_TDREP             \ [0x14] TDREP
    $15 constant HRTIM_COMMON_TDCMP1            \ [0x15] TDCMP1
    $16 constant HRTIM_COMMON_TDCMP2            \ [0x16] TDCMP2
    $17 constant HRTIM_COMMON_TERST             \ [0x17] TERST
    $18 constant HRTIM_COMMON_TEREP             \ [0x18] TEREP
    $19 constant HRTIM_COMMON_TECMP1            \ [0x19] TECMP1
    $1a constant HRTIM_COMMON_TECMP2            \ [0x1a] TECMP2
    $1b constant HRTIM_COMMON_TAEEV7            \ [0x1b] TAEEV7
    $1c constant HRTIM_COMMON_TDEEV8            \ [0x1c] TDEEV8
    $1d constant HRTIM_COMMON_EEV7              \ [0x1d] EEV7
    $1e constant HRTIM_COMMON_EEV8              \ [0x1e] EEV8
    $1f constant HRTIM_COMMON_OCHPEV            \ [0x1f] OCHPEV
  [then]


  [ifdef] HRTIM_COMMON_BMCMPR_DEF
    \
    \ @brief BMCMPR
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_BMCMP             \ [0x00 : 16] BMCMP
  [then]


  [ifdef] HRTIM_COMMON_BMPER_DEF
    \
    \ @brief Burst Mode Period Register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_BMPER             \ [0x00 : 16] Burst mode Period
  [then]


  [ifdef] HRTIM_COMMON_EECR1_DEF
    \
    \ @brief Timer External Event Control Register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_EE1SRC            \ [0x00 : 2] External Event 1 Source
    $02 constant HRTIM_COMMON_EE1POL            \ [0x02] External Event 1 Polarity
    $03 constant HRTIM_COMMON_EE1SNS            \ [0x03 : 2] External Event 1 Sensitivity
    $05 constant HRTIM_COMMON_EE1FAST           \ [0x05] External Event 1 Fast mode
    $06 constant HRTIM_COMMON_EE2SRC            \ [0x06 : 2] External Event 2 Source
    $08 constant HRTIM_COMMON_EE2POL            \ [0x08] External Event 2 Polarity
    $09 constant HRTIM_COMMON_EE2SNS            \ [0x09 : 2] External Event 2 Sensitivity
    $0b constant HRTIM_COMMON_EE2FAST           \ [0x0b] External Event 2 Fast mode
    $0c constant HRTIM_COMMON_EE3SRC            \ [0x0c : 2] External Event 3 Source
    $0e constant HRTIM_COMMON_EE3POL            \ [0x0e] External Event 3 Polarity
    $0f constant HRTIM_COMMON_EE3SNS            \ [0x0f : 2] External Event 3 Sensitivity
    $11 constant HRTIM_COMMON_EE3FAST           \ [0x11] External Event 3 Fast mode
    $12 constant HRTIM_COMMON_EE4SRC            \ [0x12 : 2] External Event 4 Source
    $14 constant HRTIM_COMMON_EE4POL            \ [0x14] External Event 4 Polarity
    $15 constant HRTIM_COMMON_EE4SNS            \ [0x15 : 2] External Event 4 Sensitivity
    $17 constant HRTIM_COMMON_EE4FAST           \ [0x17] External Event 4 Fast mode
    $18 constant HRTIM_COMMON_EE5SRC            \ [0x18 : 2] External Event 5 Source
    $1a constant HRTIM_COMMON_EE5POL            \ [0x1a] External Event 5 Polarity
    $1b constant HRTIM_COMMON_EE5SNS            \ [0x1b : 2] External Event 5 Sensitivity
    $1d constant HRTIM_COMMON_EE5FAST           \ [0x1d] External Event 5 Fast mode
  [then]


  [ifdef] HRTIM_COMMON_EECR2_DEF
    \
    \ @brief Timer External Event Control Register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_EE6SRC            \ [0x00 : 2] External Event 6 Source
    $02 constant HRTIM_COMMON_EE6POL            \ [0x02] External Event 6 Polarity
    $03 constant HRTIM_COMMON_EE6SNS            \ [0x03 : 2] External Event 6 Sensitivity
    $06 constant HRTIM_COMMON_EE7SRC            \ [0x06 : 2] External Event 7 Source
    $08 constant HRTIM_COMMON_EE7POL            \ [0x08] External Event 7 Polarity
    $09 constant HRTIM_COMMON_EE7SNS            \ [0x09 : 2] External Event 7 Sensitivity
    $0c constant HRTIM_COMMON_EE8SRC            \ [0x0c : 2] External Event 8 Source
    $0e constant HRTIM_COMMON_EE8POL            \ [0x0e] External Event 8 Polarity
    $0f constant HRTIM_COMMON_EE8SNS            \ [0x0f : 2] External Event 8 Sensitivity
    $12 constant HRTIM_COMMON_EE9SRC            \ [0x12 : 2] External Event 9 Source
    $14 constant HRTIM_COMMON_EE9POL            \ [0x14] External Event 9 Polarity
    $15 constant HRTIM_COMMON_EE9SNS            \ [0x15 : 2] External Event 9 Sensitivity
    $18 constant HRTIM_COMMON_EE10SRC           \ [0x18 : 2] External Event 10 Source
    $1a constant HRTIM_COMMON_EE10POL           \ [0x1a] External Event 10 Polarity
    $1b constant HRTIM_COMMON_EE10SNS           \ [0x1b : 2] External Event 10 Sensitivity
  [then]


  [ifdef] HRTIM_COMMON_EECR3_DEF
    \
    \ @brief Timer External Event Control Register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_EE6F              \ [0x00 : 4] EE6F
    $06 constant HRTIM_COMMON_EE7F              \ [0x06 : 4] EE7F
    $0c constant HRTIM_COMMON_EE8F              \ [0x0c : 4] EE8F
    $12 constant HRTIM_COMMON_EE9F              \ [0x12 : 4] EE9F
    $18 constant HRTIM_COMMON_EE10F             \ [0x18 : 4] EE10F
    $1e constant HRTIM_COMMON_EEVSD             \ [0x1e : 2] EEVSD
  [then]


  [ifdef] HRTIM_COMMON_ADC1R_DEF
    \
    \ @brief ADC Trigger 1 Register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_AD1MC1            \ [0x00] ADC trigger 1 on Master Compare 1
    $01 constant HRTIM_COMMON_AD1MC2            \ [0x01] ADC trigger 1 on Master Compare 2
    $02 constant HRTIM_COMMON_AD1MC3            \ [0x02] ADC trigger 1 on Master Compare 3
    $03 constant HRTIM_COMMON_AD1MC4            \ [0x03] ADC trigger 1 on Master Compare 4
    $04 constant HRTIM_COMMON_AD1MPER           \ [0x04] ADC trigger 1 on Master Period
    $05 constant HRTIM_COMMON_AD1EEV1           \ [0x05] ADC trigger 1 on External Event 1
    $06 constant HRTIM_COMMON_AD1EEV2           \ [0x06] ADC trigger 1 on External Event 2
    $07 constant HRTIM_COMMON_AD1EEV3           \ [0x07] ADC trigger 1 on External Event 3
    $08 constant HRTIM_COMMON_AD1EEV4           \ [0x08] ADC trigger 1 on External Event 4
    $09 constant HRTIM_COMMON_AD1EEV5           \ [0x09] ADC trigger 1 on External Event 5
    $0a constant HRTIM_COMMON_AD1TAC2           \ [0x0a] ADC trigger 1 on Timer A compare 2
    $0b constant HRTIM_COMMON_AD1TAC3           \ [0x0b] ADC trigger 1 on Timer A compare 3
    $0c constant HRTIM_COMMON_AD1TAC4           \ [0x0c] ADC trigger 1 on Timer A compare 4
    $0d constant HRTIM_COMMON_AD1TAPER          \ [0x0d] ADC trigger 1 on Timer A Period
    $0e constant HRTIM_COMMON_AD1TARST          \ [0x0e] ADC trigger 1 on Timer A Reset
    $0f constant HRTIM_COMMON_AD1TBC2           \ [0x0f] ADC trigger 1 on Timer B compare 2
    $10 constant HRTIM_COMMON_AD1TBC3           \ [0x10] ADC trigger 1 on Timer B compare 3
    $11 constant HRTIM_COMMON_AD1TBC4           \ [0x11] ADC trigger 1 on Timer B compare 4
    $12 constant HRTIM_COMMON_AD1TBPER          \ [0x12] ADC trigger 1 on Timer B Period
    $13 constant HRTIM_COMMON_AD1TBRST          \ [0x13] ADC trigger 1 on Timer B Reset
    $14 constant HRTIM_COMMON_AD1TCC2           \ [0x14] ADC trigger 1 on Timer C compare 2
    $15 constant HRTIM_COMMON_AD1TCC3           \ [0x15] ADC trigger 1 on Timer C compare 3
    $16 constant HRTIM_COMMON_AD1TCC4           \ [0x16] ADC trigger 1 on Timer C compare 4
    $17 constant HRTIM_COMMON_AD1TCPER          \ [0x17] ADC trigger 1 on Timer C Period
    $18 constant HRTIM_COMMON_AD1TDC2           \ [0x18] ADC trigger 1 on Timer D compare 2
    $19 constant HRTIM_COMMON_AD1TDC3           \ [0x19] ADC trigger 1 on Timer D compare 3
    $1a constant HRTIM_COMMON_AD1TDC4           \ [0x1a] ADC trigger 1 on Timer D compare 4
    $1b constant HRTIM_COMMON_AD1TDPER          \ [0x1b] ADC trigger 1 on Timer D Period
    $1c constant HRTIM_COMMON_AD1TEC2           \ [0x1c] ADC trigger 1 on Timer E compare 2
    $1d constant HRTIM_COMMON_AD1TEC3           \ [0x1d] ADC trigger 1 on Timer E compare 3
    $1e constant HRTIM_COMMON_AD1TEC4           \ [0x1e] ADC trigger 1 on Timer E compare 4
    $1f constant HRTIM_COMMON_AD1TEPER          \ [0x1f] ADC trigger 1 on Timer E Period
  [then]


  [ifdef] HRTIM_COMMON_ADC2R_DEF
    \
    \ @brief ADC Trigger 2 Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_AD2MC1            \ [0x00] ADC trigger 2 on Master Compare 1
    $01 constant HRTIM_COMMON_AD2MC2            \ [0x01] ADC trigger 2 on Master Compare 2
    $02 constant HRTIM_COMMON_AD2MC3            \ [0x02] ADC trigger 2 on Master Compare 3
    $03 constant HRTIM_COMMON_AD2MC4            \ [0x03] ADC trigger 2 on Master Compare 4
    $04 constant HRTIM_COMMON_AD2MPER           \ [0x04] ADC trigger 2 on Master Period
    $05 constant HRTIM_COMMON_AD2EEV6           \ [0x05] ADC trigger 2 on External Event 6
    $06 constant HRTIM_COMMON_AD2EEV7           \ [0x06] ADC trigger 2 on External Event 7
    $07 constant HRTIM_COMMON_AD2EEV8           \ [0x07] ADC trigger 2 on External Event 8
    $08 constant HRTIM_COMMON_AD2EEV9           \ [0x08] ADC trigger 2 on External Event 9
    $09 constant HRTIM_COMMON_AD2EEV10          \ [0x09] ADC trigger 2 on External Event 10
    $0a constant HRTIM_COMMON_AD2TAC2           \ [0x0a] ADC trigger 2 on Timer A compare 2
    $0b constant HRTIM_COMMON_AD2TAC3           \ [0x0b] ADC trigger 2 on Timer A compare 3
    $0c constant HRTIM_COMMON_AD2TAC4           \ [0x0c] ADC trigger 2 on Timer A compare 4
    $0d constant HRTIM_COMMON_AD2TAPER          \ [0x0d] ADC trigger 2 on Timer A Period
    $0e constant HRTIM_COMMON_AD2TBC2           \ [0x0e] ADC trigger 2 on Timer B compare 2
    $0f constant HRTIM_COMMON_AD2TBC3           \ [0x0f] ADC trigger 2 on Timer B compare 3
    $10 constant HRTIM_COMMON_AD2TBC4           \ [0x10] ADC trigger 2 on Timer B compare 4
    $11 constant HRTIM_COMMON_AD2TBPER          \ [0x11] ADC trigger 2 on Timer B Period
    $12 constant HRTIM_COMMON_AD2TCC2           \ [0x12] ADC trigger 2 on Timer C compare 2
    $13 constant HRTIM_COMMON_AD2TCC3           \ [0x13] ADC trigger 2 on Timer C compare 3
    $14 constant HRTIM_COMMON_AD2TCC4           \ [0x14] ADC trigger 2 on Timer C compare 4
    $15 constant HRTIM_COMMON_AD2TCPER          \ [0x15] ADC trigger 2 on Timer C Period
    $16 constant HRTIM_COMMON_AD2TCRST          \ [0x16] ADC trigger 2 on Timer C Reset
    $17 constant HRTIM_COMMON_AD2TDC2           \ [0x17] ADC trigger 2 on Timer D compare 2
    $18 constant HRTIM_COMMON_AD2TDC3           \ [0x18] ADC trigger 2 on Timer D compare 3
    $19 constant HRTIM_COMMON_AD2TDC4           \ [0x19] ADC trigger 2 on Timer D compare 4
    $1a constant HRTIM_COMMON_AD2TDPER          \ [0x1a] ADC trigger 2 on Timer D Period
    $1b constant HRTIM_COMMON_AD2TDRST          \ [0x1b] ADC trigger 2 on Timer D Reset
    $1c constant HRTIM_COMMON_AD2TEC2           \ [0x1c] ADC trigger 2 on Timer E compare 2
    $1d constant HRTIM_COMMON_AD2TEC3           \ [0x1d] ADC trigger 2 on Timer E compare 3
    $1e constant HRTIM_COMMON_AD2TEC4           \ [0x1e] ADC trigger 2 on Timer E compare 4
    $1f constant HRTIM_COMMON_AD2TERST          \ [0x1f] ADC trigger 2 on Timer E Reset
  [then]


  [ifdef] HRTIM_COMMON_ADC3R_DEF
    \
    \ @brief ADC Trigger 3 Register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_AD1MC1            \ [0x00] AD1MC1
    $01 constant HRTIM_COMMON_AD1MC2            \ [0x01] AD1MC2
    $02 constant HRTIM_COMMON_AD1MC3            \ [0x02] AD1MC3
    $03 constant HRTIM_COMMON_AD1MC4            \ [0x03] AD1MC4
    $04 constant HRTIM_COMMON_AD1MPER           \ [0x04] AD1MPER
    $05 constant HRTIM_COMMON_AD1EEV1           \ [0x05] AD1EEV1
    $06 constant HRTIM_COMMON_AD1EEV2           \ [0x06] AD1EEV2
    $07 constant HRTIM_COMMON_AD1EEV3           \ [0x07] AD1EEV3
    $08 constant HRTIM_COMMON_AD1EEV4           \ [0x08] AD1EEV4
    $09 constant HRTIM_COMMON_AD1EEV5           \ [0x09] AD1EEV5
    $0a constant HRTIM_COMMON_AD1TAC2           \ [0x0a] AD1TAC2
    $0b constant HRTIM_COMMON_AD1TAC3           \ [0x0b] AD1TAC3
    $0c constant HRTIM_COMMON_AD1TAC4           \ [0x0c] AD1TAC4
    $0d constant HRTIM_COMMON_AD1TAPER          \ [0x0d] AD1TAPER
    $0e constant HRTIM_COMMON_AD1TARST          \ [0x0e] AD1TARST
    $0f constant HRTIM_COMMON_AD1TBC2           \ [0x0f] AD1TBC2
    $10 constant HRTIM_COMMON_AD1TBC3           \ [0x10] AD1TBC3
    $11 constant HRTIM_COMMON_AD1TBC4           \ [0x11] AD1TBC4
    $12 constant HRTIM_COMMON_AD1TBPER          \ [0x12] AD1TBPER
    $13 constant HRTIM_COMMON_AD1TBRST          \ [0x13] AD1TBRST
    $14 constant HRTIM_COMMON_AD1TCC2           \ [0x14] AD1TCC2
    $15 constant HRTIM_COMMON_AD1TCC3           \ [0x15] AD1TCC3
    $16 constant HRTIM_COMMON_AD1TCC4           \ [0x16] AD1TCC4
    $17 constant HRTIM_COMMON_AD1TCPER          \ [0x17] AD1TCPER
    $18 constant HRTIM_COMMON_AD1TDC2           \ [0x18] AD1TDC2
    $19 constant HRTIM_COMMON_AD1TDC3           \ [0x19] AD1TDC3
    $1a constant HRTIM_COMMON_AD1TDC4           \ [0x1a] AD1TDC4
    $1b constant HRTIM_COMMON_AD1TDPER          \ [0x1b] AD1TDPER
    $1c constant HRTIM_COMMON_AD1TEC2           \ [0x1c] AD1TEC2
    $1d constant HRTIM_COMMON_AD1TEC3           \ [0x1d] AD1TEC3
    $1e constant HRTIM_COMMON_AD1TEC4           \ [0x1e] AD1TEC4
    $1f constant HRTIM_COMMON_AD1TEPER          \ [0x1f] AD1TEPER
  [then]


  [ifdef] HRTIM_COMMON_ADC4R_DEF
    \
    \ @brief ADC Trigger 4 Register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_AD2MC1            \ [0x00] AD2MC1
    $01 constant HRTIM_COMMON_AD2MC2            \ [0x01] AD2MC2
    $02 constant HRTIM_COMMON_AD2MC3            \ [0x02] AD2MC3
    $03 constant HRTIM_COMMON_AD2MC4            \ [0x03] AD2MC4
    $04 constant HRTIM_COMMON_AD2MPER           \ [0x04] AD2MPER
    $05 constant HRTIM_COMMON_AD2EEV6           \ [0x05] AD2EEV6
    $06 constant HRTIM_COMMON_AD2EEV7           \ [0x06] AD2EEV7
    $07 constant HRTIM_COMMON_AD2EEV8           \ [0x07] AD2EEV8
    $08 constant HRTIM_COMMON_AD2EEV9           \ [0x08] AD2EEV9
    $09 constant HRTIM_COMMON_AD2EEV10          \ [0x09] AD2EEV10
    $0a constant HRTIM_COMMON_AD2TAC2           \ [0x0a] AD2TAC2
    $0b constant HRTIM_COMMON_AD2TAC3           \ [0x0b] AD2TAC3
    $0c constant HRTIM_COMMON_AD2TAC4           \ [0x0c] AD2TAC4
    $0d constant HRTIM_COMMON_AD2TAPER          \ [0x0d] AD2TAPER
    $0e constant HRTIM_COMMON_AD2TBC2           \ [0x0e] AD2TBC2
    $0f constant HRTIM_COMMON_AD2TBC3           \ [0x0f] AD2TBC3
    $10 constant HRTIM_COMMON_AD2TBC4           \ [0x10] AD2TBC4
    $11 constant HRTIM_COMMON_AD2TBPER          \ [0x11] AD2TBPER
    $12 constant HRTIM_COMMON_AD2TCC2           \ [0x12] AD2TCC2
    $13 constant HRTIM_COMMON_AD2TCC3           \ [0x13] AD2TCC3
    $14 constant HRTIM_COMMON_AD2TCC4           \ [0x14] AD2TCC4
    $15 constant HRTIM_COMMON_AD2TCPER          \ [0x15] AD2TCPER
    $16 constant HRTIM_COMMON_AD2TCRST          \ [0x16] AD2TCRST
    $17 constant HRTIM_COMMON_AD2TDC2           \ [0x17] AD2TDC2
    $18 constant HRTIM_COMMON_AD2TDC3           \ [0x18] AD2TDC3
    $19 constant HRTIM_COMMON_AD2TDC4           \ [0x19] AD2TDC4
    $1a constant HRTIM_COMMON_AD2TDPER          \ [0x1a] AD2TDPER
    $1b constant HRTIM_COMMON_AD2TDRST          \ [0x1b] AD2TDRST
    $1c constant HRTIM_COMMON_AD2TEC2           \ [0x1c] AD2TEC2
    $1d constant HRTIM_COMMON_AD2TEC3           \ [0x1d] AD2TEC3
    $1e constant HRTIM_COMMON_AD2TEC4           \ [0x1e] AD2TEC4
    $1f constant HRTIM_COMMON_AD2TERST          \ [0x1f] AD2TERST
  [then]


  [ifdef] HRTIM_COMMON_DLLCR_DEF
    \
    \ @brief DLL Control Register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_CAL               \ [0x00] DLL Calibration Start
    $01 constant HRTIM_COMMON_CALEN             \ [0x01] DLL Calibration Enable
    $02 constant HRTIM_COMMON_CALRTE            \ [0x02 : 2] DLL Calibration rate
  [then]


  [ifdef] HRTIM_COMMON_FLTINR1_DEF
    \
    \ @brief HRTIM Fault Input Register 1
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_FLT1E             \ [0x00] FLT1E
    $01 constant HRTIM_COMMON_FLT1P             \ [0x01] FLT1P
    $02 constant HRTIM_COMMON_FLT1SRC           \ [0x02] FLT1SRC
    $03 constant HRTIM_COMMON_FLT1F             \ [0x03 : 4] FLT1F
    $07 constant HRTIM_COMMON_FLT1LCK           \ [0x07] FLT1LCK
    $08 constant HRTIM_COMMON_FLT2E             \ [0x08] FLT2E
    $09 constant HRTIM_COMMON_FLT2P             \ [0x09] FLT2P
    $0a constant HRTIM_COMMON_FLT2SRC           \ [0x0a] FLT2SRC
    $0b constant HRTIM_COMMON_FLT2F             \ [0x0b : 4] FLT2F
    $0f constant HRTIM_COMMON_FLT2LCK           \ [0x0f] FLT2LCK
    $10 constant HRTIM_COMMON_FLT3E             \ [0x10] FLT3E
    $11 constant HRTIM_COMMON_FLT3P             \ [0x11] FLT3P
    $12 constant HRTIM_COMMON_FLT3SRC           \ [0x12] FLT3SRC
    $13 constant HRTIM_COMMON_FLT3F             \ [0x13 : 4] FLT3F
    $17 constant HRTIM_COMMON_FLT3LCK           \ [0x17] FLT3LCK
    $18 constant HRTIM_COMMON_FLT4E             \ [0x18] FLT4E
    $19 constant HRTIM_COMMON_FLT4P             \ [0x19] FLT4P
    $1a constant HRTIM_COMMON_FLT4SRC           \ [0x1a] FLT4SRC
    $1b constant HRTIM_COMMON_FLT4F             \ [0x1b : 4] FLT4F
    $1f constant HRTIM_COMMON_FLT4LCK           \ [0x1f] FLT4LCK
  [then]


  [ifdef] HRTIM_COMMON_FLTINR2_DEF
    \
    \ @brief HRTIM Fault Input Register 2
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_FLT5E             \ [0x00] FLT5E
    $01 constant HRTIM_COMMON_FLT5P             \ [0x01] FLT5P
    $02 constant HRTIM_COMMON_FLT5SRC           \ [0x02] FLT5SRC
    $03 constant HRTIM_COMMON_FLT5F             \ [0x03 : 4] FLT5F
    $07 constant HRTIM_COMMON_FLT5LCK           \ [0x07] FLT5LCK
    $18 constant HRTIM_COMMON_FLTSD             \ [0x18 : 2] FLTSD
  [then]


  [ifdef] HRTIM_COMMON_BDMUPDR_DEF
    \
    \ @brief BDMUPDR
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_MCR               \ [0x00] MCR
    $01 constant HRTIM_COMMON_MICR              \ [0x01] MICR
    $02 constant HRTIM_COMMON_MDIER             \ [0x02] MDIER
    $03 constant HRTIM_COMMON_MCNT              \ [0x03] MCNT
    $04 constant HRTIM_COMMON_MPER              \ [0x04] MPER
    $05 constant HRTIM_COMMON_MREP              \ [0x05] MREP
    $06 constant HRTIM_COMMON_MCMP1             \ [0x06] MCMP1
    $07 constant HRTIM_COMMON_MCMP2             \ [0x07] MCMP2
    $08 constant HRTIM_COMMON_MCMP3             \ [0x08] MCMP3
    $09 constant HRTIM_COMMON_MCMP4             \ [0x09] MCMP4
  [then]


  [ifdef] HRTIM_COMMON_BDTAUPR_DEF
    \
    \ @brief Burst DMA Timerx update Register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_TIMxCR            \ [0x00] HRTIM_TIMxCR register update enable
    $01 constant HRTIM_COMMON_TIMxICR           \ [0x01] HRTIM_TIMxICR register update enable
    $02 constant HRTIM_COMMON_TIMxDIER          \ [0x02] HRTIM_TIMxDIER register update enable
    $03 constant HRTIM_COMMON_TIMxCNT           \ [0x03] HRTIM_CNTxR register update enable
    $04 constant HRTIM_COMMON_TIMxPER           \ [0x04] HRTIM_PERxR register update enable
    $05 constant HRTIM_COMMON_TIMxREP           \ [0x05] HRTIM_REPxR register update enable
    $06 constant HRTIM_COMMON_TIMxCMP1          \ [0x06] HRTIM_CMP1xR register update enable
    $07 constant HRTIM_COMMON_TIMxCMP2          \ [0x07] HRTIM_CMP2xR register update enable
    $08 constant HRTIM_COMMON_TIMxCMP3          \ [0x08] HRTIM_CMP3xR register update enable
    $09 constant HRTIM_COMMON_TIMxCMP4          \ [0x09] HRTIM_CMP4xR register update enable
    $0a constant HRTIM_COMMON_TIMx_DTxR         \ [0x0a] HRTIM_DTxR register update enable
    $0b constant HRTIM_COMMON_TIMxSET1R         \ [0x0b] HRTIM_SET1xR register update enable
    $0c constant HRTIM_COMMON_TIMxRST1R         \ [0x0c] HRTIM_RST1xR register update enable
    $0d constant HRTIM_COMMON_TIMxSET2R         \ [0x0d] HRTIM_SET2xR register update enable
    $0e constant HRTIM_COMMON_TIMxRST2R         \ [0x0e] HRTIM_RST2xR register update enable
    $0f constant HRTIM_COMMON_TIMxEEFR1         \ [0x0f] HRTIM_EEFxR1 register update enable
    $10 constant HRTIM_COMMON_TIMxEEFR2         \ [0x10] HRTIM_EEFxR2 register update enable
    $11 constant HRTIM_COMMON_TIMxRSTR          \ [0x11] HRTIM_RSTxR register update enable
    $12 constant HRTIM_COMMON_TIMxCHPR          \ [0x12] HRTIM_CHPxR register update enable
    $13 constant HRTIM_COMMON_TIMxOUTR          \ [0x13] HRTIM_OUTxR register update enable
    $14 constant HRTIM_COMMON_TIMxFLTR          \ [0x14] HRTIM_FLTxR register update enable
  [then]


  [ifdef] HRTIM_COMMON_BDTBUPR_DEF
    \
    \ @brief Burst DMA Timerx update Register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_TIMxCR            \ [0x00] HRTIM_TIMxCR register update enable
    $01 constant HRTIM_COMMON_TIMxICR           \ [0x01] HRTIM_TIMxICR register update enable
    $02 constant HRTIM_COMMON_TIMxDIER          \ [0x02] HRTIM_TIMxDIER register update enable
    $03 constant HRTIM_COMMON_TIMxCNT           \ [0x03] HRTIM_CNTxR register update enable
    $04 constant HRTIM_COMMON_TIMxPER           \ [0x04] HRTIM_PERxR register update enable
    $05 constant HRTIM_COMMON_TIMxREP           \ [0x05] HRTIM_REPxR register update enable
    $06 constant HRTIM_COMMON_TIMxCMP1          \ [0x06] HRTIM_CMP1xR register update enable
    $07 constant HRTIM_COMMON_TIMxCMP2          \ [0x07] HRTIM_CMP2xR register update enable
    $08 constant HRTIM_COMMON_TIMxCMP3          \ [0x08] HRTIM_CMP3xR register update enable
    $09 constant HRTIM_COMMON_TIMxCMP4          \ [0x09] HRTIM_CMP4xR register update enable
    $0a constant HRTIM_COMMON_TIMx_DTxR         \ [0x0a] HRTIM_DTxR register update enable
    $0b constant HRTIM_COMMON_TIMxSET1R         \ [0x0b] HRTIM_SET1xR register update enable
    $0c constant HRTIM_COMMON_TIMxRST1R         \ [0x0c] HRTIM_RST1xR register update enable
    $0d constant HRTIM_COMMON_TIMxSET2R         \ [0x0d] HRTIM_SET2xR register update enable
    $0e constant HRTIM_COMMON_TIMxRST2R         \ [0x0e] HRTIM_RST2xR register update enable
    $0f constant HRTIM_COMMON_TIMxEEFR1         \ [0x0f] HRTIM_EEFxR1 register update enable
    $10 constant HRTIM_COMMON_TIMxEEFR2         \ [0x10] HRTIM_EEFxR2 register update enable
    $11 constant HRTIM_COMMON_TIMxRSTR          \ [0x11] HRTIM_RSTxR register update enable
    $12 constant HRTIM_COMMON_TIMxCHPR          \ [0x12] HRTIM_CHPxR register update enable
    $13 constant HRTIM_COMMON_TIMxOUTR          \ [0x13] HRTIM_OUTxR register update enable
    $14 constant HRTIM_COMMON_TIMxFLTR          \ [0x14] HRTIM_FLTxR register update enable
  [then]


  [ifdef] HRTIM_COMMON_BDTCUPR_DEF
    \
    \ @brief Burst DMA Timerx update Register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_TIMxCR            \ [0x00] HRTIM_TIMxCR register update enable
    $01 constant HRTIM_COMMON_TIMxICR           \ [0x01] HRTIM_TIMxICR register update enable
    $02 constant HRTIM_COMMON_TIMxDIER          \ [0x02] HRTIM_TIMxDIER register update enable
    $03 constant HRTIM_COMMON_TIMxCNT           \ [0x03] HRTIM_CNTxR register update enable
    $04 constant HRTIM_COMMON_TIMxPER           \ [0x04] HRTIM_PERxR register update enable
    $05 constant HRTIM_COMMON_TIMxREP           \ [0x05] HRTIM_REPxR register update enable
    $06 constant HRTIM_COMMON_TIMxCMP1          \ [0x06] HRTIM_CMP1xR register update enable
    $07 constant HRTIM_COMMON_TIMxCMP2          \ [0x07] HRTIM_CMP2xR register update enable
    $08 constant HRTIM_COMMON_TIMxCMP3          \ [0x08] HRTIM_CMP3xR register update enable
    $09 constant HRTIM_COMMON_TIMxCMP4          \ [0x09] HRTIM_CMP4xR register update enable
    $0a constant HRTIM_COMMON_TIMx_DTxR         \ [0x0a] HRTIM_DTxR register update enable
    $0b constant HRTIM_COMMON_TIMxSET1R         \ [0x0b] HRTIM_SET1xR register update enable
    $0c constant HRTIM_COMMON_TIMxRST1R         \ [0x0c] HRTIM_RST1xR register update enable
    $0d constant HRTIM_COMMON_TIMxSET2R         \ [0x0d] HRTIM_SET2xR register update enable
    $0e constant HRTIM_COMMON_TIMxRST2R         \ [0x0e] HRTIM_RST2xR register update enable
    $0f constant HRTIM_COMMON_TIMxEEFR1         \ [0x0f] HRTIM_EEFxR1 register update enable
    $10 constant HRTIM_COMMON_TIMxEEFR2         \ [0x10] HRTIM_EEFxR2 register update enable
    $11 constant HRTIM_COMMON_TIMxRSTR          \ [0x11] HRTIM_RSTxR register update enable
    $12 constant HRTIM_COMMON_TIMxCHPR          \ [0x12] HRTIM_CHPxR register update enable
    $13 constant HRTIM_COMMON_TIMxOUTR          \ [0x13] HRTIM_OUTxR register update enable
    $14 constant HRTIM_COMMON_TIMxFLTR          \ [0x14] HRTIM_FLTxR register update enable
  [then]


  [ifdef] HRTIM_COMMON_BDTDUPR_DEF
    \
    \ @brief Burst DMA Timerx update Register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_TIMxCR            \ [0x00] HRTIM_TIMxCR register update enable
    $01 constant HRTIM_COMMON_TIMxICR           \ [0x01] HRTIM_TIMxICR register update enable
    $02 constant HRTIM_COMMON_TIMxDIER          \ [0x02] HRTIM_TIMxDIER register update enable
    $03 constant HRTIM_COMMON_TIMxCNT           \ [0x03] HRTIM_CNTxR register update enable
    $04 constant HRTIM_COMMON_TIMxPER           \ [0x04] HRTIM_PERxR register update enable
    $05 constant HRTIM_COMMON_TIMxREP           \ [0x05] HRTIM_REPxR register update enable
    $06 constant HRTIM_COMMON_TIMxCMP1          \ [0x06] HRTIM_CMP1xR register update enable
    $07 constant HRTIM_COMMON_TIMxCMP2          \ [0x07] HRTIM_CMP2xR register update enable
    $08 constant HRTIM_COMMON_TIMxCMP3          \ [0x08] HRTIM_CMP3xR register update enable
    $09 constant HRTIM_COMMON_TIMxCMP4          \ [0x09] HRTIM_CMP4xR register update enable
    $0a constant HRTIM_COMMON_TIMx_DTxR         \ [0x0a] HRTIM_DTxR register update enable
    $0b constant HRTIM_COMMON_TIMxSET1R         \ [0x0b] HRTIM_SET1xR register update enable
    $0c constant HRTIM_COMMON_TIMxRST1R         \ [0x0c] HRTIM_RST1xR register update enable
    $0d constant HRTIM_COMMON_TIMxSET2R         \ [0x0d] HRTIM_SET2xR register update enable
    $0e constant HRTIM_COMMON_TIMxRST2R         \ [0x0e] HRTIM_RST2xR register update enable
    $0f constant HRTIM_COMMON_TIMxEEFR1         \ [0x0f] HRTIM_EEFxR1 register update enable
    $10 constant HRTIM_COMMON_TIMxEEFR2         \ [0x10] HRTIM_EEFxR2 register update enable
    $11 constant HRTIM_COMMON_TIMxRSTR          \ [0x11] HRTIM_RSTxR register update enable
    $12 constant HRTIM_COMMON_TIMxCHPR          \ [0x12] HRTIM_CHPxR register update enable
    $13 constant HRTIM_COMMON_TIMxOUTR          \ [0x13] HRTIM_OUTxR register update enable
    $14 constant HRTIM_COMMON_TIMxFLTR          \ [0x14] HRTIM_FLTxR register update enable
  [then]


  [ifdef] HRTIM_COMMON_BDTEUPR_DEF
    \
    \ @brief Burst DMA Timerx update Register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_TIMxCR            \ [0x00] HRTIM_TIMxCR register update enable
    $01 constant HRTIM_COMMON_TIMxICR           \ [0x01] HRTIM_TIMxICR register update enable
    $02 constant HRTIM_COMMON_TIMxDIER          \ [0x02] HRTIM_TIMxDIER register update enable
    $03 constant HRTIM_COMMON_TIMxCNT           \ [0x03] HRTIM_CNTxR register update enable
    $04 constant HRTIM_COMMON_TIMxPER           \ [0x04] HRTIM_PERxR register update enable
    $05 constant HRTIM_COMMON_TIMxREP           \ [0x05] HRTIM_REPxR register update enable
    $06 constant HRTIM_COMMON_TIMxCMP1          \ [0x06] HRTIM_CMP1xR register update enable
    $07 constant HRTIM_COMMON_TIMxCMP2          \ [0x07] HRTIM_CMP2xR register update enable
    $08 constant HRTIM_COMMON_TIMxCMP3          \ [0x08] HRTIM_CMP3xR register update enable
    $09 constant HRTIM_COMMON_TIMxCMP4          \ [0x09] HRTIM_CMP4xR register update enable
    $0a constant HRTIM_COMMON_TIMx_DTxR         \ [0x0a] HRTIM_DTxR register update enable
    $0b constant HRTIM_COMMON_TIMxSET1R         \ [0x0b] HRTIM_SET1xR register update enable
    $0c constant HRTIM_COMMON_TIMxRST1R         \ [0x0c] HRTIM_RST1xR register update enable
    $0d constant HRTIM_COMMON_TIMxSET2R         \ [0x0d] HRTIM_SET2xR register update enable
    $0e constant HRTIM_COMMON_TIMxRST2R         \ [0x0e] HRTIM_RST2xR register update enable
    $0f constant HRTIM_COMMON_TIMxEEFR1         \ [0x0f] HRTIM_EEFxR1 register update enable
    $10 constant HRTIM_COMMON_TIMxEEFR2         \ [0x10] HRTIM_EEFxR2 register update enable
    $11 constant HRTIM_COMMON_TIMxRSTR          \ [0x11] HRTIM_RSTxR register update enable
    $12 constant HRTIM_COMMON_TIMxCHPR          \ [0x12] HRTIM_CHPxR register update enable
    $13 constant HRTIM_COMMON_TIMxOUTR          \ [0x13] HRTIM_OUTxR register update enable
    $14 constant HRTIM_COMMON_TIMxFLTR          \ [0x14] HRTIM_FLTxR register update enable
  [then]


  [ifdef] HRTIM_COMMON_BDMADR_DEF
    \
    \ @brief Burst DMA Data Register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_COMMON_BDMADR            \ [0x00 : 32] Burst DMA Data register
  [then]

  \
  \ @brief High Resolution Timer: Common functions
  \
  $00 constant HRTIM_COMMON_CR1         \ Control Register 1
  $04 constant HRTIM_COMMON_CR2         \ Control Register 2
  $08 constant HRTIM_COMMON_ISR         \ Interrupt Status Register
  $0C constant HRTIM_COMMON_ICR         \ Interrupt Clear Register
  $10 constant HRTIM_COMMON_IER         \ Interrupt Enable Register
  $14 constant HRTIM_COMMON_OENR        \ Output Enable Register
  $18 constant HRTIM_COMMON_ODISR       \ DISR
  $1C constant HRTIM_COMMON_ODSR        \ Output Disable Status Register
  $20 constant HRTIM_COMMON_BMCR        \ Burst Mode Control Register
  $24 constant HRTIM_COMMON_BMTRGR      \ BMTRGR
  $28 constant HRTIM_COMMON_BMCMPR      \ BMCMPR
  $2C constant HRTIM_COMMON_BMPER       \ Burst Mode Period Register
  $30 constant HRTIM_COMMON_EECR1       \ Timer External Event Control Register 1
  $34 constant HRTIM_COMMON_EECR2       \ Timer External Event Control Register 2
  $38 constant HRTIM_COMMON_EECR3       \ Timer External Event Control Register 3
  $3C constant HRTIM_COMMON_ADC1R       \ ADC Trigger 1 Register
  $40 constant HRTIM_COMMON_ADC2R       \ ADC Trigger 2 Register
  $44 constant HRTIM_COMMON_ADC3R       \ ADC Trigger 3 Register
  $48 constant HRTIM_COMMON_ADC4R       \ ADC Trigger 4 Register
  $4C constant HRTIM_COMMON_DLLCR       \ DLL Control Register
  $50 constant HRTIM_COMMON_FLTINR1     \ HRTIM Fault Input Register 1
  $54 constant HRTIM_COMMON_FLTINR2     \ HRTIM Fault Input Register 2
  $58 constant HRTIM_COMMON_BDMUPDR     \ BDMUPDR
  $5C constant HRTIM_COMMON_BDTAUPR     \ Burst DMA Timerx update Register
  $60 constant HRTIM_COMMON_BDTBUPR     \ Burst DMA Timerx update Register
  $64 constant HRTIM_COMMON_BDTCUPR     \ Burst DMA Timerx update Register
  $68 constant HRTIM_COMMON_BDTDUPR     \ Burst DMA Timerx update Register
  $6C constant HRTIM_COMMON_BDTEUPR     \ Burst DMA Timerx update Register
  $70 constant HRTIM_COMMON_BDMADR      \ Burst DMA Data Register

: HRTIM_COMMON_DEF ; [then]
