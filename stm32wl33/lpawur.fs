\
\ @file lpawur.fs
\ @brief LPAWUR interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPAWUR_DEF

  [ifdef] LPAWUR_FRAME_CONFIG0_DEF
    \
    \ @brief FRAME_CONFIG0 register
    \ Address offset: 0x00
    \ Reset value: 0x02074012
    \
    $00 constant LPAWUR_PREAMBLE_THRESHOLD_COUNT     \ [0x00 : 8] The number of transitions for preamble detection when receiving the manchester encoded preamble.
    $08 constant LPAWUR_SYNC_LENGTH             \ [0x08] Frame sync pattern length ( Manchester encoded ).
    $0a constant LPAWUR_SYNC_THRESHOLD_COUNT    \ [0x0a : 6] detection threshold when receivng the Frame sync ( Manchester encoded).
    $10 constant LPAWUR_PAYLOAD_LENGTH          \ [0x10 : 4] The number of data Bytes in the payload ( decoded ).
    $15 constant LPAWUR_SLOW_CLK_CYCLE_PER_BIT_CNT     \ [0x15 : 5] The number of expected slow clock cycle per each manchester coded bit.
  [then]


  [ifdef] LPAWUR_FRAME_CONFIG1_DEF
    \
    \ @brief FRAME_CONFIG1 register
    \ Address offset: 0x04
    \ Reset value: 0x00024669
    \
    $00 constant LPAWUR_KI                      \ [0x00 : 4] ki gain value for the timing recovery loop.
    $04 constant LPAWUR_KP                      \ [0x04 : 4] kp gain value for the timing recovery loop.
    $08 constant LPAWUR_FRAME_SYNC_COUNTER_TIMEOUT     \ [0x08 : 8] The timeout in manchester encoded bits for the Frame Sync,it represents the number of samples after which in case the frame sync is not detected a sync_error is raised.
    $11 constant LPAWUR_PREAMBLE_ENABLE         \ [0x11] Preamble detection enable
    $12 constant LPAWUR_TREC_LOOP_ALGO_SEL      \ [0x12] Timing recovery loop algorithm selection:
  [then]


  [ifdef] LPAWUR_FRAME_SYNC_CONFIG_DEF
    \
    \ @brief FRAME_SYNC_CONFIG register
    \ Address offset: 0x08
    \ Reset value: 0x00009696
    \
    $00 constant LPAWUR_FRAME_SYNC_PATTERN_L    \ [0x00 : 16] The value of the frame sync pattern, Low word, manchester encoded, used when the frame sync length is 16 bit (default 0x9696 which represent a frame sync value of 0x99)
    $10 constant LPAWUR_FRAME_SYNC_PATTERN_H    \ [0x10 : 16] The value of the frame sync pattern, High word, manchester encoded, used only when the frame sync length is 32 bits (default 0x0000 )
  [then]


  [ifdef] LPAWUR_RFIP_CONFIG_DEF
    \
    \ @brief RFIP_CONFIG register
    \ Address offset: 0x0C
    \ Reset value: 0x00000006
    \
    $00 constant LPAWUR_LPAWUR_ENABLE           \ [0x00] Enable (start) or Disable (stop) the LPAWUR feature (0: disabled by default)
    $01 constant LPAWUR_WAKEUP_LEVEL            \ [0x01 : 2] - 00: the bit Sync has been detected
  [then]


  [ifdef] LPAWUR_RF_CONFIG_DEF
    \
    \ @brief RF_CONFIG register
    \ Address offset: 0x10
    \ Reset value: 0x000133EE
    \
    $00 constant LPAWUR_ED_SWITCH               \ [0x00] - 0 : Normal operation (default)
    $01 constant LPAWUR_CLKDIV                  \ [0x01 : 4] Calibrate 4kHz clock (programmable divider)
    $0b constant LPAWUR_AGC_LOW_LVL             \ [0x0b : 2] AGC level (Low) (default value: 0x2)
    $0d constant LPAWUR_ED_DC_CTRL              \ [0x0d] DC current subtraction enabling signal (default value: 0x1)
    $0e constant LPAWUR_AGC_HIGH_LVL            \ [0x0e : 4] AGC level (High) (default value: 0x4)
    $12 constant LPAWUR_ED_ICAL                 \ [0x12 : 3] Current versus VBAT calibration for ED
    $15 constant LPAWUR_LPF3_CAL                \ [0x15] LPF3_CAL
  [then]


  [ifdef] LPAWUR_AGC_CONFIG_DEF
    \
    \ @brief AGC_CONFIG register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPAWUR_AGC_MODE                \ [0x00 : 2] Define the working mode of the AGC:
    $02 constant LPAWUR_AGC_HOLD_MODE           \ [0x02] The behavior when the AGC is ON and is working in HOLD mode
    $03 constant LPAWUR_AGC_RESET_MODE          \ [0x03] The AGC reset behavior when the AGC is working in ON or HOLD mode
  [then]


  [ifdef] LPAWUR_PAYLOAD_0_DEF
    \
    \ @brief PAYLOAD_0 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPAWUR_PAYLOAD_0               \ [0x00 : 32] First part of the payload (Least significant Byte First)
  [then]


  [ifdef] LPAWUR_PAYLOAD_1_DEF
    \
    \ @brief PAYLOAD_1 register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPAWUR_PAYLOAD_1               \ [0x00 : 32] Second part of the payload (Least significant Byte First)
  [then]

  \
  \ @brief LPAWUR interrupt
  \
  $00 constant LPAWUR_FRAME_CONFIG0     \ FRAME_CONFIG0 register
  $04 constant LPAWUR_FRAME_CONFIG1     \ FRAME_CONFIG1 register
  $08 constant LPAWUR_FRAME_SYNC_CONFIG \ FRAME_SYNC_CONFIG register
  $0C constant LPAWUR_RFIP_CONFIG       \ RFIP_CONFIG register
  $10 constant LPAWUR_RF_CONFIG         \ RF_CONFIG register
  $14 constant LPAWUR_AGC_CONFIG        \ AGC_CONFIG register
  $1C constant LPAWUR_PAYLOAD_0         \ PAYLOAD_0 register
  $20 constant LPAWUR_PAYLOAD_1         \ PAYLOAD_1 register

: LPAWUR_DEF ; [then]
