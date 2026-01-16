\
\ @file dts.fs
\ @brief Digital temperature sensor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DTS PVT register lock register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant DTS_DTS_PVTREG_LOCKR_LOCK                        \ PVT software lock register


\
\ @brief DTS PVT lock status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_PVTLOCK_SR_SW_LOCK_STATUS                \ Software lock input status
$00000002 constant DTS_DTS_PVTLOCK_SR_HW_LOCK_STATUS                \ Hardware lock input status


\
\ @brief DTS PVT timer control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_PVTTMR_CR_TMR_DELAY                      \ Timer delay
$00010000 constant DTS_DTS_PVTTMR_CR_TMR_RUN                        \ Timer count enable bit


\
\ @brief DTS PVT timer status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_PVTTMR_SR_TMR_BUSY                       \ Counter busy flag
$00000002 constant DTS_DTS_PVTTMR_SR_TMR_DONE                       \ Counter delay expiration flag


\
\ @brief DTS PVT IRQ enable register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_PVT_IER_TMR_IRQ_ENABLE                   \ Timer IRQ source enable bit
$00000002 constant DTS_DTS_PVT_IER_TS_IRQ_ENABLE                    \ TS IRQ source enable bit


\
\ @brief DTS PVT IRQ timer mask register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_PVTIRQTRMASKR_TMR_IRQ_MASK               \ Timer IRQ source mask bit


\
\ @brief DTS PVT IRQ TS mask register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS_MR_TS0_IRQ_MASK                       \ TS0 IRQ source mask bit
$00000002 constant DTS_DTS_TS_MR_TS1_IRQ_MASK                       \ TS1 IRQ source mask bit


\
\ @brief DTS PVT IRQ timer status register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_PVTTR_SR_TMR_IRQ_STATUS                  \ Timer IRQ status bit after masking


\
\ @brief DTS PVT IRQ TS status register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS_ISR_TS0_IRQ_STATUS                    \ TS0 IRQ status bit after masking
$00000002 constant DTS_DTS_TS_ISR_TS1_IRQ_STATUS                    \ TS1 IRQ status bit after masking


\
\ @brief DTS PVT IRQ timer raw status register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_PVTTMRRAW_ISR_TMR_IRQ_RAW_STATUS         \ TMR IRQ status bit before masking


\
\ @brief DTS PVT IRQ TS raw status register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TSRAW_ISR_TS0_IRQ_RAW_STATUS             \ TS0 IRQ status bit before masking
$00000002 constant DTS_DTS_TSRAW_ISR_TS1_IRQ_RAW_STATUS             \ TS1 IRQ status bit before masking


\
\ @brief DTS TSC clock synthesizer register
\ Address offset: 0x80
\ Reset value: 0x00010000
\

$000000ff constant DTS_DTS_TSCCLKSYNTHR_CLK_SYNTH_LO                \ Synthesized clk_ts low period
$0000ff00 constant DTS_DTS_TSCCLKSYNTHR_CLK_SYNTH_HI                \ Synthesized clk_ts high period
$000f0000 constant DTS_DTS_TSCCLKSYNTHR_CLK_SYNTH_HOLD              \ SDA master-to-SDA slave output hold delay/SDA slave-to-SDA master input setup delay
$01000000 constant DTS_DTS_TSCCLKSYNTHR_CLK_SYTH_EN                 \ Synthesized clk_ts enable bit


\
\ @brief DTS TSC SDIF interface disable register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TSCSDIFDISABLER_TS0_SDIF_DISABLE         \ TS0 serial data interface (SDIF) disable bit
$00000002 constant DTS_DTS_TSCSDIFDISABLER_TS1_SDIF_DISABLE         \ TS1 serial data interface (SDIF) disable bit


\
\ @brief DTS TSC SDIF status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TSCSDIF_SR_SDIF_BUSY                     \ SDIF busy flag
$00000002 constant DTS_DTS_TSCSDIF_SR_SDIF_LOCK                     \ SDIF locked flag


\
\ @brief DTS TSC SDIF register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00ffffff constant DTS_DTS_TSCSDIF_CR_SDIF_WDATA                    \ Serial interface write data
$07000000 constant DTS_DTS_TSCSDIF_CR_SDIF_ADDR                     \ Serial interface register address
$08000000 constant DTS_DTS_TSCSDIF_CR_SDIF_WRN                      \ Serial interface write/no read control bit
$80000000 constant DTS_DTS_TSCSDIF_CR_SDIF_PROG                     \ Serial interface program request


\
\ @brief DTS TSC SDIF halt register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TSCSDIFHALTR_SDIF_STOP                   \ Serial data interface (SDIF) stop


\
\ @brief DTS TSC SDIF control register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000003 constant DTS_DTS_TSCSDIF_CFGR_SDIF_INHIBIT                \ Serial data interface (SDIF) programming inhibit


\
\ @brief DTS TSC sample control register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TSCSMPL_CR_SMPL_CTR_DISABLE              \ Sample counter disable bit
$00000002 constant DTS_DTS_TSCSMPL_CR_SMPL_CTR_HOLD                 \ Sample counter hold bit
$00000004 constant DTS_DTS_TSCSMPL_CR_SMPL_DISCARD                  \ Sample discard bit


\
\ @brief DTS TSC sample clear register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TSCSDIFSMPLCLRR_SMPL_CNTER_CLEAR         \ Sample counter clear bit


\
\ @brief DTS TSC sample count register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_TSCSMPLCNTR_SMPL_COUNT                   \ Sample counter


\
\ @brief DTS TS0 IRQ enable register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS0_IER_IRQ_EN_FAULT                     \ Fault IRQ enable bit
$00000002 constant DTS_DTS_TS0_IER_IRQ_EN_DONE                      \ Sample done IRQ enable bit
$00000008 constant DTS_DTS_TS0_IER_IRQ_EN_ALARMA                    \ Alarm A IRQ enable bit
$00000010 constant DTS_DTS_TS0_IER_IRQ_EN_ALARMB                    \ Alarm B IRQ enable bit


\
\ @brief DTS TS0 IRQ status register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS0_ISR_IRQ_STATUS_FAULT                 \ Fault IRQ status bit
$00000002 constant DTS_DTS_TS0_ISR_IRQ_STATUS_DONE                  \ Sample done IRQ status bit
$00000008 constant DTS_DTS_TS0_ISR_IRQ_STATUS_ALARMA                \ Alarm A IRQ status bit
$00000010 constant DTS_DTS_TS0_ISR_IRQ_STATUS_ALARMB                \ Alarm B IRQ status bit


\
\ @brief DTS TS0 IRQ clear register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS0_ICR_IRQ_CLEAR_FAULT                  \ Fault IRQ clear bit
$00000002 constant DTS_DTS_TS0_ICR_IRQ_CLEAR_DONE                   \ Sample done IRQ clear bit
$00000008 constant DTS_DTS_TS0_ICR_IRQ_CLEAR_ALARMA                 \ Alarm A IRQ clear bit
$00000010 constant DTS_DTS_TS0_ICR_IRQ_CLEAR_ALARMB                 \ Alarm B IRQ clear bit


\
\ @brief DTS TS0 IRQ test register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS0IRQTESTR_IRQ_TEST_FAULT               \ Fault IRQ test bit
$00000002 constant DTS_DTS_TS0IRQTESTR_IRQ_TEST_DONE                \ Sample done IRQ test bit
$00000008 constant DTS_DTS_TS0IRQTESTR_IRQ_TEST_ALARMA              \ Alarm A IRQ test bit
$00000010 constant DTS_DTS_TS0IRQTESTR_IRQ_TEST_ALARMB              \ Alarm B IRQ test bit


\
\ @brief DTS TS0 SDIF RDATA register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00ffffff constant DTS_DTS_TS0SDIFRDATAR_SDIF_RDATA                 \ SDIF read data


\
\ @brief DTS TS0 SDIF done register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS0SDIFDONER_SDIF_SMPL_DONE              \ Sample done flag


\
\ @brief DTS TS0 SDIF data register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_TS0SDIFDATAR_SAMPLE_DATA                 \ Sample data.
$00010000 constant DTS_DTS_TS0SDIFDATAR_SAMPLE_TYPE                 \ TS sample type
$00020000 constant DTS_DTS_TS0SDIFDATAR_SAMPLE_FAULT                \ Sample fault


\
\ @brief DTS TS0 alarm A configuration register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_TS0ALARMA_CFGR_HYSTA_THRESH              \ Alarm A hysteresis threshold
$ffff0000 constant DTS_DTS_TS0ALARMA_CFGR_ALARMA_THRESH             \ Alarm A threshold


\
\ @brief DTS TS0 alarm B configuration register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_TS0ALARMB_CFGR_HYSTB_THRESH              \ Alarm B hysteresis threshold
$ffff0000 constant DTS_DTS_TS0ALARMB_CFGR_ALARMB_THRESH             \ Alarm B threshold


\
\ @brief DTS TS0 high/low sample register
\ Address offset: 0xE8
\ Reset value: 0x0000FFFF
\

$0000ffff constant DTS_DTS_TS0HLSAMPLER_SMPL_LO                     \ Lowest valid data sample value received
$ffff0000 constant DTS_DTS_TS0HLSAMPLER_SMPL_HI                     \ Highest valid data sample value received


\
\ @brief DTS TS0 high/low reset register
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS0HILORESETR_SMPL_LO_SET                \ Sample Low Set
$00000002 constant DTS_DTS_TS0HILORESETR_SMPL_HI_CLR                \ Sample high clear 0


\
\ @brief DTS TS1 IRQ enable register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS1_IER_IRQ_EN_FAULT                     \ Fault IRQ enable bit
$00000002 constant DTS_DTS_TS1_IER_IRQ_EN_DONE                      \ Sample done IRQ enable bit
$00000008 constant DTS_DTS_TS1_IER_IRQ_EN_ALARMA                    \ Alarm A IRQ enable bit
$00000010 constant DTS_DTS_TS1_IER_IRQ_EN_ALARMB                    \ Alarm B IRQ enable bit


\
\ @brief DTS TS1 IRQ status register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS1_ISR_IRQ_STATUS_FAULT                 \ Fault IRQ status bit
$00000002 constant DTS_DTS_TS1_ISR_IRQ_STATUS_DONE                  \ Sample done IRQ status bit
$00000008 constant DTS_DTS_TS1_ISR_IRQ_STATUS_ALARMA                \ Alarm A IRQ status bit
$00000010 constant DTS_DTS_TS1_ISR_IRQ_STATUS_ALARMB                \ Alarm B IRQ status bit


\
\ @brief DTS TS1 IRQ clear register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS1_ICR_IRQ_CLEAR_FAULT                  \ Fault IRQ clear bit
$00000002 constant DTS_DTS_TS1_ICR_IRQ_CLEAR_DONE                   \ Sample done IRQ clear bit
$00000008 constant DTS_DTS_TS1_ICR_IRQ_CLEAR_ALARMA                 \ Alarm A IRQ clear bit
$00000010 constant DTS_DTS_TS1_ICR_IRQ_CLEAR_ALARMB                 \ Alarm B IRQ clear bit


\
\ @brief DTS TS1 IRQ test register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS1IRQTESTR_IRQ_TEST_FAULT               \ Fault IRQ test bit
$00000002 constant DTS_DTS_TS1IRQTESTR_IRQ_TEST_DONE                \ Sample done IRQ test bit
$00000008 constant DTS_DTS_TS1IRQTESTR_IRQ_TEST_ALARMA              \ Alarm A IRQ test bit
$00000010 constant DTS_DTS_TS1IRQTESTR_IRQ_TEST_ALARMB              \ Alarm B IRQ test bit


\
\ @brief DTS TS1 SDIF RDATA register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00ffffff constant DTS_DTS_TS1SDIFRDATAR_SDIF_RDATA                 \ SDIF read data


\
\ @brief DTS TS1 SDIF done register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS1SDIFDONER_SDIF_SMPL_DONE              \ Sample done flag


\
\ @brief DTS TS1 SDIF data register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_TS1SDIFDATAR_SAMPLE_DATA                 \ Sample data.
$00010000 constant DTS_DTS_TS1SDIFDATAR_SAMPLE_TYPE                 \ TS sample type
$00020000 constant DTS_DTS_TS1SDIFDATAR_SAMPLE_FAULT                \ Sample fault


\
\ @brief DTS TS1 alarm A configuration register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_TS1ALARMA_CFGR_HYSTA_THRESH              \ Alarm A hysteresis threshold
$ffff0000 constant DTS_DTS_TS1ALARMA_CFGR_ALARMA_THRESH             \ Alarm A threshold


\
\ @brief DTS TS1 alarm B configuration register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000ffff constant DTS_DTS_TS1ALARMB_CFGR_HYSTB_THRESH              \ Alarm B hysteresis threshold
$ffff0000 constant DTS_DTS_TS1ALARMB_CFGR_ALARMB_THRESH             \ Alarm B threshold


\
\ @brief DTS TS1 high/low sample register
\ Address offset: 0x128
\ Reset value: 0x0000FFFF
\

$0000ffff constant DTS_DTS_TS1HLSAMPLER_SMPL_LO                     \ Lowest valid data sample value received
$ffff0000 constant DTS_DTS_TS1HLSAMPLER_SMPL_HI                     \ Highest valid data sample value received


\
\ @brief DTS TS1 high/low reset register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000001 constant DTS_DTS_TS1HILORESETR_SMPL_LO_SET                \ Sample Low Set
$00000002 constant DTS_DTS_TS1HILORESETR_SMPL_HI_CLR                \ Sample high clear 0


\
\ @brief Digital temperature sensor
\
$4600a010 constant DTS_DTS_PVTREG_LOCKR  \ offset: 0x10 : DTS PVT register lock register
$4600a014 constant DTS_DTS_PVTLOCK_SR  \ offset: 0x14 : DTS PVT lock status register
$4600a020 constant DTS_DTS_PVTTMR_CR  \ offset: 0x20 : DTS PVT timer control register
$4600a024 constant DTS_DTS_PVTTMR_SR  \ offset: 0x24 : DTS PVT timer status register
$4600a040 constant DTS_DTS_PVT_IER  \ offset: 0x40 : DTS PVT IRQ enable register
$4600a050 constant DTS_DTS_PVTIRQTRMASKR  \ offset: 0x50 : DTS PVT IRQ timer mask register
$4600a054 constant DTS_DTS_TS_MR  \ offset: 0x54 : DTS PVT IRQ TS mask register
$4600a060 constant DTS_DTS_PVTTR_SR  \ offset: 0x60 : DTS PVT IRQ timer status register
$4600a064 constant DTS_DTS_TS_ISR  \ offset: 0x64 : DTS PVT IRQ TS status register
$4600a070 constant DTS_DTS_PVTTMRRAW_ISR  \ offset: 0x70 : DTS PVT IRQ timer raw status register
$4600a074 constant DTS_DTS_TSRAW_ISR  \ offset: 0x74 : DTS PVT IRQ TS raw status register
$4600a080 constant DTS_DTS_TSCCLKSYNTHR  \ offset: 0x80 : DTS TSC clock synthesizer register
$4600a084 constant DTS_DTS_TSCSDIFDISABLER  \ offset: 0x84 : DTS TSC SDIF interface disable register
$4600a088 constant DTS_DTS_TSCSDIF_SR  \ offset: 0x88 : DTS TSC SDIF status register
$4600a08c constant DTS_DTS_TSCSDIF_CR  \ offset: 0x8C : DTS TSC SDIF register
$4600a090 constant DTS_DTS_TSCSDIFHALTR  \ offset: 0x90 : DTS TSC SDIF halt register
$4600a094 constant DTS_DTS_TSCSDIF_CFGR  \ offset: 0x94 : DTS TSC SDIF control register
$4600a0a0 constant DTS_DTS_TSCSMPL_CR  \ offset: 0xA0 : DTS TSC sample control register
$4600a0a4 constant DTS_DTS_TSCSDIFSMPLCLRR  \ offset: 0xA4 : DTS TSC sample clear register
$4600a0a8 constant DTS_DTS_TSCSMPLCNTR  \ offset: 0xA8 : DTS TSC sample count register
$4600a0c0 constant DTS_DTS_TS0_IER  \ offset: 0xC0 : DTS TS0 IRQ enable register
$4600a0c4 constant DTS_DTS_TS0_ISR  \ offset: 0xC4 : DTS TS0 IRQ status register
$4600a0c8 constant DTS_DTS_TS0_ICR  \ offset: 0xC8 : DTS TS0 IRQ clear register
$4600a0cc constant DTS_DTS_TS0IRQTESTR  \ offset: 0xCC : DTS TS0 IRQ test register
$4600a0d0 constant DTS_DTS_TS0SDIFRDATAR  \ offset: 0xD0 : DTS TS0 SDIF RDATA register
$4600a0d4 constant DTS_DTS_TS0SDIFDONER  \ offset: 0xD4 : DTS TS0 SDIF done register
$4600a0d8 constant DTS_DTS_TS0SDIFDATAR  \ offset: 0xD8 : DTS TS0 SDIF data register
$4600a0e0 constant DTS_DTS_TS0ALARMA_CFGR  \ offset: 0xE0 : DTS TS0 alarm A configuration register
$4600a0e4 constant DTS_DTS_TS0ALARMB_CFGR  \ offset: 0xE4 : DTS TS0 alarm B configuration register
$4600a0e8 constant DTS_DTS_TS0HLSAMPLER  \ offset: 0xE8 : DTS TS0 high/low sample register
$4600a0ec constant DTS_DTS_TS0HILORESETR  \ offset: 0xEC : DTS TS0 high/low reset register
$4600a100 constant DTS_DTS_TS1_IER  \ offset: 0x100 : DTS TS1 IRQ enable register
$4600a104 constant DTS_DTS_TS1_ISR  \ offset: 0x104 : DTS TS1 IRQ status register
$4600a108 constant DTS_DTS_TS1_ICR  \ offset: 0x108 : DTS TS1 IRQ clear register
$4600a10c constant DTS_DTS_TS1IRQTESTR  \ offset: 0x10C : DTS TS1 IRQ test register
$4600a110 constant DTS_DTS_TS1SDIFRDATAR  \ offset: 0x110 : DTS TS1 SDIF RDATA register
$4600a114 constant DTS_DTS_TS1SDIFDONER  \ offset: 0x114 : DTS TS1 SDIF done register
$4600a118 constant DTS_DTS_TS1SDIFDATAR  \ offset: 0x118 : DTS TS1 SDIF data register
$4600a120 constant DTS_DTS_TS1ALARMA_CFGR  \ offset: 0x120 : DTS TS1 alarm A configuration register
$4600a124 constant DTS_DTS_TS1ALARMB_CFGR  \ offset: 0x124 : DTS TS1 alarm B configuration register
$4600a128 constant DTS_DTS_TS1HLSAMPLER  \ offset: 0x128 : DTS TS1 high/low sample register
$4600a12c constant DTS_DTS_TS1HILORESETR  \ offset: 0x12C : DTS TS1 high/low reset register

