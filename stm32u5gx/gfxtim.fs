\
\ @file gfxtim.fs
\ @brief GFXTIM register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GFXTIM_DEF

  [ifdef] GFXTIM_GFXTIM_CR_DEF
    \
    \ @brief GFXTIM configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_TES                     \ [0x00 : 2] tearing source This field selects the tearing-effect source.
    $04 constant GFXTIM_TEPOL                   \ [0x04] tearing--effect polarity This bit selects the tearing-effect polarity.
    $08 constant GFXTIM_SYNCS                   \ [0x08 : 2] synchronization source This field selects the synchronization signals (HSYNC and VSYNC) sources.
    $10 constant GFXTIM_FCCOE                   \ [0x10] frame-clock calibration output enable This bit enables the frame-clock output.
    $11 constant GFXTIM_LCCOE                   \ [0x11] line-clock calibration output enable This bit enables the line-clock output.
  [then]


  [ifdef] GFXTIM_GFXTIM_CGCR_DEF
    \
    \ @brief GFXTIM clock generator configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LCS                     \ [0x00 : 3] line clock source This field configures the line clock source.
    $04 constant GFXTIM_LCCCS                   \ [0x04] line clock counter clock source This bit configures the clock source for the line clock counter.
    $08 constant GFXTIM_LCCFR                   \ [0x08] line clock counter force reload This bit forces line clock counter reload.
    $0c constant GFXTIM_LCCHRS                  \ [0x0c : 3] line clock counter hardware reload source This field configures the hardware reload source for the line clock counter.
    $10 constant GFXTIM_FCS                     \ [0x10 : 3] frame clock source This field configures the frame clock source
    $14 constant GFXTIM_FCCCS                   \ [0x14 : 3] frame clock counter clock source This field configures the clock source for the frame clock counter.
    $18 constant GFXTIM_FCCFR                   \ [0x18] frame clock counter force reload This bit forces frame clock counter reload
    $1c constant GFXTIM_FCCHRS                  \ [0x1c : 3] frame- -clock counter hardware reload source This field configures the hardware reload source for the frame- -clock counter.
  [then]


  [ifdef] GFXTIM_GFXTIM_TCR_DEF
    \
    \ @brief GFXTIM timers configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCEN                   \ [0x00] absolute frame counter enable This bit enables the absolute frame counter.
    $01 constant GFXTIM_FAFCR                   \ [0x01] force absolute frame counter reset This bit forces the reset of the absolute frame counter.
    $04 constant GFXTIM_ALCEN                   \ [0x04] absolute line counter enable This bit enables the absolute line counter.
    $05 constant GFXTIM_FALCR                   \ [0x05] force absolute line counter reset This bit forces the reset of the absolute line counter.
    $10 constant GFXTIM_RFC1EN                  \ [0x10] relative frame counter 1 enable This bit enables the relative frame counter 1.
    $11 constant GFXTIM_RFC1CM                  \ [0x11] relative frame counter 1 continuous mode This bit enables the continuous mode of the relative frame counter 1.
    $12 constant GFXTIM_FRFC1R                  \ [0x12] force relative frame counter 1 reload This bit forces the reload of the relative frame counter 1.
    $14 constant GFXTIM_RFC2EN                  \ [0x14] relative frame counter 2 enable This bit enables the relative frame counter 2.
    $15 constant GFXTIM_RFC2CM                  \ [0x15] relative frame counter 2 continuous mode This bit enables the continuous mode of the relative frame counter 2.
    $16 constant GFXTIM_FRFC2R                  \ [0x16] force relative frame counter 2 reload This bit forces the reload of the relative frame counter 2.
  [then]


  [ifdef] GFXTIM_GFXTIM_TDR_DEF
    \
    \ @brief GFXTIM timers disable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCDIS                  \ [0x00] absolute frame counter disable This bit disables the absolute frame counter.
    $04 constant GFXTIM_ALCDIS                  \ [0x04] absolute line counter disable This bit disables the absolute line counter.
    $10 constant GFXTIM_RFC1DIS                 \ [0x10] relative frame counter 1 disable This bit disables the relative frame counter 1.
    $14 constant GFXTIM_RFC2DIS                 \ [0x14] relative frame counter 2 disable This bit disables the relative frame counter 2.
  [then]


  [ifdef] GFXTIM_GFXTIM_EVCR_DEF
    \
    \ @brief GFXTIM events control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_EV1EN                   \ [0x00] event 1 enable This bit enables the complex event 1 generation.
    $01 constant GFXTIM_EV2EN                   \ [0x01] event 2 enable This bit enables the complex event 2 generation.
    $02 constant GFXTIM_EV3EN                   \ [0x02] event 3 enable This bit enables the complex event 3 generation.
    $03 constant GFXTIM_EV4EN                   \ [0x03] event 4 enable This bit enables the complex event 4 generation.
  [then]


  [ifdef] GFXTIM_GFXTIM_EVSR_DEF
    \
    \ @brief GFXTIM events selection register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LES1                    \ [0x00 : 3] line-event selection 1 This field defines the line-event selection for complex event 1 generation. others: reserved
    $04 constant GFXTIM_FES1                    \ [0x04 : 3] frame-event selection 1 This field defines the frame-event selection for complex event 1 generation. others: reserved
    $08 constant GFXTIM_LES2                    \ [0x08 : 3] line-event selection 2 This field defines the line-event selection for complex event 2 generation. others: reserved
    $0c constant GFXTIM_FES2                    \ [0x0c : 3] frame-event selection 2 This field defines the frame-event selection for complex event 2 generation. others: reserved
    $10 constant GFXTIM_LES3                    \ [0x10 : 3] line-event selection 3 This field defines the line-event selection for complex event 3 generation. others: reserved
    $14 constant GFXTIM_FES3                    \ [0x14 : 3] frame-event selection 3 This field defines the frame-event selection for complex event 3 generation. others: reserved
    $18 constant GFXTIM_LES4                    \ [0x18 : 3] line-event selection 4 This field defines the line-event selection for complex event 4 generation. others: Reserved
    $1c constant GFXTIM_FES4                    \ [0x1c : 3] frame-event selection 4 This field defines the frame-event selection for complex event 4 generation. others: reserved
  [then]


  [ifdef] GFXTIM_GFXTIM_WDGTCR_DEF
    \
    \ @brief GFXTIM watchdog timer configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_WDGEN                   \ [0x00] watchdog enable This bit enables the graphic watchdog.
    $01 constant GFXTIM_WDGDIS                  \ [0x01] watchdog disable This bit disables the graphic watchdog.
    $02 constant GFXTIM_WDGS                    \ [0x02] watchdog status This bit returns the status of the graphic watchdog.
    $04 constant GFXTIM_WDGHRC                  \ [0x04 : 2] watchdog hardware reload configuration This field configures the watchdog hardware reload.
    $08 constant GFXTIM_WDGCS                   \ [0x08 : 4] watchdog clock source This field selects the watchdog clock source. others: reserved
    $10 constant GFXTIM_FWDGR                   \ [0x10] force watchdog reload This bit forces the reload of the graphic watchdog.
  [then]


  [ifdef] GFXTIM_GFXTIM_ISR_DEF
    \
    \ @brief GFXTIM interrupt status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCOF                   \ [0x00] absolute frame counter overflow flag This bit indicates an overflow occurred on the absolute frame counter.
    $01 constant GFXTIM_ALCOF                   \ [0x01] absolute line counter overflow flag This bit indicates an overflow occurred on the absolute line counter.
    $02 constant GFXTIM_TEF                     \ [0x02] tearing-effect flag This bit indicates a tearing effect event occurred.
    $04 constant GFXTIM_AFCC1F                  \ [0x04] absolute frame counter compare 1 flag This bit indicates match on compare 1 of the absolute frame counter.
    $08 constant GFXTIM_ALCC1F                  \ [0x08] absolute line counter compare 1 flag This bit indicates match on compare 1 of the absolute line counter.
    $09 constant GFXTIM_ALCC2F                  \ [0x09] absolute line counter compare 2 flag This bit indicates match on compare 2 of the absolute line counter.
    $0c constant GFXTIM_RFC1RF                  \ [0x0c] relative frame counter 1 reload flag This bit indicates relative frame counter 1 has been reloaded.
    $0d constant GFXTIM_RFC2RF                  \ [0x0d] relative frame counter 2 reload flag This bit indicates relative frame counter 2 has been reloaded.
    $10 constant GFXTIM_EV1F                    \ [0x10] event 1 flag This bit indicates a complex event 1 occurred.
    $11 constant GFXTIM_EV2F                    \ [0x11] event 2 flag This bit indicates a complex event 2 occurred.
    $12 constant GFXTIM_EV3F                    \ [0x12] event 3 flag This bit indicates a complex event 3 occurred.
    $13 constant GFXTIM_EV4F                    \ [0x13] event 4 flag This bit indicates a complex event 4 occurred.
    $18 constant GFXTIM_WDGAF                   \ [0x18] watchdog alarm flag This bit indicates that a graphic watchdog alarm occurred.
    $19 constant GFXTIM_WDGPF                   \ [0x19] watchdog pre-alarm flag This bit indicates that a graphic watchdog pre-alarm occurred.
  [then]


  [ifdef] GFXTIM_GFXTIM_ICR_DEF
    \
    \ @brief GFXTIM interrupt clear register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_CAFCOF                  \ [0x00] clear absolute frame counter overflow flag This bit clears AFCOF in GXTIM_ISR.
    $01 constant GFXTIM_CALCOF                  \ [0x01] clear absolute line counter overflow flag This bit clears ALCOF in GXTIM_ISR.
    $02 constant GFXTIM_CTEF                    \ [0x02] clear tearing-effect flag This bit clears TEF in GXTIM_ISR.
    $04 constant GFXTIM_CAFCC1F                 \ [0x04] clear absolute frame counter compare 1 flag This bit clears AFCC1F in GXTIM_ISR.
    $08 constant GFXTIM_CALCC1F                 \ [0x08] clear absolute line counter compare 1 flag This bit clears ALCC1F in GXTIM_ISR.
    $09 constant GFXTIM_CALCC2F                 \ [0x09] clear absolute line counter compare 2 flag This bit clears ALCC2F in GXTIM_ISR.
    $0c constant GFXTIM_CRFC1RF                 \ [0x0c] clear relative frame counter 1 reload flag This bit clears RFC1RF in GXTIM_ISR.
    $0d constant GFXTIM_CRFC2RF                 \ [0x0d] clear relative frame counter 2 reload flag This bit clears RFC2RF in GXFXTIM_ISR.
    $10 constant GFXTIM_CEV1F                   \ [0x10] clear event 1 flag This bit EV1F in GXFXTIM_ISR.
    $11 constant GFXTIM_CEV2F                   \ [0x11] clear event 2 flag This bit clears EV2F in GXFXTIM_ISR.
    $12 constant GFXTIM_CEV3F                   \ [0x12] clear event 3 flag This bit clears EV3F in GXFXTIM_ISR.
    $13 constant GFXTIM_CEV4F                   \ [0x13] clear event 4 flag This bit clears EV4F in GXFXTIM_ISR.
    $18 constant GFXTIM_CWDGAF                  \ [0x18] clear watchdog alarm flag This bit clears WDGAF in GXFXTIM_ISR.
    $19 constant GFXTIM_CWDGPF                  \ [0x19] clear watchdog pre-alarm flag This bit clears WDGPF in GXFXTIM_ISR.
  [then]


  [ifdef] GFXTIM_GFXTIM_IER_DEF
    \
    \ @brief GFXTIM interrupt enable register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCOIE                  \ [0x00] absolute frame counter overflow interrupt enable This bit enables the absolute frame counter overflow interrupt generation.
    $01 constant GFXTIM_ALCOIE                  \ [0x01] absolute line counter overflow interrupt enable This bit enables the absolute line counter overflow interrupt generation.
    $02 constant GFXTIM_TEIE                    \ [0x02] tearing-effect interrupt enable This bit enables the Tearing Effect interrupt generation.
    $04 constant GFXTIM_AFCC1IE                 \ [0x04] absolute frame counter compare 1 interrupt enable This bit enables the absolute frame counter compare interrupt generation.
    $08 constant GFXTIM_ALCC1IE                 \ [0x08] absolute line counter compare 1 interrupt enable This bit enables the absolute line counter compare 1 interrupt generation.
    $09 constant GFXTIM_ALCC2IE                 \ [0x09] absolute line counter compare 2 interrupt enable This bit enables the absolute line counter compare 2 interrupt generation.
    $0c constant GFXTIM_RFC1RIE                 \ [0x0c] relative frame counter 1 reload interrupt enable This bit enables the relative frame counter 1 reload interrupt generation.
    $0d constant GFXTIM_RFC2RIE                 \ [0x0d] relative frame counter 2 reload interrupt enable This bit enables the relative frame counter 2 reload interrupt generation.
    $10 constant GFXTIM_EV1IE                   \ [0x10] event 1 interrupt enable This bit enables the complex event 1 interrupt generation.
    $11 constant GFXTIM_EV2IE                   \ [0x11] event 2 interrupt enable This bit enables the complex event 2 interrupt generation.
    $12 constant GFXTIM_EV3IE                   \ [0x12] event 3 interrupt enable This bit enables the complex event 3 interrupt generation.
    $13 constant GFXTIM_EV4IE                   \ [0x13] event 4 interrupt enable This bit enables the complex event 4 interrupt generation.
    $18 constant GFXTIM_WDGAIE                  \ [0x18] watchdog alarm interrupt enable This bit enables the watchdog alarm interrupt generation.
    $19 constant GFXTIM_WDGPIE                  \ [0x19] watchdog pre-alarm interrupt enable This bit enables the watchdog pre-alarm interrupt generation.
  [then]


  [ifdef] GFXTIM_GFXTIM_TSR_DEF
    \
    \ @brief GFXTIM timers status register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCS                    \ [0x00] absolute frame counter status This bit returns the status of the absolute frame counter.
    $04 constant GFXTIM_ALCS                    \ [0x04] absolute line counter status This bit returns the status of the absolute line counter.
    $10 constant GFXTIM_RFC1S                   \ [0x10] relative frame counter 1 status This bit returns the status of the relative frame counter 1.
    $14 constant GFXTIM_RFC2S                   \ [0x14] relative frame counter 2 status This bit returns the status of the relative frame counter 2.
  [then]


  [ifdef] GFXTIM_GFXTIM_LCCRR_DEF
    \
    \ @brief GFXTIM line clock counter reload register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_RELOAD                  \ [0x00 : 22] reload value Reload value of the line clock counter.
  [then]


  [ifdef] GFXTIM_GFXTIM_FCCRR_DEF
    \
    \ @brief GFXTIM frame clock counter reload register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_RELOAD                  \ [0x00 : 12] reload value Reload value of the frame clock counter.
  [then]


  [ifdef] GFXTIM_GFXTIM_ATR_DEF
    \
    \ @brief GFXTIM absolute time register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LINE                    \ [0x00 : 12] line number Current value of the absolute line counter.
    $0c constant GFXTIM_FRAME                   \ [0x0c : 20] fame number Current value of the absolute frame counter.
  [then]


  [ifdef] GFXTIM_GFXTIM_AFCR_DEF
    \
    \ @brief GFXTIM absolute frame counter register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 20] frame number Current value of the absolute frame counter. Note: This field can only be written when the absolute frame counter is disabled.
  [then]


  [ifdef] GFXTIM_GFXTIM_ALCR_DEF
    \
    \ @brief GFXTIM absolute line counter register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LINE                    \ [0x00 : 12] line number Current value of the absolute line counter. Note: This field can only be written when the absolute frame counter is disabled.
  [then]


  [ifdef] GFXTIM_GFXTIM_AFCC1R_DEF
    \
    \ @brief GFXTIM absolute frame counter compare 1 register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 20] frame number Compare 1 value for the absolute frame counter.
  [then]


  [ifdef] GFXTIM_GFXTIM_ALCC1R_DEF
    \
    \ @brief GFXTIM absolute line counter compare 1 register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LINE                    \ [0x00 : 12] line number Compare value 1 for the absolute line counter.
  [then]


  [ifdef] GFXTIM_GFXTIM_ALCC2R_DEF
    \
    \ @brief GFXTIM absolute line counter compare 2 register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LINE                    \ [0x00 : 12] line number Compare value 2 for the absolute line counter.
  [then]


  [ifdef] GFXTIM_GFXTIM_RFC1R_DEF
    \
    \ @brief GFXTIM relative frame counter 1 register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 12] frame number Current value of the relative frame counter 1.
  [then]


  [ifdef] GFXTIM_GFXTIM_RFC1RR_DEF
    \
    \ @brief GFXTIM relative frame counter 1 reload register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 12] frame reload value Reload value for the relative frame counter 1.
  [then]


  [ifdef] GFXTIM_GFXTIM_RFC2R_DEF
    \
    \ @brief GFXTIM relative frame counter 2 register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 12] frame number Current value of the relative frame counter 2.
  [then]


  [ifdef] GFXTIM_GFXTIM_RFC2RR_DEF
    \
    \ @brief GFXTIM relative frame counter 2 reload register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 12] frame reload value Reload value for the relative frame counter 2.
  [then]


  [ifdef] GFXTIM_GFXTIM_WDGCR_DEF
    \
    \ @brief GFXTIM watchdog counter register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_VALUE                   \ [0x00 : 16] value Current value of the watchdog counter.
  [then]


  [ifdef] GFXTIM_GFXTIM_WDGRR_DEF
    \
    \ @brief GFXTIM watchdog reload register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_RELOAD                  \ [0x00 : 16] reload value Reload value of the watchdog counter.
  [then]


  [ifdef] GFXTIM_GFXTIM_WDGPAR_DEF
    \
    \ @brief GFXTIM watchdog pre-alarm register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_PREALARM                \ [0x00 : 16] pre-alarm value Pre-alarm value of the watchdog counter.
  [then]

  \
  \ @brief GFXTIM register block
  \
  $00 constant GFXTIM_GFXTIM_CR         \ GFXTIM configuration register
  $04 constant GFXTIM_GFXTIM_CGCR       \ GFXTIM clock generator configuration register
  $08 constant GFXTIM_GFXTIM_TCR        \ GFXTIM timers configuration register
  $0C constant GFXTIM_GFXTIM_TDR        \ GFXTIM timers disable register
  $10 constant GFXTIM_GFXTIM_EVCR       \ GFXTIM events control register
  $14 constant GFXTIM_GFXTIM_EVSR       \ GFXTIM events selection register
  $20 constant GFXTIM_GFXTIM_WDGTCR     \ GFXTIM watchdog timer configuration register
  $30 constant GFXTIM_GFXTIM_ISR        \ GFXTIM interrupt status register
  $34 constant GFXTIM_GFXTIM_ICR        \ GFXTIM interrupt clear register
  $38 constant GFXTIM_GFXTIM_IER        \ GFXTIM interrupt enable register
  $3C constant GFXTIM_GFXTIM_TSR        \ GFXTIM timers status register
  $40 constant GFXTIM_GFXTIM_LCCRR      \ GFXTIM line clock counter reload register
  $44 constant GFXTIM_GFXTIM_FCCRR      \ GFXTIM frame clock counter reload register
  $50 constant GFXTIM_GFXTIM_ATR        \ GFXTIM absolute time register
  $54 constant GFXTIM_GFXTIM_AFCR       \ GFXTIM absolute frame counter register
  $58 constant GFXTIM_GFXTIM_ALCR       \ GFXTIM absolute line counter register
  $60 constant GFXTIM_GFXTIM_AFCC1R     \ GFXTIM absolute frame counter compare 1 register
  $70 constant GFXTIM_GFXTIM_ALCC1R     \ GFXTIM absolute line counter compare 1 register
  $74 constant GFXTIM_GFXTIM_ALCC2R     \ GFXTIM absolute line counter compare 2 register
  $80 constant GFXTIM_GFXTIM_RFC1R      \ GFXTIM relative frame counter 1 register
  $84 constant GFXTIM_GFXTIM_RFC1RR     \ GFXTIM relative frame counter 1 reload register
  $88 constant GFXTIM_GFXTIM_RFC2R      \ GFXTIM relative frame counter 2 register
  $8C constant GFXTIM_GFXTIM_RFC2RR     \ GFXTIM relative frame counter 2 reload register
  $A0 constant GFXTIM_GFXTIM_WDGCR      \ GFXTIM watchdog counter register
  $A4 constant GFXTIM_GFXTIM_WDGRR      \ GFXTIM watchdog reload register
  $A8 constant GFXTIM_GFXTIM_WDGPAR     \ GFXTIM watchdog pre-alarm register

: GFXTIM_DEF ; [then]
