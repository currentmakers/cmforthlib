\
\ @file dts.fs
\ @brief Digital temperature sensor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DTS_DEF

  [ifdef] DTS_DTS_PVTREG_LOCKR_DEF
    \
    \ @brief DTS PVT register lock register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DTS_LOCK                       \ [0x00 : 32] PVT software lock register
  [then]


  [ifdef] DTS_DTS_PVTLOCK_SR_DEF
    \
    \ @brief DTS PVT lock status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SW_LOCK_STATUS             \ [0x00] Software lock input status
    $01 constant DTS_HW_LOCK_STATUS             \ [0x01] Hardware lock input status
  [then]


  [ifdef] DTS_DTS_PVTTMR_CR_DEF
    \
    \ @brief DTS PVT timer control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TMR_DELAY                  \ [0x00 : 16] Timer delay
    $10 constant DTS_TMR_RUN                    \ [0x10] Timer count enable bit
  [then]


  [ifdef] DTS_DTS_PVTTMR_SR_DEF
    \
    \ @brief DTS PVT timer status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TMR_BUSY                   \ [0x00] Counter busy flag
    $01 constant DTS_TMR_DONE                   \ [0x01] Counter delay expiration flag
  [then]


  [ifdef] DTS_DTS_PVT_IER_DEF
    \
    \ @brief DTS PVT IRQ enable register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TMR_IRQ_ENABLE             \ [0x00] Timer IRQ source enable bit
    $01 constant DTS_TS_IRQ_ENABLE              \ [0x01] TS IRQ source enable bit
  [then]


  [ifdef] DTS_DTS_PVTIRQTRMASKR_DEF
    \
    \ @brief DTS PVT IRQ timer mask register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TMR_IRQ_MASK               \ [0x00] Timer IRQ source mask bit
  [then]


  [ifdef] DTS_DTS_TS_MR_DEF
    \
    \ @brief DTS PVT IRQ TS mask register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS0_IRQ_MASK               \ [0x00] TS0 IRQ source mask bit
    $01 constant DTS_TS1_IRQ_MASK               \ [0x01] TS1 IRQ source mask bit
  [then]


  [ifdef] DTS_DTS_PVTTR_SR_DEF
    \
    \ @brief DTS PVT IRQ timer status register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TMR_IRQ_STATUS             \ [0x00] Timer IRQ status bit after masking
  [then]


  [ifdef] DTS_DTS_TS_ISR_DEF
    \
    \ @brief DTS PVT IRQ TS status register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS0_IRQ_STATUS             \ [0x00] TS0 IRQ status bit after masking
    $01 constant DTS_TS1_IRQ_STATUS             \ [0x01] TS1 IRQ status bit after masking
  [then]


  [ifdef] DTS_DTS_PVTTMRRAW_ISR_DEF
    \
    \ @brief DTS PVT IRQ timer raw status register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TMR_IRQ_RAW_STATUS         \ [0x00] TMR IRQ status bit before masking
  [then]


  [ifdef] DTS_DTS_TSRAW_ISR_DEF
    \
    \ @brief DTS PVT IRQ TS raw status register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS0_IRQ_RAW_STATUS         \ [0x00] TS0 IRQ status bit before masking
    $01 constant DTS_TS1_IRQ_RAW_STATUS         \ [0x01] TS1 IRQ status bit before masking
  [then]


  [ifdef] DTS_DTS_TSCCLKSYNTHR_DEF
    \
    \ @brief DTS TSC clock synthesizer register
    \ Address offset: 0x80
    \ Reset value: 0x00010000
    \
    $00 constant DTS_CLK_SYNTH_LO               \ [0x00 : 8] Synthesized clk_ts low period
    $08 constant DTS_CLK_SYNTH_HI               \ [0x08 : 8] Synthesized clk_ts high period
    $10 constant DTS_CLK_SYNTH_HOLD             \ [0x10 : 4] SDA master-to-SDA slave output hold delay/SDA slave-to-SDA master input setup delay
    $18 constant DTS_CLK_SYTH_EN                \ [0x18] Synthesized clk_ts enable bit
  [then]


  [ifdef] DTS_DTS_TSCSDIFDISABLER_DEF
    \
    \ @brief DTS TSC SDIF interface disable register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS0_SDIF_DISABLE           \ [0x00] TS0 serial data interface (SDIF) disable bit
    $01 constant DTS_TS1_SDIF_DISABLE           \ [0x01] TS1 serial data interface (SDIF) disable bit
  [then]


  [ifdef] DTS_DTS_TSCSDIF_SR_DEF
    \
    \ @brief DTS TSC SDIF status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SDIF_BUSY                  \ [0x00] SDIF busy flag
    $01 constant DTS_SDIF_LOCK                  \ [0x01] SDIF locked flag
  [then]


  [ifdef] DTS_DTS_TSCSDIF_CR_DEF
    \
    \ @brief DTS TSC SDIF register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SDIF_WDATA                 \ [0x00 : 24] Serial interface write data
    $18 constant DTS_SDIF_ADDR                  \ [0x18 : 3] Serial interface register address
    $1b constant DTS_SDIF_WRN                   \ [0x1b] Serial interface write/no read control bit
    $1f constant DTS_SDIF_PROG                  \ [0x1f] Serial interface program request
  [then]


  [ifdef] DTS_DTS_TSCSDIFHALTR_DEF
    \
    \ @brief DTS TSC SDIF halt register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SDIF_STOP                  \ [0x00] Serial data interface (SDIF) stop
  [then]


  [ifdef] DTS_DTS_TSCSDIF_CFGR_DEF
    \
    \ @brief DTS TSC SDIF control register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SDIF_INHIBIT               \ [0x00 : 2] Serial data interface (SDIF) programming inhibit
  [then]


  [ifdef] DTS_DTS_TSCSMPL_CR_DEF
    \
    \ @brief DTS TSC sample control register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SMPL_CTR_DISABLE           \ [0x00] Sample counter disable bit
    $01 constant DTS_SMPL_CTR_HOLD              \ [0x01] Sample counter hold bit
    $02 constant DTS_SMPL_DISCARD               \ [0x02] Sample discard bit
  [then]


  [ifdef] DTS_DTS_TSCSDIFSMPLCLRR_DEF
    \
    \ @brief DTS TSC sample clear register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SMPL_CNTER_CLEAR           \ [0x00] Sample counter clear bit
  [then]


  [ifdef] DTS_DTS_TSCSMPLCNTR_DEF
    \
    \ @brief DTS TSC sample count register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SMPL_COUNT                 \ [0x00 : 16] Sample counter
  [then]


  [ifdef] DTS_DTS_TS0_IER_DEF
    \
    \ @brief DTS TS0 IRQ enable register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DTS_IRQ_EN_FAULT               \ [0x00] Fault IRQ enable bit
    $01 constant DTS_IRQ_EN_DONE                \ [0x01] Sample done IRQ enable bit
    $03 constant DTS_IRQ_EN_ALARMA              \ [0x03] Alarm A IRQ enable bit
    $04 constant DTS_IRQ_EN_ALARMB              \ [0x04] Alarm B IRQ enable bit
  [then]


  [ifdef] DTS_DTS_TS0_ISR_DEF
    \
    \ @brief DTS TS0 IRQ status register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant DTS_IRQ_STATUS_FAULT           \ [0x00] Fault IRQ status bit
    $01 constant DTS_IRQ_STATUS_DONE            \ [0x01] Sample done IRQ status bit
    $03 constant DTS_IRQ_STATUS_ALARMA          \ [0x03] Alarm A IRQ status bit
    $04 constant DTS_IRQ_STATUS_ALARMB          \ [0x04] Alarm B IRQ status bit
  [then]


  [ifdef] DTS_DTS_TS0_ICR_DEF
    \
    \ @brief DTS TS0 IRQ clear register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DTS_IRQ_CLEAR_FAULT            \ [0x00] Fault IRQ clear bit
    $01 constant DTS_IRQ_CLEAR_DONE             \ [0x01] Sample done IRQ clear bit
    $03 constant DTS_IRQ_CLEAR_ALARMA           \ [0x03] Alarm A IRQ clear bit
    $04 constant DTS_IRQ_CLEAR_ALARMB           \ [0x04] Alarm B IRQ clear bit
  [then]


  [ifdef] DTS_DTS_TS0IRQTESTR_DEF
    \
    \ @brief DTS TS0 IRQ test register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant DTS_IRQ_TEST_FAULT             \ [0x00] Fault IRQ test bit
    $01 constant DTS_IRQ_TEST_DONE              \ [0x01] Sample done IRQ test bit
    $03 constant DTS_IRQ_TEST_ALARMA            \ [0x03] Alarm A IRQ test bit
    $04 constant DTS_IRQ_TEST_ALARMB            \ [0x04] Alarm B IRQ test bit
  [then]


  [ifdef] DTS_DTS_TS0SDIFRDATAR_DEF
    \
    \ @brief DTS TS0 SDIF RDATA register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SDIF_RDATA                 \ [0x00 : 24] SDIF read data
  [then]


  [ifdef] DTS_DTS_TS0SDIFDONER_DEF
    \
    \ @brief DTS TS0 SDIF done register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SDIF_SMPL_DONE             \ [0x00] Sample done flag
  [then]


  [ifdef] DTS_DTS_TS0SDIFDATAR_DEF
    \
    \ @brief DTS TS0 SDIF data register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SAMPLE_DATA                \ [0x00 : 16] Sample data.
    $10 constant DTS_SAMPLE_TYPE                \ [0x10] TS sample type
    $11 constant DTS_SAMPLE_FAULT               \ [0x11] Sample fault
  [then]


  [ifdef] DTS_DTS_TS0ALARMA_CFGR_DEF
    \
    \ @brief DTS TS0 alarm A configuration register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant DTS_HYSTA_THRESH               \ [0x00 : 16] Alarm A hysteresis threshold
    $10 constant DTS_ALARMA_THRESH              \ [0x10 : 16] Alarm A threshold
  [then]


  [ifdef] DTS_DTS_TS0ALARMB_CFGR_DEF
    \
    \ @brief DTS TS0 alarm B configuration register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant DTS_HYSTB_THRESH               \ [0x00 : 16] Alarm B hysteresis threshold
    $10 constant DTS_ALARMB_THRESH              \ [0x10 : 16] Alarm B threshold
  [then]


  [ifdef] DTS_DTS_TS0HLSAMPLER_DEF
    \
    \ @brief DTS TS0 high/low sample register
    \ Address offset: 0xE8
    \ Reset value: 0x0000FFFF
    \
    $00 constant DTS_SMPL_LO                    \ [0x00 : 16] Lowest valid data sample value received
    $10 constant DTS_SMPL_HI                    \ [0x10 : 16] Highest valid data sample value received
  [then]


  [ifdef] DTS_DTS_TS0HILORESETR_DEF
    \
    \ @brief DTS TS0 high/low reset register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SMPL_LO_SET                \ [0x00] Sample Low Set
    $01 constant DTS_SMPL_HI_CLR                \ [0x01] Sample high clear 0
  [then]


  [ifdef] DTS_DTS_TS1_IER_DEF
    \
    \ @brief DTS TS1 IRQ enable register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DTS_IRQ_EN_FAULT               \ [0x00] Fault IRQ enable bit
    $01 constant DTS_IRQ_EN_DONE                \ [0x01] Sample done IRQ enable bit
    $03 constant DTS_IRQ_EN_ALARMA              \ [0x03] Alarm A IRQ enable bit
    $04 constant DTS_IRQ_EN_ALARMB              \ [0x04] Alarm B IRQ enable bit
  [then]


  [ifdef] DTS_DTS_TS1_ISR_DEF
    \
    \ @brief DTS TS1 IRQ status register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DTS_IRQ_STATUS_FAULT           \ [0x00] Fault IRQ status bit
    $01 constant DTS_IRQ_STATUS_DONE            \ [0x01] Sample done IRQ status bit
    $03 constant DTS_IRQ_STATUS_ALARMA          \ [0x03] Alarm A IRQ status bit
    $04 constant DTS_IRQ_STATUS_ALARMB          \ [0x04] Alarm B IRQ status bit
  [then]


  [ifdef] DTS_DTS_TS1_ICR_DEF
    \
    \ @brief DTS TS1 IRQ clear register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DTS_IRQ_CLEAR_FAULT            \ [0x00] Fault IRQ clear bit
    $01 constant DTS_IRQ_CLEAR_DONE             \ [0x01] Sample done IRQ clear bit
    $03 constant DTS_IRQ_CLEAR_ALARMA           \ [0x03] Alarm A IRQ clear bit
    $04 constant DTS_IRQ_CLEAR_ALARMB           \ [0x04] Alarm B IRQ clear bit
  [then]


  [ifdef] DTS_DTS_TS1IRQTESTR_DEF
    \
    \ @brief DTS TS1 IRQ test register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant DTS_IRQ_TEST_FAULT             \ [0x00] Fault IRQ test bit
    $01 constant DTS_IRQ_TEST_DONE              \ [0x01] Sample done IRQ test bit
    $03 constant DTS_IRQ_TEST_ALARMA            \ [0x03] Alarm A IRQ test bit
    $04 constant DTS_IRQ_TEST_ALARMB            \ [0x04] Alarm B IRQ test bit
  [then]


  [ifdef] DTS_DTS_TS1SDIFRDATAR_DEF
    \
    \ @brief DTS TS1 SDIF RDATA register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SDIF_RDATA                 \ [0x00 : 24] SDIF read data
  [then]


  [ifdef] DTS_DTS_TS1SDIFDONER_DEF
    \
    \ @brief DTS TS1 SDIF done register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SDIF_SMPL_DONE             \ [0x00] Sample done flag
  [then]


  [ifdef] DTS_DTS_TS1SDIFDATAR_DEF
    \
    \ @brief DTS TS1 SDIF data register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SAMPLE_DATA                \ [0x00 : 16] Sample data.
    $10 constant DTS_SAMPLE_TYPE                \ [0x10] TS sample type
    $11 constant DTS_SAMPLE_FAULT               \ [0x11] Sample fault
  [then]


  [ifdef] DTS_DTS_TS1ALARMA_CFGR_DEF
    \
    \ @brief DTS TS1 alarm A configuration register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant DTS_HYSTA_THRESH               \ [0x00 : 16] Alarm A hysteresis threshold
    $10 constant DTS_ALARMA_THRESH              \ [0x10 : 16] Alarm A threshold
  [then]


  [ifdef] DTS_DTS_TS1ALARMB_CFGR_DEF
    \
    \ @brief DTS TS1 alarm B configuration register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant DTS_HYSTB_THRESH               \ [0x00 : 16] Alarm B hysteresis threshold
    $10 constant DTS_ALARMB_THRESH              \ [0x10 : 16] Alarm B threshold
  [then]


  [ifdef] DTS_DTS_TS1HLSAMPLER_DEF
    \
    \ @brief DTS TS1 high/low sample register
    \ Address offset: 0x128
    \ Reset value: 0x0000FFFF
    \
    $00 constant DTS_SMPL_LO                    \ [0x00 : 16] Lowest valid data sample value received
    $10 constant DTS_SMPL_HI                    \ [0x10 : 16] Highest valid data sample value received
  [then]


  [ifdef] DTS_DTS_TS1HILORESETR_DEF
    \
    \ @brief DTS TS1 high/low reset register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant DTS_SMPL_LO_SET                \ [0x00] Sample Low Set
    $01 constant DTS_SMPL_HI_CLR                \ [0x01] Sample high clear 0
  [then]

  \
  \ @brief Digital temperature sensor
  \
  $10 constant DTS_DTS_PVTREG_LOCKR     \ DTS PVT register lock register
  $14 constant DTS_DTS_PVTLOCK_SR       \ DTS PVT lock status register
  $20 constant DTS_DTS_PVTTMR_CR        \ DTS PVT timer control register
  $24 constant DTS_DTS_PVTTMR_SR        \ DTS PVT timer status register
  $40 constant DTS_DTS_PVT_IER          \ DTS PVT IRQ enable register
  $50 constant DTS_DTS_PVTIRQTRMASKR    \ DTS PVT IRQ timer mask register
  $54 constant DTS_DTS_TS_MR            \ DTS PVT IRQ TS mask register
  $60 constant DTS_DTS_PVTTR_SR         \ DTS PVT IRQ timer status register
  $64 constant DTS_DTS_TS_ISR           \ DTS PVT IRQ TS status register
  $70 constant DTS_DTS_PVTTMRRAW_ISR    \ DTS PVT IRQ timer raw status register
  $74 constant DTS_DTS_TSRAW_ISR        \ DTS PVT IRQ TS raw status register
  $80 constant DTS_DTS_TSCCLKSYNTHR     \ DTS TSC clock synthesizer register
  $84 constant DTS_DTS_TSCSDIFDISABLER  \ DTS TSC SDIF interface disable register
  $88 constant DTS_DTS_TSCSDIF_SR       \ DTS TSC SDIF status register
  $8C constant DTS_DTS_TSCSDIF_CR       \ DTS TSC SDIF register
  $90 constant DTS_DTS_TSCSDIFHALTR     \ DTS TSC SDIF halt register
  $94 constant DTS_DTS_TSCSDIF_CFGR     \ DTS TSC SDIF control register
  $A0 constant DTS_DTS_TSCSMPL_CR       \ DTS TSC sample control register
  $A4 constant DTS_DTS_TSCSDIFSMPLCLRR  \ DTS TSC sample clear register
  $A8 constant DTS_DTS_TSCSMPLCNTR      \ DTS TSC sample count register
  $C0 constant DTS_DTS_TS0_IER          \ DTS TS0 IRQ enable register
  $C4 constant DTS_DTS_TS0_ISR          \ DTS TS0 IRQ status register
  $C8 constant DTS_DTS_TS0_ICR          \ DTS TS0 IRQ clear register
  $CC constant DTS_DTS_TS0IRQTESTR      \ DTS TS0 IRQ test register
  $D0 constant DTS_DTS_TS0SDIFRDATAR    \ DTS TS0 SDIF RDATA register
  $D4 constant DTS_DTS_TS0SDIFDONER     \ DTS TS0 SDIF done register
  $D8 constant DTS_DTS_TS0SDIFDATAR     \ DTS TS0 SDIF data register
  $E0 constant DTS_DTS_TS0ALARMA_CFGR   \ DTS TS0 alarm A configuration register
  $E4 constant DTS_DTS_TS0ALARMB_CFGR   \ DTS TS0 alarm B configuration register
  $E8 constant DTS_DTS_TS0HLSAMPLER     \ DTS TS0 high/low sample register
  $EC constant DTS_DTS_TS0HILORESETR    \ DTS TS0 high/low reset register
  $100 constant DTS_DTS_TS1_IER         \ DTS TS1 IRQ enable register
  $104 constant DTS_DTS_TS1_ISR         \ DTS TS1 IRQ status register
  $108 constant DTS_DTS_TS1_ICR         \ DTS TS1 IRQ clear register
  $10C constant DTS_DTS_TS1IRQTESTR     \ DTS TS1 IRQ test register
  $110 constant DTS_DTS_TS1SDIFRDATAR   \ DTS TS1 SDIF RDATA register
  $114 constant DTS_DTS_TS1SDIFDONER    \ DTS TS1 SDIF done register
  $118 constant DTS_DTS_TS1SDIFDATAR    \ DTS TS1 SDIF data register
  $120 constant DTS_DTS_TS1ALARMA_CFGR  \ DTS TS1 alarm A configuration register
  $124 constant DTS_DTS_TS1ALARMB_CFGR  \ DTS TS1 alarm B configuration register
  $128 constant DTS_DTS_TS1HLSAMPLER    \ DTS TS1 high/low sample register
  $12C constant DTS_DTS_TS1HILORESETR   \ DTS TS1 high/low reset register

: DTS_DEF ; [then]
